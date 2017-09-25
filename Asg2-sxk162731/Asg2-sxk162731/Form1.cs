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
using System.Text.RegularExpressions;
using System.Collections;

namespace Asg2_sxk162731
{



    public partial class Form1 : Form
    {
       
        bool update = false;
        int updateindex = 0;

        DateTime startTime;
        DateTime endTime;


        public Form1()
        {
            String[] arguments = Environment.GetCommandLineArgs();
 
            string args = arguments[1];
            InitializeComponent();

            //getting present date.
            DateTime dt = DateTime.UtcNow;
            date.Text = dt.ToString("d");


            //setting up width and heights.
            tableLayoutPanel3.Width = this.Size.Width;
            dataList.Width = tableLayoutPanel3.Width - 500;
            CenterToScreen();

            submitButton.Enabled = false;
            submitButton.Visible = true;

            //check for arguments, if not existing set to a default value.
            if (args == "")
            {
                args = "../../../CS6326Asg2.txt";
            }


            string line;
            //reading from existing cs6326Asg2.txt file.
            if (!System.IO.File.Exists(args)) // checking if file exists.
            {
                var myfile = File.Create(args);

                myfile.Close();
            }
            else
            {

                try
                {
                    StreamReader st = new StreamReader(args);
                    while ((line = st.ReadLine()) != null)
                    {
                        //reading each line from the text file.
                        string[] words = line.Split('\t');

                        ListViewItem lvt = new ListViewItem(words[0]);

                        //add the details in the line as the listview subitems.
                        for (int i = 1; i < words.Length; i++)
                        {
                            lvt.SubItems.Add(words[i]);
                        }

                        dataList.Items.Add(lvt);
                        //add the item to the listview.
                    }


                    clear();
                    st.Close();
                }
                catch
                {
                    //file is currently used or is not accesable.

                }
            }



        }

       
        private void submitbtn_Click(object sender, EventArgs e)    //function to check whole form and adds data or update it to the listview.
        {
            String[] arguments = Environment.GetCommandLineArgs();
            string args = arguments[1];
            if (args == "")
            {
                args = "../../../CS6326Asg2.txt";
            }

            if (!System.IO.File.Exists(args))
            {
                var myfile = File.Create(args);
                myfile.Close();
            }

            String errormsg = "";
            bool validated = true;
            int err = 1;

            DateTime dt1 = Convert.ToDateTime(date.Text);
            DateTime dt = DateTime.UtcNow;

            DateTime dt2 = Convert.ToDateTime(dt.ToString("d"));

            int result = DateTime.Compare(dt1, dt2);

            //Cehck for validations

            if (result <= 0)
            { //date is valid.
                date.BackColor = Color.White;
                date.ForeColor = Color.Black;
            }
            else
            {
                //date invalid, set date forgeround to red
                date.ForeColor = Color.Red;
                validated = false;
                date.Text = dt.ToString("d");
                errormsg += " Date format is wrong ";
            }

            if (!recordcheck(fName.Text, mName.Text, lName.Text))
            {
                //new entry validated.
                fName.BackColor = Color.White;
                lName.BackColor = Color.White;
                mName.BackColor = Color.White;
                fName.ForeColor = Color.Black;
                lName.ForeColor = Color.Black;
                mName.ForeColor = Color.Black;

            }
            else
            {
                // New entry not valid, set firstname, middle name, last name field backgrounds to red.
                fName.ForeColor = Color.Red;
                lName.ForeColor = Color.Red;
                mName.ForeColor = Color.Red;
                errormsg += " Name field cannot be of more than 20 characters and can't be null. ";
                validated = false;
                err = 0;
            }
            if (addressCheck(address1.Text) == true)
            {
                address1.BackColor = Color.White;
                address1.ForeColor = Color.Black;
            }
            else
            {
                address1.ForeColor = Color.Red;
                errormsg += "Address length can't be greater then 35 and less then 5.Please fill a valid address.";
                validated = false;
            }
            if (addressCheck2(address2.Text) == true)
            {
                address2.BackColor = Color.White;
                address2.ForeColor=Color.Black;
            }
            else
            {
                address2.ForeColor = Color.Red;
                errormsg += "Address length can't be greater then.Please fill a valid address.";
                validated = false;
            }
            if (phonecheck(phone.Text) == true)
            {
                //phone number validated
                phone.BackColor = Color.White;
                phone.ForeColor = Color.Black;
            }
            else
            {
                //phone number not validated, change phone background to red.
                phone.ForeColor = Color.Red;
                errormsg += " Phone Number is Invalid! It should be of 10-21 digits. ";
                validated = false;
            }


            if (zipcheck(zipCode.Text) == true)
            {
                //zipcode validated
                zipCode.BackColor = Color.White;
                zipCode.ForeColor = Color.Black;

            }
            else
            {
                //zipcode not validated, set zipcode field background to red.
                zipCode.ForeColor = Color.Red;
                errormsg += " Zip Code not valid! code must be atleast 4 digits and cant be greater then 9 digits. ";
                validated = false;
            }


            if (emailcheck(email.Text) == true)
            {
                //email validated
                email.BackColor = Color.White;
                email.ForeColor = Color.Black;

            }
            else
            {
                //email not validated, set email background to red.
                email.ForeColor = Color.Red;
                errormsg += " Email format is wrong and cannot be greater than 60 characters. ";
                validated = false;
            }
            if (cityCheck(city.Text) == true)
            {
                city.BackColor = Color.White;
                city.ForeColor = Color.Black;
            }
            else
            {
                city.ForeColor = Color.Red;
                errormsg += " City name is greater then 25 and less then 3";
                validated = false;
            }
            if (stateCheck(state.Text) == true)
            {
                state.BackColor = Color.White;
                state.ForeColor = Color.Black;
            }
            else
            {
                state.ForeColor = Color.Red;
                errormsg += "State name can be of 2 characters";
                validated = false;
            }

            if (validated) //checking for validation.
            {

                if (update == false)    //if its an updation process, then the same listview item has to be updated. hence another code in else part.
                {
                    endTime = DateTime.UtcNow;  //the time till when the user took for cmpleting an entry.


                    ListViewItem lvt = new ListViewItem(fName.Text.Replace("\t", " "));
                    // adding entered items onto a list view item subitems.
                    lvt.SubItems.Add(phone.Text.Replace("\t", " "));

                    //here .Replace("\t", " ") will replace any malicious entry with tabs from spoiling our saving schema in the file, by replacing tab with a space.

                    lvt.SubItems.Add(mName.Text.Replace("\t", " "));

                    lvt.SubItems.Add(lName.Text.Replace("\t", " "));

                    lvt.SubItems.Add(email.Text.Replace("\t", " "));

                    lvt.SubItems.Add(address1.Text.Replace("\t", " "));

                    lvt.SubItems.Add(address2.Text.Replace("\t", " "));

                    lvt.SubItems.Add(city.Text.Replace("\t", " "));

                    lvt.SubItems.Add(state.Text.Replace("\t", " "));

                    lvt.SubItems.Add(zipCode.Text.Replace("\t", " "));


                    lvt.SubItems.Add(date.Text.Replace("\t", " "));

                    if (proofOfPurchase.Checked == true)
                    {
                        lvt.SubItems.Add("yes");
                    }
                    else
                    {
                        lvt.SubItems.Add("no");
                    }

                    lvt.SubItems.Add(startTime.Minute + ":" + startTime.Second);
                    lvt.SubItems.Add(endTime.Minute + ":" + endTime.Second);


                    dataList.Items.Add(lvt); // finally adding the listview item to listview1.
                }
                else
                {

                    ListView lvt = dataList;

                    //iterate among items and save each item to file.
                    if (!recordcheck(fName.Text, mName.Text, lName.Text)) //check if fname, mname, lname matches other record, but not its own.
                    {
                        fName.BackColor = Color.White;
                        lName.BackColor = Color.White;
                        mName.BackColor = Color.White;

                        //updating all the subitems of the listview item with form values.
                        lvt.Items[updateindex].SubItems[0].Text = fName.Text;
                        lvt.Items[updateindex].SubItems[1].Text = phone.Text;
                        lvt.Items[updateindex].SubItems[2].Text = mName.Text;
                        lvt.Items[updateindex].SubItems[3].Text = lName.Text;
                        lvt.Items[updateindex].SubItems[4].Text = email.Text;
                        lvt.Items[updateindex].SubItems[5].Text = address1.Text;
                        lvt.Items[updateindex].SubItems[6].Text = address2.Text;
                        lvt.Items[updateindex].SubItems[7].Text = city.Text;
                        lvt.Items[updateindex].SubItems[8].Text = state.Text;
                        lvt.Items[updateindex].SubItems[9].Text = zipCode.Text;
                        lvt.Items[updateindex].SubItems[10].Text = date.Text;

                        if (proofOfPurchase.Checked == true)
                        {
                            lvt.Items[updateindex].SubItems[11].Text = "yes";
                        }
                        else
                        {
                            lvt.Items[updateindex].SubItems[11].Text = "no";

                        }

                        update = false;

                    }
                    else
                    {
                        //during Updation, if updating clashes with an existing item details, then this throws error.
                        fName.ForeColor = Color.Red;
                        lName.ForeColor = Color.Red;
                        mName.ForeColor = Color.Red;

                        System.Windows.Forms.MessageBox.Show("Similar entry with same name is found. " + errormsg);

                    }
                }

                savetofile(args);
                clear();
            }
            else
            {

                if (err == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Similar entry with same firstname, lastname and middlename found." + errormsg);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Could not save! there is something wrong with your highlighted entries." + errormsg);
                }

            }


