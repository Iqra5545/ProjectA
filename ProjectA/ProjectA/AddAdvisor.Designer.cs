namespace ProjectA
{
    partial class AddAdvisor
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BoxContactNo = new System.Windows.Forms.TextBox();
            this.BoxEmail = new System.Windows.Forms.TextBox();
            this.BoxLastName = new System.Windows.Forms.TextBox();
            this.BoxFirstName = new System.Windows.Forms.TextBox();
            this.BoxGender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ContactNo = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoxSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxDesig = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(762, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 29);
            this.button2.TabIndex = 58;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(402, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 32);
            this.button1.TabIndex = 57;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoxContactNo
            // 
            this.BoxContactNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxContactNo.Location = new System.Drawing.Point(402, 375);
            this.BoxContactNo.Name = "BoxContactNo";
            this.BoxContactNo.Size = new System.Drawing.Size(302, 22);
            this.BoxContactNo.TabIndex = 56;
            this.BoxContactNo.Text = "e.g. 99999999999";
            // 
            // BoxEmail
            // 
            this.BoxEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEmail.Location = new System.Drawing.Point(402, 337);
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(302, 22);
            this.BoxEmail.TabIndex = 55;
            this.BoxEmail.Text = "someone@example.com";
            // 
            // BoxLastName
            // 
            this.BoxLastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLastName.Location = new System.Drawing.Point(401, 143);
            this.BoxLastName.Name = "BoxLastName";
            this.BoxLastName.Size = new System.Drawing.Size(302, 22);
            this.BoxLastName.TabIndex = 53;
            this.BoxLastName.Text = "xyz";
            // 
            // BoxFirstName
            // 
            this.BoxFirstName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxFirstName.Location = new System.Drawing.Point(401, 101);
            this.BoxFirstName.Name = "BoxFirstName";
            this.BoxFirstName.Size = new System.Drawing.Size(302, 22);
            this.BoxFirstName.TabIndex = 42;
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
            this.BoxGender.Location = new System.Drawing.Point(402, 259);
            this.BoxGender.Name = "BoxGender";
            this.BoxGender.Size = new System.Drawing.Size(302, 24);
            this.BoxGender.TabIndex = 52;
            this.BoxGender.Text = "Select Gender:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(402, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(302, 21);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // ContactNo
            // 
            this.ContactNo.AutoSize = true;
            this.ContactNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNo.ForeColor = System.Drawing.Color.Teal;
            this.ContactNo.Location = new System.Drawing.Point(398, 359);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(61, 17);
            this.ContactNo.TabIndex = 50;
            this.ContactNo.Text = "Contact:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Teal;
            this.Email.Location = new System.Drawing.Point(398, 321);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 49;
            this.Email.Text = "Email:";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.Color.Teal;
            this.DOB.Location = new System.Drawing.Point(398, 283);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(87, 17);
            this.DOB.TabIndex = 48;
            this.DOB.Text = "Date Of Birth:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.Color.Teal;
            this.Gender.Location = new System.Drawing.Point(398, 244);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(56, 17);
            this.Gender.TabIndex = 47;
            this.Gender.Text = "Gender:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.Teal;
            this.LastName.Location = new System.Drawing.Point(397, 128);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(74, 17);
            this.LastName.TabIndex = 45;
            this.LastName.Text = "Last Name:";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.Teal;
            this.FirstName.Location = new System.Drawing.Point(397, 86);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(73, 17);
            this.FirstName.TabIndex = 44;
            this.FirstName.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(448, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Enter the required information.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Advisor";
            // 
            // RegNo
            // 
            this.RegNo.AutoSize = true;
            this.RegNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNo.ForeColor = System.Drawing.Color.Teal;
            this.RegNo.Location = new System.Drawing.Point(397, 166);
            this.RegNo.Name = "RegNo";
            this.RegNo.Size = new System.Drawing.Size(79, 17);
            this.RegNo.TabIndex = 46;
            this.RegNo.Text = "Designation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 486);
            this.panel1.TabIndex = 41;
            // 
            // BoxSalary
            // 
            this.BoxSalary.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSalary.Location = new System.Drawing.Point(401, 223);
            this.BoxSalary.Name = "BoxSalary";
            this.BoxSalary.Size = new System.Drawing.Size(302, 22);
            this.BoxSalary.TabIndex = 60;
            this.BoxSalary.Text = "e.g. 50000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(397, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Salary:";
            // 
            // BoxDesig
            // 
            this.BoxDesig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BoxDesig.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDesig.FormattingEnabled = true;
            this.BoxDesig.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assisstant Professor",
            "Lecturer",
            "Industry Professional"});
            this.BoxDesig.Location = new System.Drawing.Point(400, 183);
            this.BoxDesig.Name = "BoxDesig";
            this.BoxDesig.Size = new System.Drawing.Size(302, 24);
            this.BoxDesig.TabIndex = 61;
            this.BoxDesig.Text = "Select Designation:";
            // 
            // AddAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.BoxDesig);
            this.Controls.Add(this.BoxSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxContactNo);
            this.Controls.Add(this.BoxEmail);
            this.Controls.Add(this.BoxLastName);
            this.Controls.Add(this.BoxFirstName);
            this.Controls.Add(this.BoxGender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ContactNo);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegNo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddAdvisor";
            this.Text = "AddAdvisor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BoxContactNo;
        private System.Windows.Forms.TextBox BoxEmail;
        private System.Windows.Forms.TextBox BoxLastName;
        private System.Windows.Forms.TextBox BoxFirstName;
        private System.Windows.Forms.ComboBox BoxGender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ContactNo;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RegNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoxSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BoxDesig;
    }
}