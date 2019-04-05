namespace ProjectA
{
    partial class ManageAdvisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAdvisor));
            this.dataGridViewAD = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.PanelUpdateAdvisor = new System.Windows.Forms.Panel();
            this.BoxDesig = new System.Windows.Forms.ComboBox();
            this.BoxSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.RegNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAD)).BeginInit();
            this.PanelUpdateAdvisor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAD
            // 
            this.dataGridViewAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Edit});
            this.dataGridViewAD.Location = new System.Drawing.Point(99, 225);
            this.dataGridViewAD.Name = "dataGridViewAD";
            this.dataGridViewAD.Size = new System.Drawing.Size(596, 249);
            this.dataGridViewAD.TabIndex = 13;
            this.dataGridViewAD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(317, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data of Advisors";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 486);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(83, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Enter the required information.";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // PanelUpdateAdvisor
            // 
            this.PanelUpdateAdvisor.BackColor = System.Drawing.Color.White;
            this.PanelUpdateAdvisor.Controls.Add(this.BoxDesig);
            this.PanelUpdateAdvisor.Controls.Add(this.BoxSalary);
            this.PanelUpdateAdvisor.Controls.Add(this.label3);
            this.PanelUpdateAdvisor.Controls.Add(this.BoxContactNo);
            this.PanelUpdateAdvisor.Controls.Add(this.BoxEmail);
            this.PanelUpdateAdvisor.Controls.Add(this.BoxLastName);
            this.PanelUpdateAdvisor.Controls.Add(this.BoxFirstName);
            this.PanelUpdateAdvisor.Controls.Add(this.BoxGender);
            this.PanelUpdateAdvisor.Controls.Add(this.dateTimePicker1);
            this.PanelUpdateAdvisor.Controls.Add(this.ContactNo);
            this.PanelUpdateAdvisor.Controls.Add(this.Email);
            this.PanelUpdateAdvisor.Controls.Add(this.DOB);
            this.PanelUpdateAdvisor.Controls.Add(this.Gender);
            this.PanelUpdateAdvisor.Controls.Add(this.LastName);
            this.PanelUpdateAdvisor.Controls.Add(this.FirstName);
            this.PanelUpdateAdvisor.Controls.Add(this.RegNo);
            this.PanelUpdateAdvisor.Controls.Add(this.button3);
            this.PanelUpdateAdvisor.Controls.Add(this.groupBox1);
            this.PanelUpdateAdvisor.Location = new System.Drawing.Point(16, 12);
            this.PanelUpdateAdvisor.Name = "PanelUpdateAdvisor";
            this.PanelUpdateAdvisor.Size = new System.Drawing.Size(750, 462);
            this.PanelUpdateAdvisor.TabIndex = 14;
            this.PanelUpdateAdvisor.Visible = false;
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
            this.BoxDesig.Location = new System.Drawing.Point(260, 177);
            this.BoxDesig.Name = "BoxDesig";
            this.BoxDesig.Size = new System.Drawing.Size(302, 24);
            this.BoxDesig.TabIndex = 77;
            this.BoxDesig.Text = "Select Designation:";
            // 
            // BoxSalary
            // 
            this.BoxSalary.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSalary.Location = new System.Drawing.Point(261, 217);
            this.BoxSalary.Name = "BoxSalary";
            this.BoxSalary.Size = new System.Drawing.Size(302, 22);
            this.BoxSalary.TabIndex = 76;
            this.BoxSalary.Text = "e.g. 50000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(257, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Salary:";
            // 
            // BoxContactNo
            // 
            this.BoxContactNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxContactNo.Location = new System.Drawing.Point(262, 369);
            this.BoxContactNo.Name = "BoxContactNo";
            this.BoxContactNo.Size = new System.Drawing.Size(302, 22);
            this.BoxContactNo.TabIndex = 74;
            this.BoxContactNo.Text = "e.g. 99999999999";
            // 
            // BoxEmail
            // 
            this.BoxEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxEmail.Location = new System.Drawing.Point(262, 331);
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(302, 22);
            this.BoxEmail.TabIndex = 73;
            this.BoxEmail.Text = "someone@example.com";
            // 
            // BoxLastName
            // 
            this.BoxLastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLastName.Location = new System.Drawing.Point(261, 137);
            this.BoxLastName.Name = "BoxLastName";
            this.BoxLastName.Size = new System.Drawing.Size(302, 22);
            this.BoxLastName.TabIndex = 72;
            this.BoxLastName.Text = "xyz";
            // 
            // BoxFirstName
            // 
            this.BoxFirstName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxFirstName.Location = new System.Drawing.Point(261, 95);
            this.BoxFirstName.Name = "BoxFirstName";
            this.BoxFirstName.Size = new System.Drawing.Size(302, 22);
            this.BoxFirstName.TabIndex = 62;
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
            this.BoxGender.Location = new System.Drawing.Point(262, 253);
            this.BoxGender.Name = "BoxGender";
            this.BoxGender.Size = new System.Drawing.Size(302, 24);
            this.BoxGender.TabIndex = 71;
            this.BoxGender.Text = "Select Gender:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 292);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(302, 21);
            this.dateTimePicker1.TabIndex = 70;
            // 
            // ContactNo
            // 
            this.ContactNo.AutoSize = true;
            this.ContactNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNo.ForeColor = System.Drawing.Color.Teal;
            this.ContactNo.Location = new System.Drawing.Point(258, 353);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(61, 17);
            this.ContactNo.TabIndex = 69;
            this.ContactNo.Text = "Contact:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Teal;
            this.Email.Location = new System.Drawing.Point(258, 315);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 68;
            this.Email.Text = "Email:";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.Color.Teal;
            this.DOB.Location = new System.Drawing.Point(258, 277);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(87, 17);
            this.DOB.TabIndex = 67;
            this.DOB.Text = "Date Of Birth:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.Color.Teal;
            this.Gender.Location = new System.Drawing.Point(258, 238);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(56, 17);
            this.Gender.TabIndex = 66;
            this.Gender.Text = "Gender:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.Teal;
            this.LastName.Location = new System.Drawing.Point(257, 122);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(74, 17);
            this.LastName.TabIndex = 64;
            this.LastName.Text = "Last Name:";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.Teal;
            this.FirstName.Location = new System.Drawing.Point(257, 80);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(73, 17);
            this.FirstName.TabIndex = 63;
            this.FirstName.Text = "First Name:";
            // 
            // RegNo
            // 
            this.RegNo.AutoSize = true;
            this.RegNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNo.ForeColor = System.Drawing.Color.Teal;
            this.RegNo.Location = new System.Drawing.Point(257, 160);
            this.RegNo.Name = "RegNo";
            this.RegNo.Size = new System.Drawing.Size(79, 17);
            this.RegNo.TabIndex = 65;
            this.RegNo.Text = "Designation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(219, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 449);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Advisor";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Teal;
            this.button6.Location = new System.Drawing.Point(30, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 25);
            this.button6.TabIndex = 23;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(742, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 486);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(76, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 349);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Of Advisor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Back";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Add ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(588, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 32);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(25, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 32);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.PanelUpdateAdvisor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAdvisor";
            this.Text = "ManageAdvisor";
            this.Load += new System.EventHandler(this.ManageAdvisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAD)).EndInit();
            this.PanelUpdateAdvisor.ResumeLayout(false);
            this.PanelUpdateAdvisor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAD;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PanelUpdateAdvisor;
        private System.Windows.Forms.ComboBox BoxDesig;
        private System.Windows.Forms.TextBox BoxSalary;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Label RegNo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}