            submitButton.Enabled = false;
            submitButton.Text = "Save";
        }

        private void field_Changed(object sender, EventArgs e)  //function that dynamically checks basic validity of fields and makes save button enabled.
        {

            submitButton.Enabled = false;
            deleteButton.Enabled = false;

            bool flag = false;

            //validating for non zero values and valid lengths.
            if (fName.Text.Length > 2
                && lName.Text.Length > 2
                && phone.Text.Length > 2
                && date.Text.Length >= 2
                && address1.Text.Length >= 4
                && city.Text.Length > 0
                && state.Text.Length == 2
                && zipCode.Text.Length >= 2
                && email.Text.Length > 2
                )
            {

                flag = true;
            }
            else flag = false;

            if (flag == true)
            {


                submitButton.Enabled = true;
            }
            if (addressCheck(address1.Text) == true)
                address1.ForeColor = Color.Black;
            if (addressCheck2(address2.Text) == true)
                address2.ForeColor = Color.Black;
            if (stateCheck(state.Text) == true)
                state.ForeColor = Color.Black;
            if (cityCheck(city.Text) == true)
                city.ForeColor = Color.Black;
            if (phonecheck(phone.Text) == true)
                phone.ForeColor = Color.Black;
            if (emailcheck(email.Text) == true)
                email.ForeColor = Color.Black;
            if (zipcheck(zipCode.Text) == true)
                zipCode.ForeColor= Color.Black;
            if (recordcheck(fName.Text, mName.Text, lName.Text))
            {
                fName.ForeColor = Color.Black;
                mName.ForeColor = Color.Black;
                lName.ForeColor = Color.Black;
            }

        }

