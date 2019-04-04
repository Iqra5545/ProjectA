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
            int d = dataGridViewSt.CurrentCell.RowIndex;
            
            if (dataGridViewSt.Rows[d].Cells["Delete"].Selected)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    //Do something
                    conn.Open();
                    int g = Convert.ToInt32(dataGridViewSt.Rows[d].Cells["Id"].Value);
                    delcmd.CommandText = "DELETE FROM Student WHERE id = '" + g + "' ";

                    delcmd.Connection = conn;
                    delcmd.ExecuteNonQuery();

                    using (SqlCommand dcl = new SqlCommand())
                    {
                        dcl.CommandText = "DELETE FROM Person WHERE id=" + dataGridViewSt.Rows[d].Cells["id"].Value.ToString() + "";
                        dcl.Connection = conn;
                        dcl.ExecuteNonQuery();
                    }
                    dataGridViewSt.Rows.RemoveAt(dataGridViewSt.CurrentCell.RowIndex);
                    MessageBox.Show("Row Deleted");
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Action Canceled");
                }
                
            }
            if (dataGridViewSt.Rows[d].Cells["Edit"].Selected)
            {
                conn.Open();
                int g = Convert.ToInt32(dataGridViewSt.Rows[d].Cells["Id"].Value);
                PanelUpdateStudent.Show();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Update?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                //Do something
                SqlConnection conn = new SqlConnection(conURL);
                int d = dataGridViewSt.CurrentCell.RowIndex;
                conn.Open();
                int g = Convert.ToInt32(dataGridViewSt.Rows[d].Cells["Id"].Value);
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
                PanelUpdateStudent.Hide();
                conn.Close();

            }
            else
            {
                MessageBox.Show("Action Canceled");
            }
            
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conURL))
            {
                conn.Open();
                SqlDataAdapter db = new SqlDataAdapter("SELECT person.id, FirstName, RegistrationNo, Email FROM (Person INNER JOIN Student ON Person.Id = Student.Id)", conn);
                DataTable dt = new DataTable();
                db.Fill(dt);
                dataGridViewSt.DataSource = dt;
                dataGridViewSt.Columns["Edit"].DisplayIndex = 5;
                dataGridViewSt.Columns["Delete"].DisplayIndex = 4;

                conn.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent s = new AddStudent();
            s.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
