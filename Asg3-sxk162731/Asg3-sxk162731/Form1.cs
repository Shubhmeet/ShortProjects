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


/* 
    Shubhmeet Kaur
    Human Computer Interaction CS6326.001  - By Jhon Cole
    Assignment 3 : Rebate form Analysis.
    
 */

namespace Asg3_sxk162731
{
    public partial class Form1 : Form
    {
        public Form1()  //form initialization.
        {
            InitializeComponent();

            ListView lvt = dataView;   //creating a list view object and assigning listview1 to it. 
            lvt.View = View.Details;

            submit_button.Enabled = false;
        }

        private void browse_button_Click(object sender, EventArgs e)
        {

            OpenFileDialog fdlg = new OpenFileDialog();
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                //get file path and location
                filePath.Text = fdlg.FileName;   
                // give focus to textbox
                filePath.Focus();   
                
            }

        }

       
        private void submit_button_Click(object sender, EventArgs e)   
        {

            string args = filePath.Text;


            if (!System.IO.File.Exists(args)) // checking if file exists.
            {
                // if the file locatoin from the text box doesnt exist, then throw an error.
                filePath.ForeColor = Color.Red;
                MessageBox.Show("Please choose a valid file and location");
                filePath.Clear();
                //filePath.BackColor = Color.White;

            }
            else
            {
                // file exists, select the entire set of data
                ListView lvt = dataView;
                lvt.View = View.Details;

                int[] recordTime;
                int[] interRecordTime;

                int index = 0;
                string lastInputime = "";
                int backspaceCount = 0;
                recordTime = new int[20];
                interRecordTime = new int[20];

                string startTime = "";
                string endTime = "";

                String[] arguments = Environment.GetCommandLineArgs();
                string outputfile = arguments[1];

                if (outputfile == "")  //if the output file location, not given as argument, default locaiotn is assigned.
                {
                    outputfile = "../../../CS6326Asg3.txt";
                }
                //check if file exist
                if (!System.IO.File.Exists(outputfile)) 
                {
                    //create output file if not existing.
                    var myfile = File.Create(outputfile);
                    myfile.Close();
                }


                index = 0;
                backspaceCount = 0;

                string line;
                StreamReader st = new StreamReader(args);
                while ((line = st.ReadLine()) != null)
                {
                    //reading each line from the text file.
                    string[] words = line.Split('\t');

                    //add the details in the line as the listview subitems.
                    recordTime[index] = timeDiff(words[12], words[13]); // work here

                    if (index != 0)
                    {
                        interRecordTime[index - 1] = timeDiff(lastInputime, words[12]);

                    }
                    backspaceCount = backspaceCount + int.Parse(words[14]);
                    lastInputime = words[13];
                    if (index == 0)
                    {
                        startTime = words[12];
                    }
                    if (index == 9)
                    {
                        endTime = words[13];
                    }
                    index++;
                }


               
                // display the required data
                lvt.Items.Add("Total number of Records:");
                lvt.Items[0].SubItems.Add("" + index);

                lvt.Items.Add("Minimum Inter-Record time:");
                lvt.Items[1].SubItems.Add("" + ConvertSectoMin(minimum(interRecordTime, index - 1)));

                lvt.Items.Add("Maximum Inter-Record time:");
                lvt.Items[2].SubItems.Add("" + ConvertSectoMin(maximum(interRecordTime, index - 1)));

                lvt.Items.Add("Average Inter-Record time:");
                lvt.Items[3].SubItems.Add("" + ConvertSectoMin(average(interRecordTime, index - 1)));

                lvt.Items.Add("Minimum entry time:");
                lvt.Items[4].SubItems.Add("" + ConvertSectoMin(minimum(recordTime, index)));

                lvt.Items.Add("Maximum entry time:");
                lvt.Items[5].SubItems.Add("" + ConvertSectoMin(maximum(recordTime, index)));

                lvt.Items.Add("Average entry time:");
                lvt.Items[6].SubItems.Add("" + ConvertSectoMin(average(recordTime, index)));

                
                lvt.Items.Add("Backspace Count:");
                lvt.Items[7].SubItems.Add("" + backspaceCount);

                lvt.Items.Add("Total Time:");
                lvt.Items[8].SubItems.Add("" + ConvertSectoMin(timeDiff(startTime, endTime)));

                

                // save items from listview to file
                saveToFile(outputfile);

            }

        }
        // save the listitems to output file
        public void saveToFile(string args) 
        {


            ListView lvt = dataView;
            string docstring = "";

            using (FileStream fs = new FileStream(args, FileMode.Truncate, FileAccess.Write))
            {
                for (int j = 0; j < lvt.Items.Count; j++)
                {
                    //iterate among items and save each item to file.

                    for (int i = 0; i < lvt.Items[j].SubItems.Count; i++)
                    {

                        docstring = docstring + lvt.Items[j].SubItems[i].Text + "\t";

                    }

                    fs.Write(Encoding.ASCII.GetBytes(docstring), 0, docstring.Length);


                    //add a line break.
                    byte[] newLine = Encoding.Default.GetBytes(Environment.NewLine);
                    fs.Write(newLine, 0, newLine.Length);

                    docstring = "";
                }


                fs.Close();
            }



        }


        //Calculate  minimum.
        public int minimum(int[] arr, int index)

        {
            int min = arr[0];
            for (int i = 0; i < index; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            return min;
        }

        //Calculate  maximum.
        public int maximum(int[] arr, int index)
        {
            int max = arr[0];

            for (int i = 0; i < index; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }
        //Calculate  average.
        public float average(int[] arr, int index)
        {
            float avg = 0;
            int no = 0;
            for (int i = 0; i < index; i++)
            {
                avg = avg + arr[i];
                no++;
            }

            return avg / no;
        }
        //Convert numeric seconds into minute format string.
        public string ConvertSectoMin(float sec)
        {
            int min = ((int)sec) / 60;
            float temp = ((int)sec - (min * 60));
            string temp2 = min.ToString() + ":" + temp.ToString();
            return temp2;
        }


        //Function to find time difference 
        public int timeDiff(string t1, string t2)
        {
            int diff = 0;

            int min1 = 0;
            int min2 = 0;

            int sec1 = 0;
            int sec2 = 0;

            char delimeter = ':';
            String[] temp;
            temp = new String[2];


            temp = t1.Split(delimeter);

            min1 = int.Parse(temp[0]);
            sec1 = int.Parse(temp[1]);

            temp = t2.Split(delimeter);

            min2 = int.Parse(temp[0]);
            sec2 = int.Parse(temp[1]);



            diff = (sec2 - sec1) + ((min2 - min1) * 60);

            return diff;
        }



        //validation function
        private void filePath_TextChanged(object sender, EventArgs e)
        {
            // check textbox length to be atleast 4 characters ,enable submit button.
            filePath.BackColor = Color.White;

            if (filePath.Text.Length < 5)
                submit_button.Enabled = false;
            else
                submit_button.Enabled = true;
        }

       
    }
}
