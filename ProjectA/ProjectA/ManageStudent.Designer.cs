namespace ProjectA
{
    partial class ManageStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.BoxContactNo = new System.Windows.Forms.TextBox();
            this.BoxEmail = new System.Windows.Forms.TextBox();
            this.BoxRegNo = new System.Windows.Forms.TextBox();
            this.BoxLastName = new System.Windows.Forms.TextBox();
            this.BoxFirstName = new System.Windows.Forms.TextBox();
            this.BoxGender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ContactNo = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.RegNo = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data of all students";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Edit});
            this.dataGridView1.Location = new System.Drawing.Point(34, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(361, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back To Main Menue";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 85);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(48, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add More Student";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.BoxContactNo);
            this.panel2.Controls.Add(this.BoxEmail);
            this.panel2.Controls.Add(this.BoxRegNo);
            this.panel2.Controls.Add(this.BoxLastName);
            this.panel2.Controls.Add(this.BoxFirstName);
            this.panel2.Controls.Add(this.BoxGender);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.ContactNo);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.DOB);
            this.panel2.Controls.Add(this.Gender);
            this.panel2.Controls.Add(this.RegNo);
            this.panel2.Controls.Add(this.LastName);
            this.panel2.Controls.Add(this.FirstName);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 480);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(302, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Enter the required information.";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(260, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(302, 32);
            this.button3.TabIndex = 36;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BoxContactNo
            // 
            this.BoxContactNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxContactNo.Location = new System.Drawing.Point(260, 372);
            this.BoxContactNo.Name = "BoxContactNo";
            this.BoxContactNo.Size = new System.Drawing.Size(302, 22);
            this.BoxContactNo.TabIndex = 35;
            this.BoxContactNo.Text = "e.g. 99999999999";
            // 
            // BoxEmail
            // 
            this.BoxEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEmail.Location = new System.Drawing.Point(260, 330);
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(302, 22);
            this.BoxEmail.TabIndex = 34;
            this.BoxEmail.Text = "someone@example.com";
            // 
            // BoxRegNo
            // 
            this.BoxRegNo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxRegNo.Location = new System.Drawing.Point(260, 204);
            this.BoxRegNo.Name = "BoxRegNo";
            this.BoxRegNo.Size = new System.Drawing.Size(302, 21);
            this.BoxRegNo.TabIndex = 33;
            this.BoxRegNo.Text = "e.g. 2012-CE-089";
            // 
            // BoxLastName
            // 
            this.BoxLastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLastName.Location = new System.Drawing.Point(260, 161);
            this.BoxLastName.Name = "BoxLastName";
            this.BoxLastName.Size = new System.Drawing.Size(302, 22);
            this.BoxLastName.TabIndex = 32;
            this.BoxLastName.Text = "xyz";
            // 
            // BoxFirstName
            // 
            this.BoxFirstName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxFirstName.Location = new System.Drawing.Point(260, 119);
            this.BoxFirstName.Name = "BoxFirstName";
            this.BoxFirstName.Size = new System.Drawing.Size(302, 22);
            this.BoxFirstName.TabIndex = 22;
            this.BoxFirstName.Text = "abc";
            // 
            // BoxGender
            // 
            this.BoxGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BoxGender.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxGender.FormattingEnabled = true;
            this.BoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.BoxGender.Location = new System.Drawing.Point(260, 245);
            this.BoxGender.Name = "BoxGender";
            this.BoxGender.Size = new System.Drawing.Size(302, 24);
            this.BoxGender.TabIndex = 31;
            this.BoxGender.Text = "Select Gender:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 287);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(302, 21);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // ContactNo
            // 
            this.ContactNo.AutoSize = true;
            this.ContactNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNo.ForeColor = System.Drawing.Color.Teal;
            this.ContactNo.Location = new System.Drawing.Point(256, 356);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(61, 17);
            this.ContactNo.TabIndex = 29;
            this.ContactNo.Text = "Contact:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Teal;
            this.Email.Location = new System.Drawing.Point(256, 314);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 28;
            this.Email.Text = "Email:";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.Color.Teal;
            this.DOB.Location = new System.Drawing.Point(256, 272);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(87, 17);
            this.DOB.TabIndex = 27;
            this.DOB.Text = "Date Of Birth:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.Color.Teal;
            this.Gender.Location = new System.Drawing.Point(256, 230);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(56, 17);
            this.Gender.TabIndex = 26;
            this.Gender.Text = "Gender:";
            // 
            // RegNo
            // 
            this.RegNo.AutoSize = true;
            this.RegNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNo.ForeColor = System.Drawing.Color.Teal;
            this.RegNo.Location = new System.Drawing.Point(256, 188);
            this.RegNo.Name = "RegNo";
            this.RegNo.Size = new System.Drawing.Size(102, 17);
            this.RegNo.TabIndex = 25;
            this.RegNo.Text = "Registration No.";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.Teal;
            this.LastName.Location = new System.Drawing.Point(256, 146);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(74, 17);
            this.LastName.TabIndex = 24;
            this.LastName.Text = "Last Name:";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.Teal;
            this.FirstName.Location = new System.Drawing.Point(256, 104);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(73, 17);
            this.FirstName.TabIndex = 23;
            this.FirstName.Text = "First Name:";
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageStudent";
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox BoxContactNo;
        private System.Windows.Forms.TextBox BoxEmail;
        private System.Windows.Forms.TextBox BoxRegNo;
        private System.Windows.Forms.TextBox BoxLastName;
        private System.Windows.Forms.TextBox BoxFirstName;
        private System.Windows.Forms.ComboBox BoxGender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ContactNo;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label RegNo;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
    }
}