using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heather_Finnegan_Assignment2
{
    public partial class Form1 : Form
    {

        bool firstName = false;
        bool lastName = false;
        bool gender = false;
        bool number = false;
        bool email = false;

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
            if (firstName && lastName && gender && number && email)
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
            txtBox_lastName.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBox_date.Text = string.Format("{0:MM/dd/yyyy}", DateTime.Now);
        }
    }
}