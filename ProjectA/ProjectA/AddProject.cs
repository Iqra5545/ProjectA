﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectA
{
    public partial class AddProject : Form
    {
        Valid v = new Valid();
        String conURL = (@"Data Source = DESKTOP-L9A1H4O\SQLEXPRESS; Initial Catalog = ProjectA; User ID = sa; Password = iqra5545; MultipleActiveResultSets = True");
        public AddProject()
        {
            InitializeComponent();
        }

        private void AddProject_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!v.IsDigitAndLetter(BoxDesc.Text))
            {
                MessageBox.Show("Enter Description Correctly");
            }
            if (!v.IsDigitAndLetter(BoxTitle.Text))
            {
                MessageBox.Show("Enter Description Correctly");
            }
            else
            {
                string qry;
                SqlConnection con = new SqlConnection(conURL);
                con.Open();
                qry = "INSERT INTO Project(Description, Title) " +
                        "VALUES ('" + BoxDesc.Text + "','" + BoxTitle.Text + "')";
                SqlCommand cmd3 = new SqlCommand(qry, con);
                int i = cmd3.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Inserted sucessfully");
                }
                else
                {
                    MessageBox.Show("Inserted Not Inserted");
                }
                con.Close();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void BoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_Click(object sender, EventArgs e)
        {

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
