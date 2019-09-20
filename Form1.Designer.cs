namespace Heather_Finnegan_Assignment2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_middleInitial = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.txtBox_firstName = new System.Windows.Forms.TextBox();
            this.txtBox_middleInitial = new System.Windows.Forms.TextBox();
            this.txtBox_lastName = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.dropDown_gender = new System.Windows.Forms.ComboBox();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtBox_number = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txtBox_address1 = new System.Windows.Forms.TextBox();
            this.txtBox_address2 = new System.Windows.Forms.TextBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.lbl_zipcode = new System.Windows.Forms.Label();
            this.lbl_proof = new System.Windows.Forms.Label();
            this.dropDown_proof = new System.Windows.Forms.ComboBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txtBox_date = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_city = new System.Windows.Forms.TextBox();
            this.txtBox_state = new System.Windows.Forms.TextBox();
            this.txtBox_zipcode = new System.Windows.Forms.MaskedTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(12, 25);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_firstName.TabIndex = 0;
            this.lbl_firstName.Text = "First Name";
            // 
            // lbl_middleInitial
            // 
            this.lbl_middleInitial.AutoSize = true;
            this.lbl_middleInitial.Location = new System.Drawing.Point(12, 57);
            this.lbl_middleInitial.Name = "lbl_middleInitial";
            this.lbl_middleInitial.Size = new System.Drawing.Size(65, 13);
            this.lbl_middleInitial.TabIndex = 1;
            this.lbl_middleInitial.Text = "Middle Initial";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(12, 84);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_lastName.TabIndex = 2;
            this.lbl_lastName.Text = "Last Name";
            // 
            // txtBox_firstName
            // 
            this.txtBox_firstName.Location = new System.Drawing.Point(92, 22);
            this.txtBox_firstName.MaxLength = 20;
            this.txtBox_firstName.Name = "txtBox_firstName";
            this.txtBox_firstName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_firstName.TabIndex = 3;
            this.txtBox_firstName.TextChanged += new System.EventHandler(this.TxtBox_firstName_TextChanged);
            // 
            // txtBox_middleInitial
            // 
            this.txtBox_middleInitial.Location = new System.Drawing.Point(92, 54);
            this.txtBox_middleInitial.MaxLength = 1;
            this.txtBox_middleInitial.Name = "txtBox_middleInitial";
            this.txtBox_middleInitial.Size = new System.Drawing.Size(23, 20);
            this.txtBox_middleInitial.TabIndex = 4;
            // 
            // txtBox_lastName
            // 
            this.txtBox_lastName.Location = new System.Drawing.Point(92, 84);
            this.txtBox_lastName.MaxLength = 20;
            this.txtBox_lastName.Name = "txtBox_lastName";
            this.txtBox_lastName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_lastName.TabIndex = 5;
            this.txtBox_lastName.TextChanged += new System.EventHandler(this.TxtBox_lastName_TextChanged);
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(12, 114);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 6;
            this.lbl_gender.Text = "Gender";
            // 
            // dropDown_gender
            // 
            this.dropDown_gender.FormattingEnabled = true;
            this.dropDown_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.dropDown_gender.Location = new System.Drawing.Point(92, 114);
            this.dropDown_gender.Name = "dropDown_gender";
            this.dropDown_gender.Size = new System.Drawing.Size(65, 21);
            this.dropDown_gender.TabIndex = 7;
            this.dropDown_gender.SelectedIndexChanged += new System.EventHandler(this.DropDown_gender_SelectedIndexChanged);
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(12, 175);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(78, 13);
            this.lbl_number.TabIndex = 8;
            this.lbl_number.Text = "Phone Number";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(12, 205);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Email";
            // 
            // txtBox_number
            // 
            this.txtBox_number.Location = new System.Drawing.Point(106, 175);
            this.txtBox_number.Mask = "(999) 000-0000";
            this.txtBox_number.Name = "txtBox_number";
            this.txtBox_number.Size = new System.Drawing.Size(100, 20);
            this.txtBox_number.TabIndex = 10;
            this.txtBox_number.TextChanged += new System.EventHandler(this.TxtBox_number_TextChanged);
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(106, 205);
            this.txtBox_email.MaxLength = 60;
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(100, 20);
            this.txtBox_email.TabIndex = 11;
            this.txtBox_email.TextChanged += new System.EventHandler(this.TxtBox_email_TextChanged);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(12, 250);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(45, 13);
            this.lbl_address.TabIndex = 12;
            this.lbl_address.Text = "Address";
            // 
            // txtBox_address1
            // 
            this.txtBox_address1.Location = new System.Drawing.Point(15, 266);
            this.txtBox_address1.MaxLength = 35;
            this.txtBox_address1.Name = "txtBox_address1";
            this.txtBox_address1.Size = new System.Drawing.Size(243, 20);
            this.txtBox_address1.TabIndex = 13;
            this.txtBox_address1.TextChanged += new System.EventHandler(this.TxtBox_address1_TextChanged);
            // 
            // txtBox_address2
            // 
            this.txtBox_address2.Location = new System.Drawing.Point(15, 292);
            this.txtBox_address2.MaxLength = 35;
            this.txtBox_address2.Name = "txtBox_address2";
            this.txtBox_address2.Size = new System.Drawing.Size(243, 20);
            this.txtBox_address2.TabIndex = 14;
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(12, 332);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(24, 13);
            this.lbl_city.TabIndex = 15;
            this.lbl_city.Text = "City";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(159, 332);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(32, 13);
            this.lbl_state.TabIndex = 16;
            this.lbl_state.Text = "State";
            // 
            // lbl_zipcode
            // 
            this.lbl_zipcode.AutoSize = true;
            this.lbl_zipcode.Location = new System.Drawing.Point(256, 332);
            this.lbl_zipcode.Name = "lbl_zipcode";
            this.lbl_zipcode.Size = new System.Drawing.Size(46, 13);
            this.lbl_zipcode.TabIndex = 17;
            this.lbl_zipcode.Text = "Zipcode";
            // 
            // lbl_proof
            // 
            this.lbl_proof.AutoSize = true;
            this.lbl_proof.Location = new System.Drawing.Point(12, 369);
            this.lbl_proof.Name = "lbl_proof";
            this.lbl_proof.Size = new System.Drawing.Size(144, 13);
            this.lbl_proof.TabIndex = 18;
            this.lbl_proof.Text = "Proof of Purchase Attached?";
            // 
            // dropDown_proof
            // 
            this.dropDown_proof.FormattingEnabled = true;
            this.dropDown_proof.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.dropDown_proof.Location = new System.Drawing.Point(162, 366);
            this.dropDown_proof.Name = "dropDown_proof";
            this.dropDown_proof.Size = new System.Drawing.Size(57, 21);
            this.dropDown_proof.TabIndex = 19;
            this.dropDown_proof.SelectedIndexChanged += new System.EventHandler(this.DropDown_proof_SelectedIndexChanged);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(256, 369);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(79, 13);
            this.lbl_date.TabIndex = 20;
            this.lbl_date.Text = "Date Recieved";
            // 
            // txtBox_date
            // 
            this.txtBox_date.Location = new System.Drawing.Point(341, 366);
            this.txtBox_date.Mask = "00/00/0000";
            this.txtBox_date.Name = "txtBox_date";
            this.txtBox_date.Size = new System.Drawing.Size(64, 20);
            this.txtBox_date.TabIndex = 21;
            this.txtBox_date.ValidatingType = typeof(System.DateTime);
            this.txtBox_date.TextChanged += new System.EventHandler(this.TxtBox_date_TextChanged);
            // 
            // txtBox_city
            // 
            this.txtBox_city.Location = new System.Drawing.Point(42, 329);
            this.txtBox_city.MaxLength = 25;
            this.txtBox_city.Name = "txtBox_city";
            this.txtBox_city.Size = new System.Drawing.Size(100, 20);
            this.txtBox_city.TabIndex = 15;
            this.txtBox_city.TextChanged += new System.EventHandler(this.TxtBox_city_TextChanged);
            // 
            // txtBox_state
            // 
            this.txtBox_state.Location = new System.Drawing.Point(197, 329);
            this.txtBox_state.MaxLength = 2;
            this.txtBox_state.Name = "txtBox_state";
            this.txtBox_state.Size = new System.Drawing.Size(31, 20);
            this.txtBox_state.TabIndex = 16;
            this.txtBox_state.TextChanged += new System.EventHandler(this.TxtBox_state_TextChanged);
            // 
            // txtBox_zipcode
            // 
            this.txtBox_zipcode.Location = new System.Drawing.Point(308, 329);
            this.txtBox_zipcode.Mask = "00000-9999";
            this.txtBox_zipcode.Name = "txtBox_zipcode";
            this.txtBox_zipcode.Size = new System.Drawing.Size(64, 20);
            this.txtBox_zipcode.TabIndex = 17;
            this.txtBox_zipcode.TextChanged += new System.EventHandler(this.TxtBox_zipcode_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(15, 413);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFirstName,
            this.columnLastName,
            this.columnNumber});
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(400, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(296, 333);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "First Name";
            this.columnFirstName.Width = 91;
            // 
            // columnLastName
            // 
            this.columnLastName.Text = "Last Name";
            this.columnLastName.Width = 107;
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "Phone Number";
            this.columnNumber.Width = 94;
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(540, 351);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 24;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(621, 351);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(330, 413);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 26;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 448);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtBox_zipcode);
            this.Controls.Add(this.txtBox_state);
            this.Controls.Add(this.txtBox_city);
            this.Controls.Add(this.txtBox_date);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.dropDown_proof);
            this.Controls.Add(this.lbl_proof);
            this.Controls.Add(this.lbl_zipcode);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.txtBox_address2);
            this.Controls.Add(this.txtBox_address1);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txtBox_email);
            this.Controls.Add(this.txtBox_number);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.dropDown_gender);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.txtBox_lastName);
            this.Controls.Add(this.txtBox_middleInitial);
            this.Controls.Add(this.txtBox_firstName);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_middleInitial);
            this.Controls.Add(this.lbl_firstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Rebate Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_middleInitial;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox txtBox_firstName;
        private System.Windows.Forms.TextBox txtBox_middleInitial;
        private System.Windows.Forms.TextBox txtBox_lastName;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.ComboBox dropDown_gender;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.MaskedTextBox txtBox_number;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txtBox_address1;
        private System.Windows.Forms.TextBox txtBox_address2;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Label lbl_zipcode;
        private System.Windows.Forms.Label lbl_proof;
        private System.Windows.Forms.ComboBox dropDown_proof;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.MaskedTextBox txtBox_date;
        private System.Windows.Forms.TextBox txtBox_city;
        private System.Windows.Forms.TextBox txtBox_state;
        private System.Windows.Forms.MaskedTextBox txtBox_zipcode;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader columnLastName;
        private System.Windows.Forms.ColumnHeader columnNumber;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
    }
}

