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
    public partial class AddStudent : Form
    {
        String conURL = (@"Data Source = DESKTOP-L9A1H4O\SQLEXPRESS; Initial Catalog = ProjectA; User ID = sa; Password = iqra5545; MultipleActiveResultSets = True");

        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry;
            String gen = BoxGender.Text;
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            string gender = string.Format("SELECT id FROM Lookup Where Category ='GENDER' AND Value= '" + gen + "'");
            SqlCommand cmd = new SqlCommand(gender, con);
            int gende = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            qry = "INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) " +
                    "VALUES ('" + BoxFirstName.Text + "','" + BoxLastName.Text + "', '" + BoxContactNo.Text + "', '" + BoxEmail.Text + "', '" + dateTimePicker1.Value + "', '" + gende + "')";
            SqlCommand cmd3 = new SqlCommand(qry, con);
            int i = cmd3.ExecuteNonQuery();

            string PersonId = string.Format("Select id From Person Where Email = '{0}'", BoxEmail.Text);
            SqlCommand cmd2 = new SqlCommand(PersonId, con);
            int id = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            string query = "INSERT INTO Student Values ('" + id + "', '" + BoxRegNo.Text + "')";
            SqlCommand cmd4 = new SqlCommand(query, con);
            int k = cmd4.ExecuteNonQuery();
            if (k > 0 && i > 0)
            {
                MessageBox.Show("Inserted sucessfully");
            }
            else
            {
                MessageBox.Show("Inserted Not Inserted");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
