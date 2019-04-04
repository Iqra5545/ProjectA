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
    public partial class ProjectAdvisor : Form
    {
        String conURL = (@"Data Source = DESKTOP-L9A1H4O\SQLEXPRESS; Initial Catalog = ProjectA; User ID = sa; Password = iqra5545; MultipleActiveResultSets = True");
        public ProjectAdvisor()
        {
            InitializeComponent();
        }

        private void ShowAdvisors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ProjectAdvisor_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conURL))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Id FROM Project", con);
 
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    //Insert the Default Item to DataTable.
                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    dt.Rows.InsertAt(row, 0);

                    //Assign DataTable as DataSource.
                    BoxProjectId.DataSource = dt;
                    BoxProjectId.DisplayMember = "Id";
                    BoxProjectId.ValueMember = "Id";
            }

            using (SqlConnection con = new SqlConnection(conURL))
            {

                SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Value FROM Lookup WHERE Category = 'ADVISOR_ROLE'", con);

                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();

                    sda2.Fill(dt);
                    //Insert the Default Item to DataTable.
                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    dt.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.
                BoxAdvisorRole.DataSource = dt;
                BoxAdvisorRole.DisplayMember = "Value";
                BoxAdvisorRole.ValueMember = "Value";

            }

            using (SqlConnection conn = new SqlConnection(conURL))
            {
                conn.Open();
                SqlDataAdapter db = new SqlDataAdapter("SELECT Advisor.Id, Person.FirstName FROM Advisor Join Person ON Advisor.Id = Person.Id" +
                    " EXCEPT SELECT ProjectAdvisor.AdvisorId, Person.FirstName  FROM Person JOIN ProjectAdvisor ON ProjectAdvisor.AdvisorId = Person.Id", conn);

                DataTable dt = new DataTable();
                db.Fill(dt);
                ShowAdvisors.DataSource = dt;
                ShowAdvisors.Columns["Assign"].DisplayIndex = 2;

                conn.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void ShowAdvisors_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            

            string nm = BoxProjectId.Text;

            int id = Convert.ToInt32(nm);

            int d = ShowAdvisors.CurrentCell.RowIndex;

            if (ShowAdvisors.Rows[d].Cells["Assign"].Selected)
            {
                DialogResult result = MessageBox.Show("Do You Want to assign this project?", "Assign", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    String gg = BoxAdvisorRole.Text;
                    string gender = string.Format("SELECT id FROM Lookup Where Category ='ADVISOR_ROLE'AND Value = '" + gg + "'");
                    SqlCommand cmd = new SqlCommand(gender, conn);
                    int gende = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                    int g = Convert.ToInt32(ShowAdvisors.Rows[d].Cells["Id"].Value);
                    string qry = "INSERT INTO ProjectAdvisor(AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES ('" + g + "', '" + id + "',  '"+gende+"','" + DateTime.Today + "')";
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

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
