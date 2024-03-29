﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

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

        // variables for form fill information
        bool beganFormFill = false;
        Stopwatch stopWatch = new Stopwatch();
        string elapsedTime;
        string submitTime = "";
        int backspaces = 0;

        public Form1()
        {
            InitializeComponent();

            // forces uppercase letters for state abbreviation and middle initial
            txtBox_middleInitial.CharacterCasing = CharacterCasing.Upper;
            txtBox_state.CharacterCasing = CharacterCasing.Upper;
        }

        // form level event to count the number of backspaces pressed
        void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                backspaces += 1;
            }
        }

        // loads the text file into the list view table. Creates a file if none exists
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

            // checks if this is the first character entered into the form
            if (!beganFormFill)
            {
                beganFormFill = true;
                stopWatch.Start();
            }

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

        private void txtBox_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtBox_middleInitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
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
        private void txtBox_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void DropDown_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDown_gender.SelectedIndex > -1)
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

        private void txtBox_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
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

        private void txtBox_state_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
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
            if (dropDown_proof.SelectedIndex > -1)
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

            if (listView1.SelectedItems.Count > 0)
            {
                // checks if the existing element is the currently selected element for editing
                ListViewItem li = listView1.SelectedItems[0];
                if (ElementExists() && !(li.SubItems[0].Text == txtBox_firstName.Text &&
                    li.SubItems[1].Text == txtBox_lastName.Text &&
                    li.SubItems[2].Text == txtBox_number.Text))
                {
                    MessageBox.Show("Oh no, that user already exists!");
                    return;
                }
                DeleteElement();
                AddElement();
            }
            else if (ElementExists())
            {
                MessageBox.Show("Oh no, that user already exists!");
                return;
            }
            else
            {
                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;

                // Format and display the TimeSpan value.
                elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                submitTime = DateTime.Now.ToString("h:mm:ss tt");
                AddElement();
            }
            
            this.LoadFile();
            ClearFields();
            txtBox_firstName.Focus();
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

        // checks if the user already exists
        private bool ElementExists()
        {
            string[] filelines = File.ReadAllLines(fileName);
            bool found = false;
            int index;
            for (index = 0; index < filelines.Length && !found; index++)
            {
                string[] element = filelines[index].Split('\t');
                if ((element[0] == txtBox_firstName.Text) &&
                    (element[2] == txtBox_lastName.Text) &&
                    (element[9] == txtBox_number.Text))
                {
                    elapsedTime = element[13];
                    submitTime = element[14];
                    backspaces = Int32.Parse(element[15]);
                    return true;
                }
            }
            return false;
        }

        // clears all user entered data from screen
        private void ClearFields()
        {
            backspaces = 0;
            listView1.SelectedItems.Clear();
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

        // adds item to file
        private void AddElement()
        {
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
                    + txtBox_date.Text + "\t"
                    + elapsedTime + "\t"
                    + submitTime + "\t"
                    + backspaces + "\t");
                tw.Close();
            }
        }

        // deletes selected list view element
        private void DeleteElement()
        {
            string[] filelines = File.ReadAllLines(fileName);
            string[] newfilelines = new string[filelines.Length - 1];

            ListViewItem li = listView1.SelectedItems[0];

            bool found = false;
            int index;
            for (index = 0; index < filelines.Length && !found; index++)
            {
                string[] element = filelines[index].Split('\t');
                if ((element[0] == li.SubItems[0].Text) &&
                    (element[2] == li.SubItems[1].Text) &&
                    (element[9] == li.SubItems[2].Text))
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadFile();

            // sets date to current date in form
            txtBox_date.Text = string.Format("{0:MM/dd/yyyy}", DateTime.Now);
        }

        // deletes a list view item from the file and table
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            DeleteElement();
            listView1.SelectedItems.Clear();
            ClearFields();
            this.LoadFile();
        }

        // enables list view edit and delete buttons if an item is selected
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                btn_add.Text = "Save";
                btn_delete.Enabled = true;
                string[] filelines = File.ReadAllLines(fileName);
                ListViewItem li = listView1.SelectedItems[0];
                bool found = false;
                int index;
                for (index = 0; index < filelines.Length && !found; index++)
                {
                    string[] element = filelines[index].Split('\t');
                    if ((element[0] == li.SubItems[0].Text) &&
                        (element[2] == li.SubItems[1].Text) &&
                        (element[9] == li.SubItems[2].Text))
                    {
                        found = true;
                        txtBox_firstName.Text = element[0];
                        txtBox_middleInitial.Text = element[1];
                        txtBox_lastName.Text = element[2];
                        txtBox_address1.Text = element[3];
                        txtBox_address2.Text = element[4];
                        txtBox_city.Text = element[5];
                        txtBox_state.Text = element[6];
                        txtBox_zipcode.Text = element[7];
                        dropDown_gender.SelectedItem = element[8];
                        txtBox_number.Text = element[9];
                        txtBox_email.Text = element[10];
                        dropDown_proof.SelectedItem = element[11];
                        txtBox_date.Text = element[12];
                    }
                }
            } else
            {
                ClearFields();
                btn_add.Text = "Add";
                btn_delete.Enabled = false;
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}