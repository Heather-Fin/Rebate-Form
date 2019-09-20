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
        }

        private void TxtBox_firstName_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_firstName.TextLength > 0)
            {
                firstName = true;
            } else
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
            } else
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
            if(txtBox_city.TextLength > 0)
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
            if(txtBox_state.TextLength > 1)
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

        private void Btn_add_Click(object sender, EventArgs e)
        {
            string fname = txtBox_firstName.Text;
            string lname = txtBox_lastName.Text;
            string number = txtBox_number.Text;
            ListViewItem li = listView1.Items.Add(fname);
            li.SubItems.Add(lname);
            li.SubItems.Add(number);
            ClearFields();
        }

        private void CheckValid()
        {
            if (firstName && lastName && gender && number && email && address &&
                city && state && zipcode && date && proof)
            {
                btn_add.Enabled = true;
            } else
            {
                btn_add.Enabled = false;
            }
        }
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
            // sets date to current date in form
            txtBox_date.Text = string.Format("{0:MM/dd/yyyy}", DateTime.Now);

            // file path for data text file
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\CS6326Asg2.txt";

            // if file does not exist, creates it
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path))
                {
                    //tw.WriteLine("The very first line!");
                }

            }
            // if file does exist, adds to it
            else if (File.Exists(path))
            {
                using (TextWriter tw = new StreamWriter(path))
                {
                    //tw.WriteLine("The next line!");
                }
            }
        }
    }
}