        bool recordcheck(string fname, string mname, string lname)  //function for checking duplicate record.
        {
            bool flag = false;
            string hotword = "";

            ListView lvt = dataList;

            for (int i = 0; i < lvt.Items.Count; i++)
            {

                hotword = lvt.Items[i].SubItems[0].Text + lvt.Items[i].SubItems[2].Text + lvt.Items[i].SubItems[3].Text;
                if ((fname + mname + lname) == hotword)
                {
                    if (fname == lvt.Items[i].SubItems[0].Text
                        &&
                        mname == lvt.Items[i].SubItems[2].Text
                        &&
                        lname == lvt.Items[i].SubItems[3].Text)
                    {
                        if (update == true)    //check if the user is performing update operation, and the record matches with itself.
                        {
                            if (updateindex == i)
                            {
                                flag = false;
                            }
                        }
                        else
                        {
                            flag = true;
                            return flag;
                        }

                    }

                }
            }


            return flag;
        }

        bool addressCheck(String line1)
        {
            if (line1.Length < 5 || line1.Length > 36)
            {
                return false;
            }
            return true;
        }

        bool addressCheck2(String line2)
        {
            if (line2.Length > 35)
                return false;
            return true;
        }
        bool phonecheck(string phone)   //function checking for validitiy of the phone number.
        {
            string banned = "<>?,./()&^*%$#@!+-=*/.:;";
            bool flag = true;
            foreach (char c in phone)
            {
                if (char.IsLetter(c) == true)
                {
                    flag = false;
                    return false;
                }
                else if (banned.Contains(c))
                {
                    flag = false;
                    return false;
                }
                else
                {
                    flag = true;
                }
            }
            if (phone.Length < 10 || phone.Length > 21)
                flag = false;
            return flag;
        }

