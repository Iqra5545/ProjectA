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
    public partial class AddEvaluation : Form
    {
        String conURL = (@"Data Source = DESKTOP-L9A1H4O\SQLEXPRESS; Initial Catalog = ProjectA; User ID = sa; Password = iqra5545; MultipleActiveResultSets = True");
        public AddEvaluation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry;
            SqlConnection con = new SqlConnection(conURL);
            con.Open();
            qry = "INSERT INTO Evaluation(Name, TotalMarks, TotalWeightage) " +
                    "VALUES ('" + BoxName.Text + "','" + BoxMarks.Text + "', '"+BoxWeightage+"')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
