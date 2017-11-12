using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Net.Mail;

/*
* @ author :sxk162731
*/

namespace Asg5_sxk162731
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            submit.Enabled = false;
            //submit2.Enabled = false;
            progressBar.Visible = false;
            progress_text.Visible = false;
            progressbar_title.Text = "0";
            //excelprint.Enabled = false;
            save_Results.Enabled = false;
            submit.Text = "Search";
            cancel.Visible = false;



        }

        private void stringSearch_TextChanged(object sender, EventArgs e) // string changed event execution.
        {
            if (filename.Text.Length > 0 && stringSearch.Text.Length > 0)
            {
                submit.Enabled = true;
            }


        }

        private void help_Click(object sender, EventArgs e) // function reading the help text file and displaying as a messagebox.
        {
            string helpdata = "";
            string helpfile = "../../../help.txt"; // the help.txt file containing help content.
            if (!System.IO.File.Exists(helpfile))
            {
                var myfile = File.Create(helpfile);
                myfile.Close();
            }
            else
            {
                string line = "";
                StreamReader st = new StreamReader(helpfile);
                while ((line = st.ReadLine()) != null)
                {
                    //reading each line from the text file.
                    helpdata = helpdata + line + "\n";
                }
                st.Close();
            }

            // displaying help menu.
            System.Windows.Forms.MessageBox.Show("Welcome\n\n" + helpdata);


        }

        private void browse_Click(object sender, EventArgs e) // function to browse files 
        {
            OpenFileDialog fdialog = new OpenFileDialog();
            if (fdialog.ShowDialog() == DialogResult.OK)
            {
                filename.Text = fdialog.FileName;   //get filename and location from the fileexplorer window. 
                stringSearch.Focus();   
            }
        }

        private void clear_Click(object sender, EventArgs e)    //clear everything 
        {
            filename.Text = "";
            stringSearch.Text = "";
            stringSearch.BackColor = Color.White;
            filename.BackColor = Color.White;
            submit.Enabled = false;
            save_Results.Enabled = false;
            progressBar.Visible = false;
            submit.Text = "Search";
            progress_text.Visible = false;
            outputList.Items.Clear();
        }

        private void save_Results_Click(object sender, EventArgs e)    // store and save results in file.
        {
            SaveFileDialog sfdialog = new SaveFileDialog();
            sfdialog.ShowDialog();
            if (sfdialog.FileName != "")
            {
                SavetoFile(sfdialog.FileName);
                MessageBox.Show("Search Results has been stored to " + sfdialog.FileName + " successfully!");

            }
        }

        public void SavetoFile(string addrfile) // save file method.
        {

            ListView lvt = outputList;
            string temp = "";

            if (!System.IO.File.Exists(addrfile)) // checking if file exists.
            {
                //create output save result file 
                var myfile = File.Create(addrfile);
                myfile.Close();
            }

            using (FileStream fs = new FileStream(addrfile, FileMode.Truncate, FileAccess.Write))
            {
                for (int j = 0; j < lvt.Items.Count; j++)
                {
                    //save each item to file.
                    temp = "";
                    for (int i = 1; i < lvt.Items[j].SubItems.Count; i++)
                    {

                        temp = temp + lvt.Items[j].SubItems[i].Text + "\t";

                    }
                    fs.Write(Encoding.ASCII.GetBytes(temp), 0, temp.Length);
                    
                    byte[] newLine = Encoding.Default.GetBytes(Environment.NewLine);
                    fs.Write(newLine, 0, newLine.Length);


                }
                
                fs.Close();
            }

        }

       
        private void submit_Click(object sender, EventArgs e)   // used to search keySearchWords in file.
        {
            bool flag = true;
            save_Results.Enabled = false;
            outputList.Items.Clear();
            progress_text.Visible = false;
            progressBar.Visible = false;
            progressBar.Value = 1;
            //set min of progress bar tex
            progress_text.Text = "1%";
            
            filesearch.WorkerReportsProgress = true;
            filesearch.WorkerSupportsCancellation = true;

            string addrfile = filename.Text;
            string searchSearchWord = stringSearch.Text;

            clear_Click(sender, e);

            filename.Text = addrfile;
            stringSearch.Text = searchSearchWord;

            progress_text.Visible = true;
            if (!System.IO.File.Exists(addrfile)) // checking if file exists.
            {
                filename.BackColor = Color.Pink;
                flag = false;
                submit.Enabled = false;
                progress_text.ForeColor = Color.Red;
                progress_text.Text = "File does not exist! Please select a valid file.";
            }
            if (stringSearch.Text == "")
            {
                stringSearch.BackColor = Color.Pink;
                flag = false;
                submit.Enabled = false;
                progress_text.ForeColor = Color.Red;
                progress_text.Text = "Not a valid search string!Enter a valid string to search.";
            }


            if (flag == true)
            {
                /*if (!stringSearch.Text.Contains(".txt"))
                {
                    progress_text.Text = "Please choose a valid txt file!";
                    progress_text.ForeColor = Color.Red;
                }
                else*/
                {
                    cancel.Enabled = true;
                    cancel.Visible = true;
                    cancel.Focus();

                    progressBar.Visible = true;
                    progressbar_title.Text = "0";
                    submit.Enabled = false;
                    submit.Visible = false;
                    //start the thread
                    StartThread(addrfile);
                }
            }
        }

        

        private void filesearch_DoWork(object sender, DoWorkEventArgs e) // the background worker function.
        {

            System.ComponentModel.BackgroundWorker backworker;
            backworker = (System.ComponentModel.BackgroundWorker)sender;

            // create SearchWord object
            SearchWord obj = (SearchWord)e.Argument;
            obj.CountSearchWords(backworker, e);

        }

        private void filesearch_ProgressChanged(object sender, ProgressChangedEventArgs e) // this is called when ever you find a result.
        {

            SearchWord.currentState current_state = (SearchWord.currentState)e.UserState;

            progressbar_title.Text = (Convert.ToInt64(progressbar_title.Text) + 1).ToString();
  
            ListView lvt = outputList;
            int count = lvt.Items.Count;
            lvt.Items.Add((count + 1).ToString());
            lvt.Items[count].SubItems.Add(current_state.line_index.ToString());
            lvt.Items[count].SubItems.Add(current_state.matchedline.ToString());

            this.progress_text.Text = (current_state.work_done.ToString()) + "%";
            this.progressBar.Value = Convert.ToInt32(current_state.work_done.ToString());

        }

        private void filesearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)    // runs when the background searching work is done.
        {
            if (e.Error != null)
                MessageBox.Show("Error: " + e.Error.Message);
            else if (e.Cancelled)
            {
                //search cancelled.
                progress_text.Text = "Search has been Cancelled"; 
            }
            else
            {   //search successfully completed.
                progressBar.Value = 100;
                progress_text.Text = progressbar_title.Text + " Results found.";   //updating no of results found.
                submit.Enabled = true;
                submit.Visible = true;
                cancel.Visible = false;
                cancel.Enabled = false;
                progressBar.Visible = false;
                save_Results.Enabled = true;
                stringSearch.Focus();
            }

        }


        private void StartThread(string addrfile)   
        {
          
            // create object
            SearchWord obj = new SearchWord();

           obj.search_String = this.stringSearch.Text;
            obj.source_file = addrfile;

            // start asynchronous operation.
            {
                cancel.Enabled = true;
                cancel.Visible = true;
                filesearch.RunWorkerAsync(obj);
            }

        }



        private void cancel_Click(object sender, EventArgs e) // to stop searching
        {
            this.filesearch.CancelAsync();
            submit.Visible = true;
            progressBar.Visible = false;
            submit.Enabled = true;
            save_Results.Enabled = true;
            cancel.Visible = false;
            stringSearch.Focus();
        }

        
    }
}
