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
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBox_firstName_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = txtBox_firstName.TextLength > 0 &&
                txtBox_lastName.TextLength > 0;
        }

        private void TxtBox_lastName_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = txtBox_firstName.TextLength > 0 &&
                txtBox_lastName.TextLength > 0;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            string fname = txtBox_firstName.Text;
            string lname = txtBox_lastName.Text;
            ListViewItem li = listView1.Items.Add(fname);
            li.SubItems.Add(lname);
            clearFields();
        }
        private void clearFields()
        {
            txtBox_firstName.Clear();
            txtBox_lastName.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}