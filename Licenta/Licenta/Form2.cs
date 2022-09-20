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
using System.Configuration;

namespace Licenta
{
    public partial class Form2 : Form
    {

    



        public Form2()
        {
            InitializeComponent();
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string query = "SELECT COUNT(id_cursa) FROM Curse;";
            string query2 = "SELECT COUNT(id_cursa) FROM Curse WHERE tip_cursa = 'nationala';";
            string query3 = "SELECT COUNT(id_cursa) FROM Curse WHERE tip_cursa = 'internationala';";
            string query4 = "SELECT SUM(tarif_cursa) FROM Curse;";
            string query5 = "SELECT SUM(t1.cost_tr + t2.cost_rev)FROM(SELECT SUM(cost_transport) as cost_tr FROM Curse) t1 FULL OUTER JOIN (SELECT SUM(cost_revizie) as cost_rev FROM Revizii) t2 ON 1=1;";
            SqlCommand com = new SqlCommand(query, sqlconn);
            SqlCommand com2 = new SqlCommand(query2, sqlconn);
            SqlCommand com3 = new SqlCommand(query3, sqlconn);
            SqlCommand com4 = new SqlCommand(query4, sqlconn);
            SqlCommand com5 = new SqlCommand(query5, sqlconn);
            DataSet ds = new DataSet();
            sqlconn.Open();
            nrcurse.Text = Convert.ToString(com.ExecuteScalar());
            lblintern.Text = Convert.ToString(com2.ExecuteScalar());
            lblnat.Text = Convert.ToString(com3.ExecuteScalar());
            lblinc.Text = Convert.ToString(com4.ExecuteScalar());
            lblcost.Text = Convert.ToString(com5.ExecuteScalar());
            sqlconn.Close();

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "SELECT DISTINCT destinatie from [dbo].[Curse]";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            comboBox1.DisplayMember = "destinatie";
            comboBox1.DataSource = dt;
            sqlconn.Close();

        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "SELECT * from [dbo].[Curse] where destinatie='" + comboBox1.Text.ToString() + "'";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            LoadData();
            sqlconn.Close();
        }


        private DataTable GetData()
        {
            DataTable dtChartData = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("chartcurse", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@dest", comboBox1.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtChartData.Load(reader);
                }
            }
            return dtChartData;

        }

        private void LoadData()
        {
            chart1.DataSource = GetData();
            chart1.Series["Cost transport"].Points.Clear();
            chart1.Series["Cost transport"].XValueMember = "id_cursa";
            chart1.Series["Cost transport"].YValueMembers = "cost";
            chart1.Series["Incasari"].XValueMember = "id_cursa";
            chart1.Series["Incasari"].YValueMembers = "incasari";
            chart1.Series["Venit"].XValueMember = "id_cursa";
            chart1.Series["Venit"].YValueMembers = "venit";
        }




        private void statisticiSoferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.ShowDialog();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }


}
