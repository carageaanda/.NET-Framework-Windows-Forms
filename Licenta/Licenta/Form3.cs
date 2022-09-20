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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString);

        SqlCommand cmd;
        SqlDataReader dr;
     

        public Form3()
        {
            InitializeComponent();

            string query = "select count(id_sofer) from Soferi;";
            string query2 = "SELECT AVG(salariu) from Soferi;";
            string query3 = "select AVG(distanta) from Curse";
            string query4 = "select AVG(cantitate_marfa) from Iesiri_marfa;";
        
            SqlCommand com = new SqlCommand(query, con);
            SqlCommand com2 = new SqlCommand(query2, con);
            SqlCommand com3 = new SqlCommand(query3, con);
            SqlCommand com4 = new SqlCommand(query4, con);
          

            DataSet ds = new DataSet();
            con.Open();
            lblNrTot.Text = Convert.ToString(com.ExecuteScalar());
            lblSal.Text = Convert.ToString(com2.ExecuteScalar());
            lblDis.Text = Convert.ToString(com3.ExecuteScalar());
            lblCant.Text = Convert.ToString(com4.ExecuteScalar());
        



            con.Close();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            string sql = "SELECT * FROM Soferi";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["id_sofer"]);
            }
            con.Close();


            LoadData();
         

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM Soferi WHERE id_sofer=@id_sofer", con);  
            cmd.Parameters.AddWithValue("@id_sofer", comboBox1.Text);
            con.Open();
            dr = cmd.ExecuteReader();
           
            while (dr.Read())
            {
                string numeSofer = dr["nume"].ToString();
                string prenumeSofer = dr["prenume"].ToString();
                string cnpSofer = dr["cnp"].ToString();
                string varstaSofer = dr["varsta"].ToString();
                string genSofer = dr["sex"].ToString();
                string telefonSofer = dr["telefon"].ToString();
                string adresaSofer = dr["adresa"].ToString();
                string localitateSofer = dr["localitatea"].ToString();
                string taraSofer = dr["tara"].ToString();
                string dataSofer = dr["data_angajarii"].ToString();
                string salariuSofer = dr["salariu"].ToString();

                lblNume.Text = numeSofer;
                lblPren.Text = prenumeSofer;
                lblCnp.Text = cnpSofer;
                lblVarsta.Text = varstaSofer;
                lblSex.Text = genSofer;
                lblTelef.Text = telefonSofer;
                lblAdresa.Text = adresaSofer;
                lblLocalitatea.Text = localitateSofer;
                lblTara.Text = taraSofer;
                dateTimePicker1.Text = dataSofer;
                lblSalariu.Text = salariuSofer;
         


     
            }
            con.Close();

            string query = "select count(id_cursa) from Curse where id_sofer='" + comboBox1.Text.ToString() + "'";
            string query2 = "select avg(distanta) from Curse where id_sofer='" + comboBox1.Text.ToString() + "'";
            string query3 = "select count (distinct destinatie) from Curse where id_sofer='" + comboBox1.Text.ToString() + "'";
            string query4 = "select sum(cost_transport) from Curse where id_sofer='" + comboBox1.Text.ToString() + "'";
            string query5 = "select count(id_cursa) from Curse where tip_cursa ='nationala'and id_sofer='" + comboBox1.Text.ToString() + "'";
            string query6 = "select count(id_cursa) from Curse where tip_cursa ='internationala'and id_sofer='" + comboBox1.Text.ToString() + "'";
            SqlCommand com = new SqlCommand(query, con);
            SqlCommand com2 = new SqlCommand(query2, con);
            SqlCommand com3 = new SqlCommand(query3, con);
            SqlCommand com4 = new SqlCommand(query4, con);
            SqlCommand com5 = new SqlCommand(query5, con);
            SqlCommand com6 = new SqlCommand(query6, con);
            con.Open();
            lblNrcurse.Text = Convert.ToString(com.ExecuteScalar());
            lblDist.Text = Convert.ToString(com2.ExecuteScalar());
            lblDest.Text = Convert.ToString(com3.ExecuteScalar());
            lblIncasari.Text = Convert.ToString(com4.ExecuteScalar());
            lblNat.Text = Convert.ToString(com5.ExecuteScalar());
            lblIntern.Text = Convert.ToString(com6.ExecuteScalar());
            con.Close();

            string sqlquery = "SELECT * from [dbo].[Curse] where id_sofer='" + comboBox1.Text.ToString() + "'";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
            con.Open();
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();



        }


        private void LoadData()
        {
            chart1.DataSource = GetData();
            chart1.Series["Series1"].XValueMember = "Gen";
            chart1.Series["Series1"].YValueMembers = "Total";
        }

        private DataTable GetData()
        {
            DataTable dtChartData = new DataTable();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ChartData", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtChartData.Load(reader);
                }
            }
            return dtChartData;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lblSex_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     
        private void lblLocalitatea_Click(object sender, EventArgs e)
        {

        }
    }
}
