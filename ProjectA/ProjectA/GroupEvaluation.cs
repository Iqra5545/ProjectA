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
    public partial class GroupEvaluation : Form
    {
        String conURL = (@"Data Source = DESKTOP-L9A1H4O\SQLEXPRESS; Initial Catalog = ProjectA; User ID = sa; Password = iqra5545; MultipleActiveResultSets = True");
        public GroupEvaluation()
        {
            InitializeComponent();
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conURL))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Id FROM[Group]",con);

                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                dt.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.
                BoxGroup.DataSource = dt;
                BoxGroup.DisplayMember = "Id";
                BoxGroup.ValueMember = "Id";
            }

            using (SqlConnection con = new SqlConnection(conURL))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Id FROM Evaluation", con);

                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                dt.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.
                BoxEval.DataSource = dt;
                BoxEval.DisplayMember = "Id";
                BoxEval.ValueMember = "Id";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();


            string nm = BoxM.Text;

            int id = Convert.ToInt32(nm);
            int ig = Convert.ToInt32(BoxGroup.Text);
            int ie = Convert.ToInt32(BoxEval.Text);


            string qry = "INSERT INTO GroupEvaluation(GroupId, EvaluationId,ObtainedMarks, EvaluationDate) " +
                "Values ( '" + ig + "', '" + ie + "', '" + id + "','" + DateTime.Today + "')";

            SqlCommand cmd = new SqlCommand(qry, conn);
            int i = cmd.ExecuteNonQuery();
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
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
