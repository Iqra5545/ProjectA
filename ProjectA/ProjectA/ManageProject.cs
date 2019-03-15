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
    public partial class ManageProject : Form
    {
        String conURL = (@"Data Source = DESKTOP-L9A1H4O\SQLEXPRESS; Initial Catalog = ProjectA; User ID = sa; Password = iqra5545; MultipleActiveResultSets = True");
        public ManageProject()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to update?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                //Do something
                SqlConnection conn = new SqlConnection(conURL);
                int d = dataGridView1.CurrentCell.RowIndex;
                conn.Open();
                string qry = "UPDATE Project SET Description = '" + BoxDesc.Text + "', Title = '" + BoxTitle.Text + "'";
                SqlCommand cmd3 = new SqlCommand(qry, conn);
                int i = cmd3.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Update sucessfully");
                }
                else
                {
                    MessageBox.Show("Inserted Not Inserted");
                }
                PanelUpdateProject.Hide();
                this.Refresh();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Action Canceled");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            SqlCommand delcmd = new SqlCommand();
            int d = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[d].Cells["Delete"].Selected)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    //Do something
                    conn.Open();
                    int g = Convert.ToInt32(dataGridView1.Rows[d].Cells["Id"].Value);
                    delcmd.CommandText = "DELETE FROM Project WHERE id = '" + g + "' ";

                    delcmd.Connection = conn;
                    delcmd.ExecuteNonQuery();


                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                    MessageBox.Show("Data Deleted");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Action Canceled");
                }
                
            }
            if (dataGridView1.Rows[d].Cells["Edit"].Selected)
            {
                conn.Open();
                int g = Convert.ToInt32(dataGridView1.Rows[d].Cells["Id"].Value);
                PanelUpdateProject.Show();

            }
        }

        private void ManageProject_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conURL))
            {
                conn.Open();
                SqlDataAdapter db = new SqlDataAdapter("SELECT id, Description, Title FROM Project", conn);
                DataTable dt = new DataTable();
                db.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Edit"].DisplayIndex = 4;
                dataGridView1.Columns["Delete"].DisplayIndex = 3;


                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProject p = new AddProject();
            p.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
