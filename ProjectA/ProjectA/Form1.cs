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
    public partial class Form1 : Form
    {
        String conURL = (@"Data Source = DESKTOP-L9A1H4O\SQLEXPRESS; Initial Catalog = ProjectA; User ID = sa; Password = iqra5545; MultipleActiveResultSets = True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudent f3 = new ManageStudent();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent f2 = new AddStudent();
            f2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAdvisor Ad = new AddAdvisor();
            Ad.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProject ap = new AddProject();
            ap.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEvaluation ae = new AddEvaluation();
            ae.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAdvisor md = new ManageAdvisor();
            md.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageProject mp = new ManageProject();
            mp.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEvaluation me = new ManageEvaluation();
            me.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string qry;
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            DateTime Create = DateTime.Today;
            qry = "INSERT INTO [Group](Created_On) Values ('" + Create + "')";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupStudent g = new GroupStudent();
            g.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectAdvisor g = new ProjectAdvisor();
            g.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            GroupEvaluation gh = new GroupEvaluation();
            gh.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports f = new Reports();
            f.ShowDialog();
        }
    }
}