        bool stateCheck(string state)
        {
            if (state.Length == 2)
                return true;
            return false;
        }

        bool cityCheck(string city)
        {
            
            if (city.Length > 25 || city.Length < 3)
                return false;
            return true;
        }
        bool emailcheck(string email)
        {
            bool flag = true;

            //regex for email checking.
            string must = "@.";

            foreach (char c in must)
            {

                if (email.Contains(c))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    return flag;
                }
            }
            if (email.Length > 60)
                flag = false;
            return flag;
        }

        bool zipcheck(string zipCode)   //function to check validity of the zipcode.
        {
            string banned = "<>?,./()&^*%$#@!+-=*/.:;";
            bool flag = true;
            foreach (char c in zipCode)
            {
                if (char.IsLetter(c) == true)
                {
                    flag = false;
                    return false;
                }
                else if (banned.Contains(c))
                {
                    flag = false;
                    return false;
                }
                else
                {
                    flag = true;
                }
            }
            if (zipCode.Length < 4 || zipCode.Length > 9)
                flag = false;

            return flag;
        }

        void clear()    // this is like a reset funcition. it takes user to the default state.
        {
            fName.Text = "";
            lName.Text = "";
            mName.Text = "";
            phone.Text = "";
            email.Text = "";
            DateTime dt = DateTime.UtcNow;
            date.Text = dt.ToString("d");
            address1.Text = "";
            address2.Text = "";
            city.Text = "";
            state.Text = "";
            zipCode.Text = "";
            proofOfPurchase.Checked = true;

            fName.BackColor = Color.White;
            lName.BackColor = Color.White;
            mName.BackColor = Color.White;
            phone.BackColor = Color.White;
            email.BackColor = Color.White;
            date.BackColor = Color.White;
            address1.BackColor = Color.White;
            address2.BackColor = Color.White;
            city.BackColor = Color.White;
            state.BackColor = Color.White;
            zipCode.BackColor = Color.White;


            fName.ForeColor = Color.Black;
            lName.ForeColor = Color.Black;
            mName.ForeColor = Color.Black;
            phone.ForeColor = Color.Black;
            email.ForeColor = Color.Black;
            date.ForeColor = Color.Black;
            address1.ForeColor = Color.Black;
            address2.ForeColor = Color.Black;
            city.ForeColor = Color.Black;
            state.ForeColor = Color.Black;
            zipCode.ForeColor = Color.Black;

            submitButton.Enabled = false;
            deleteButton.Enabled = false;
            submitButton.Text = "Save";
            update = false;
        }

        private void clearbtn_Click(object sender, EventArgs e) // this is like a reset funcition. it takes user to the default state.
        {
            clear();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {


        }

        private void listView1_Leave(object sender, EventArgs e)
        {

            submitButton.Visible = true;

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)  //when user clicks on the listview items, we make the respective listview item details to appear in the form.
        {

            ListView lvt = dataList;
            clear();
            submitButton.Text = "Update";
            submitButton.Enabled = true;
            update = true;
            updateindex = lvt.SelectedIndices[0];


            fName.Text = lvt.SelectedItems[0].SubItems[0].Text.Split().First();
            phone.Text = lvt.SelectedItems[0].SubItems[1].Text;
            mName.Text = lvt.SelectedItems[0].SubItems[2].Text;
            lName.Text = lvt.SelectedItems[0].SubItems[3].Text;
            email.Text = lvt.SelectedItems[0].SubItems[4].Text;
            address1.Text = lvt.SelectedItems[0].SubItems[5].Text;
            address2.Text = lvt.SelectedItems[0].SubItems[6].Text;
            city.Text = lvt.SelectedItems[0].SubItems[7].Text;
            state.Text = lvt.SelectedItems[0].SubItems[8].Text;
            zipCode.Text = lvt.SelectedItems[0].SubItems[9].Text;
            date.Text = lvt.SelectedItems[0].SubItems[10].Text;

            if (lvt.SelectedItems[0].SubItems[11].Text == "yes")
                proofOfPurchase.Checked = true;
            else
                proofOfPurchase.Checked = false;

            deleteButton.Enabled = true;

        }

        private void delbtn_Click(object sender, EventArgs e)   //when delete button is clicked, user is asked to confirm the action and delete from listview.
        {

            if (System.Windows.Forms.MessageBox.Show("Do you really want to delete the entry?", "delete the entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                String[] arguments = Environment.GetCommandLineArgs();
                string args = arguments[1];
                //delete the entry.
                dataList.Items.RemoveAt(dataList.SelectedIndices[0]);
                clear();
                savetofile(args);
            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)   //function to include delete function through keyboard delete button.
        {
            if (Keys.Delete == e.KeyCode)
            {
                if (System.Windows.Forms.MessageBox.Show("Do you really want to delete the entry?", "delete the entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (ListViewItem listViewItem in ((ListView)sender).SelectedItems)
                    {
                        listViewItem.Remove();
                    }
                    clear();

                    String[] arguments = Environment.GetCommandLineArgs();
                    string args = arguments[0];
                    savetofile(args);
                }
            }
        }

        public void savetofile(string args) // the actual function for saving the listitems to file.
        {

            // String[] arguments = Environment.GetCommandLineArgs();
            // string args = arguments[0];

            ListView lvt = dataList;
            string docstring = "";

            using (FileStream fs = new FileStream(args, FileMode.Truncate, FileAccess.Write))
            {
                for (int j = 0; j < lvt.Items.Count; j++)
                {
                    //iterate among items and save each item to file.

                    for (int i = 0; i < 14; i++)
                    {

                        docstring = docstring + lvt.Items[j].SubItems[i].Text + "\t";

                    }

                    fs.Write(Encoding.ASCII.GetBytes(docstring), 0, docstring.Length);


                    //input a line break.
                    byte[] newLine = Encoding.Default.GetBytes(Environment.NewLine);
                    fs.Write(newLine, 0, newLine.Length);

                    docstring = "";
                }


                fs.Close();
            }



        }


        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)   // when an column in listview is clicked, sorting function.
        {

            // Perform the sort with these new sort options.
            this.dataList.Sort();



        }

        
        private void firstname_Enter(object sender, EventArgs e)
        {
            startTime = DateTime.UtcNow;    // set time when the user starts entering the entry.
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
