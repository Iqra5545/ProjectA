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
    public partial class ManageStudent : Form
    {
        String conURL = (@"Data Source = DESKTOP-L9A1H4O\SQLEXPRESS; Initial Catalog = ProjectA; User ID = sa; Password = iqra5545; MultipleActiveResultSets = True");

        public ManageStudent()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            SqlCommand delcmd = new SqlCommand();
            int d = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[d].Cells["Delete"].Selected)
            {
                conn.Open();
                int g = Convert.ToInt32(dataGridView1.Rows[d].Cells["Id"].Value);
                delcmd.CommandText = "DELETE FROM Student WHERE id = '" + g + "' ";

                delcmd.Connection = conn;
                delcmd.ExecuteNonQuery();

                using (SqlCommand dcl = new SqlCommand())
                {
                    dcl.CommandText = "DELETE FROM Person WHERE id=" + dataGridView1.Rows[d].Cells["id"].Value.ToString() + "";
                    dcl.Connection = conn;
                    dcl.ExecuteNonQuery();
                }
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                MessageBox.Show("Row Deleted");
                conn.Close();
            }
            if (dataGridView1.Rows[d].Cells["Edit"].Selected)
            {
                conn.Open();
                int g = Convert.ToInt32(dataGridView1.Rows[d].Cells["Id"].Value);
                panel2.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            int d = dataGridView1.CurrentCell.RowIndex;
            conn.Open();
            int g = Convert.ToInt32(dataGridView1.Rows[d].Cells["Id"].Value);
            string qry;
            String gen = BoxGender.Text;
            string gender = string.Format("SELECT id FROM Lookup Where Category ='GENDER' AND Value= '" + gen + "'");
            SqlCommand cmd = new SqlCommand(gender, conn);
            int gende = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            qry = "UPDATE Person SET FirstName = '" + BoxFirstName.Text + "', LastName = '" + BoxLastName.Text + "', Contact = '" + BoxContactNo.Text + "', Email = '" + BoxEmail.Text + "', DateOfBirth = '" + dateTimePicker1.Value + "', Gender = '" + gende + "' WHERE id = '" + g + "' ";
            SqlCommand cmd3 = new SqlCommand(qry, conn);
            int i = cmd3.ExecuteNonQuery();

            string PersonId = string.Format("Select id From Person Where Email = '{0}'", BoxEmail.Text);
            SqlCommand cmd2 = new SqlCommand(PersonId, conn);
            int id = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            string query = "UPDATE Student SET Id = '" + id + "', RegistrationNo = '" + BoxRegNo.Text + "' WHERE Student.id = '" + g + "' ";
            SqlCommand cmd4 = new SqlCommand(query, conn);
            int k = cmd4.ExecuteNonQuery();
            if (k > 0 && i > 0)
            {
                MessageBox.Show("Update sucessfully");
            }
            else
            {
                MessageBox.Show("Inserted Not Inserted");
            }
            panel2.Hide();
            conn.Close();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conURL))
            {
                conn.Open();
                SqlDataAdapter db = new SqlDataAdapter("SELECT person.id, FirstName, RegistrationNo, Email FROM (Person INNER JOIN Student ON Person.Id = Student.Id)", conn);
                DataTable dt = new DataTable();
                db.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Edit"].DisplayIndex = 5;
                dataGridView1.Columns["Delete"].DisplayIndex = 4;


                conn.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
