using System;
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
            string qry;
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            qry = "INSERT INTO Project(Designation, Title) " +
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
    }
}
