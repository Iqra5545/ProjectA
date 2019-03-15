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
    public partial class ManageAdvisor : Form
    {
        String conURL = (@"Data Source = DESKTOP-L9A1H4O\SQLEXPRESS; Initial Catalog = ProjectA; User ID = sa; Password = iqra5545; MultipleActiveResultSets = True");
        public ManageAdvisor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(conURL);
            SqlCommand delcmd = new SqlCommand();
            int d = dataGridViewAD.CurrentCell.RowIndex;
            if (dataGridViewAD.Rows[d].Cells["Delete"].Selected)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    //Do something
                    conn.Open();
                    int g = Convert.ToInt32(dataGridViewAD.Rows[d].Cells["Id"].Value);
                    delcmd.CommandText = "DELETE FROM Advisor WHERE id = '" + g + "' ";

                    delcmd.Connection = conn;
                    delcmd.ExecuteNonQuery();

                    using (SqlCommand dcl = new SqlCommand())
                    {
                        dcl.CommandText = "DELETE FROM Person WHERE id=" + dataGridViewAD.Rows[d].Cells["id"].Value.ToString() + "";
                        dcl.Connection = conn;
                        dcl.ExecuteNonQuery();
                    }
                    dataGridViewAD.Rows.RemoveAt(dataGridViewAD.CurrentCell.RowIndex);
                    MessageBox.Show("Row Deleted");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Action canceled");
                }
                
            }
            if (dataGridViewAD.Rows[d].Cells["Edit"].Selected)
            {
                conn.Open();
                int g = Convert.ToInt32(dataGridViewAD.Rows[d].Cells["Id"].Value);
                PanelUpdateAdvisor.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to update?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                //Do something
                SqlConnection conn = new SqlConnection(conURL);
                int d = dataGridViewAD.CurrentCell.RowIndex;
                conn.Open();
                int g = Convert.ToInt32(dataGridViewAD.Rows[d].Cells["Id"].Value);
                string qry;
                String gen = BoxGender.Text;
                String des = BoxDesig.Text;
                // gender
                string gender = string.Format("SELECT id FROM Lookup Where Category ='GENDER' AND Value= '" + gen + "'");
                SqlCommand cmd = new SqlCommand(gender, conn);
                int gende = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                // Designation
                string desig = string.Format("SELECT id FROM Lookup Where Category ='DESIGNATION' AND Value= '" + des + "'");
                SqlCommand cmd5 = new SqlCommand(desig, conn);
                int desi = Convert.ToInt32(cmd5.ExecuteScalar().ToString());
                // insert 
                qry = "UPDATE Person SET FirstName = '" + BoxFirstName.Text + "', LastName = '" + BoxLastName.Text + "', Contact = '" + BoxContactNo.Text + "', Email = '" + BoxEmail.Text + "', DateOfBirth = '" + dateTimePicker1.Value + "', Gender = '" + gende + "' WHERE id = '" + g + "' ";
                SqlCommand cmd3 = new SqlCommand(qry, conn);
                int i = cmd3.ExecuteNonQuery();

                string PersonId = string.Format("Select id From Person Where Email = '{0}'", BoxEmail.Text);
                SqlCommand cmd2 = new SqlCommand(PersonId, conn);
                int id = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                string query = "UPDATE Advisor SET Id = '" + id + "', Designation = '" + BoxDesig.Text + "', Salary = '" + BoxSalary.Text + "' WHERE Student.id = '" + g + "' ";
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
                PanelUpdateAdvisor.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Action canceled");
            }
            
        }

        private void ManageAdvisor_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conURL))
            {
                conn.Open();
                SqlDataAdapter db = new SqlDataAdapter("SELECT person.id, FirstName, Designation, Email FROM (Person INNER JOIN Advisor ON Person.Id = Advisor.Id)", conn);
                DataTable dt = new DataTable();
                db.Fill(dt);
                dataGridViewAD.DataSource = dt;
                dataGridViewAD.Columns["Edit"].DisplayIndex = 5;
                dataGridViewAD.Columns["Delete"].DisplayIndex = 4;


                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAdvisor ad = new AddAdvisor();
            ad.ShowDialog();
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
    }
}
