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
    public partial class GroupStudent : Form
    {
        String conURL = (@"Data Source = DESKTOP-L9A1H4O\SQLEXPRESS; Initial Catalog = ProjectA; User ID = sa; Password = iqra5545; MultipleActiveResultSets = True");
        public GroupStudent()
        {
            InitializeComponent();
        }

        private void GroupStudent_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conURL))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT Id FROM [Group]", con))
                {
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    //Insert the Default Item to DataTable.
                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    dt.Rows.InsertAt(row, 0);

                    //Assign DataTable as DataSource.
                    BoxGID.DataSource = dt;
                    BoxGID.DisplayMember = "Id";
                    BoxGID.ValueMember = "Id";
                }
            }

            using (SqlConnection conn = new SqlConnection(conURL))
            {
                conn.Open();
                SqlDataAdapter db = new SqlDataAdapter("SELECT Id, RegistrationNo FROM Student", conn);
                DataTable dt = new DataTable();
                db.Fill(dt);
                ShowStudents.DataSource = dt;
                ShowStudents.Columns["Add"].DisplayIndex = 2;
                
                conn.Close();

            }

            using (SqlConnection conn = new SqlConnection(conURL))
            {
                conn.Open();
                SqlDataAdapter db = new SqlDataAdapter("SELECT Id, Title FROM Project", conn);
                DataTable dt = new DataTable();
                db.Fill(dt);
                ShowProjects.DataSource = dt;
                ShowProjects.Columns["Assign"].DisplayIndex = 2;

                conn.Close();

            }

            using (SqlConnection conn = new SqlConnection(conURL))
            {
                conn.Open();
                SqlDataAdapter db = new SqlDataAdapter("SELECT Id, Name FROM Evaluation", conn);
                DataTable dt = new DataTable();
                db.Fill(dt);
                ShowProjects.DataSource = dt;
                ShowProjects.Columns["Set"].DisplayIndex = 2;

                conn.Close();

            }

            using (SqlConnection conn = new SqlConnection(conURL))
            {
                conn.Open();
                SqlDataAdapter db = new SqlDataAdapter("SELECT Id, Designation FROM Advisor", conn);
                DataTable dt = new DataTable();
                db.Fill(dt);
                ShowProjects.DataSource = dt;
                ShowProjects.Columns["Allocate"].DisplayIndex = 2;

                conn.Close();

            }
        }

        private void ShowStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            int Gid = Convert.ToInt32(BoxGID.Text);

            int d = ShowStudents.CurrentCell.RowIndex;
            if (ShowStudents.Rows[d].Cells["Add"].Selected)
            {
                DialogResult result = MessageBox.Show("Do You Want to add this student?", "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    string status = "Active";
                    string sta = string.Format("SELECT Lookup.id FROM Lookup Where Category ='STATUS' AND Value= '" + status + "'");
                    SqlCommand cmd = new SqlCommand(sta, conn);
                    int st = Convert.ToInt32(cmd.ExecuteScalar().ToString());


                    int g = Convert.ToInt32(ShowStudents.Rows[d].Cells["Id"].Value);
                    string qry = "INSERT INTO GroupStudent(GroupId, StudentId, Status, AssignmentDate) Values ( '" + Gid + "', '" + g + "', '" + st + "', '" + DateTime.Today + "')";
                    SqlCommand cmd4 = new SqlCommand(qry, conn);
                    int i = cmd4.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Added sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Not Inserted");
                    }

                }
                else
                {
                    MessageBox.Show("Action Canceled");
                }
            }
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ShowProjects_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            int Gid = Convert.ToInt32(BoxGID.Text);

            int d = ShowProjects.CurrentCell.RowIndex;
            if (ShowProjects.Rows[d].Cells["Assign"].Selected)
            {
                DialogResult result = MessageBox.Show("Do You Want to assign this project?", "Assign", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {

                    int g = Convert.ToInt32(ShowProjects.Rows[d].Cells["Id"].Value);

                    string qry = "INSERT INTO GroupProject(ProjectId, GroupId, AssignmentDate) Values ( '" + g + "', '" + Gid + "','" + DateTime.Today + "')";
                    SqlCommand cmd4 = new SqlCommand(qry, conn);
                    int i = cmd4.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Added sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Can not assigned,please enter the correct information.");
                    }
                    this.Hide();
                    Form1 f = new Form1();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Action Canceled");
                }
            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowAdvisors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ShowAdvisors_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
