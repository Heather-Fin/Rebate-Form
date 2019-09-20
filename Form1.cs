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

namespace Heather_Finnegan_Assignment2
{
    public partial class Form1 : Form
    {
        // file path for data text file
        string fileName = "CS6326Asg2.txt";

        // bools for field validation check
        bool firstName = false;
        bool lastName = false;
        bool gender = false;
        bool number = false;
        bool email = false;
        bool address = false;
        bool city = false;
        bool state = false;
        bool zipcode = false;
        bool date = false;
        bool proof = false;

        public Form1()
        {
            InitializeComponent();
            txtBox_middleInitial.CharacterCasing = CharacterCasing.Upper;
            txtBox_state.CharacterCasing = CharacterCasing.Upper;
        }

        public void LoadFile()
        {
            listView1.Items.Clear();
            // if no file exists, create one
            if (!File.Exists(fileName))
            {
                var myFile = File.Create(fileName);
                myFile.Close();
            }
            // if file exists, show each entry on list view
            else
            {

                StreamReader sr = new StreamReader(fileName);

                while (sr.Peek() > -1)
                {
                    string line = sr.ReadLine();
                    string[] element = line.Split('\t');
                    ListViewItem li = new ListViewItem(element[0]);
                    li.SubItems.Add(element[2]);
                    li.SubItems.Add(element[9]);
                    for (int i = 0; i < 12; i++)
                    {
                        li.SubItems.Add(element[i]);
                    }
                    listView1.Items.Add(li);
                }
                sr.Close();

            }
        }

        private void TxtBox_firstName_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_firstName.TextLength > 0)
            {
                firstName = true;
            }
            else
            {
                firstName = false;
            }
            CheckValid();
        }

        private void TxtBox_lastName_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_lastName.TextLength > 0)
            {
                lastName = true;
            }
            else
            {
                lastName = false;
            }
            CheckValid();
        }

        private void DropDown_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDown_gender.Text.Length > 0)
            {
                gender = true;
            }
            else
            {
                gender = false;
            }
            CheckValid();
        }

        private void TxtBox_number_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_number.MaskFull)
            {
                number = true;
            }
            else
            {
                number = false;
            }
            CheckValid();
        }

        private void TxtBox_email_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_email.TextLength > 0)
            {
                email = true;
            }
            else
            {
                email = false;
            }
            CheckValid();
        }

        private void TxtBox_address1_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_address1.TextLength > 0)
            {
                address = true;
            }
            else
            {
                address = false;
            }
            CheckValid();
        }

        private void TxtBox_city_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_city.TextLength > 0)
            {
                city = true;
            }
            else
            {
                city = false;
            }
            CheckValid();
        }

        private void TxtBox_state_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_state.TextLength > 1)
            {
                state = true;
            }
            else
            {
                state = false;
            }
            CheckValid();
        }

        private void TxtBox_zipcode_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_zipcode.MaskFull)
            {
                zipcode = true;
            }
            else
            {
                zipcode = false;
            }
            CheckValid();
        }
        private void TxtBox_date_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_date.MaskFull)
            {
                date = true;
            }
            else
            {
                date = false;
            }
            CheckValid();
        }

        private void DropDown_proof_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDown_proof.Text.Length > 0)
            {
                proof = true;
            }
            else
            {
                proof = false;
            }
            CheckValid();
        }

        // appends user entered data to file
        private void Btn_add_Click(object sender, EventArgs e)
        {

            // adds items to file
            using (TextWriter tw = new StreamWriter(fileName, true))
            {
                tw.WriteLine(txtBox_firstName.Text + "\t"
                    + txtBox_middleInitial.Text + "\t"
                    + txtBox_lastName.Text + "\t"
                    + txtBox_address1.Text + "\t"
                    + txtBox_address2.Text + "\t"
                    + txtBox_city.Text + "\t"
                    + txtBox_state.Text + "\t"
                    + txtBox_zipcode.Text + "\t"
                    + dropDown_gender.Text + "\t"
                    + txtBox_number.Text + "\t"
                    + txtBox_email.Text + "\t"
                    + dropDown_proof.Text + "\t"
                    + txtBox_date.Text + "\t");
                tw.Close();
            }

            this.LoadFile();
            ClearFields();
        }

        // enables button only if all user entered data is valid
        private void CheckValid()
        {
            if (firstName && lastName && gender && number && email && address &&
                city && state && zipcode && date && proof)
            {
                btn_add.Enabled = true;
            }
            else
            {
                btn_add.Enabled = false;
            }
        }
        // clears all user entered data from screen
        private void ClearFields()
        {
            txtBox_firstName.Clear();
            txtBox_middleInitial.Clear();
            txtBox_lastName.Clear();
            dropDown_gender.SelectedIndex = -1;
            txtBox_number.Clear();
            txtBox_email.Clear();
            txtBox_address1.Clear();
            txtBox_address2.Clear();
            txtBox_city.Clear();
            txtBox_state.Clear();
            txtBox_zipcode.Clear();
            dropDown_proof.SelectedIndex = -1;
            txtBox_date.Text = string.Format("{0:MM/dd/yyyy}", DateTime.Now);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadFile();

            // sets date to current date in form
            txtBox_date.Text = string.Format("{0:MM/dd/yyyy}", DateTime.Now);
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            string[] filelines = File.ReadAllLines(fileName);
            string[] newfilelines = new string[filelines.Length - 1];

            ListViewItem li = listView1.SelectedItems[0];
            string search = li.SubItems[0].Text + "\t" + li.SubItems[1].Text + "\t" + li.SubItems[2].Text;
            Console.WriteLine("Item Selected to delete!  " + search);

            bool found = false;
            int index;
            for (index = 0; index < filelines.Length && !found; index++)
            {
                if (filelines[index].Contains(search))
                {
                    found = true;
                }
                if (index != filelines.Length - 1)
                {
                    newfilelines[index] = filelines[index];
                }
            }

            if (!found)
            {
                return;
            }

            int j;
            for (j = index; j < filelines.Length; j++)
            {
                newfilelines[j - 1] = filelines[j];
            }

            File.WriteAllLines(fileName, newfilelines);
            this.LoadFile();

            /*
                1. open file
                2. find that name and number combo
                3. delete line
                4. close file
                5. reload data, unselect tableview
            */
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                btn_delete.Enabled = true;
                btn_edit.Enabled = true;
            } else
            {
                btn_delete.Enabled = false;
                btn_edit.Enabled = false;
            }
        }
    }
}