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
    public partial class Main : Form
    {


        bool dropdown;
      
        public Main()
        {
            InitializeComponent();

        }

      


       


        private void btncautare_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BFNFJ6I;Initial Catalog=TransLo;Integrated Security=True");

            conn.Open();
            SqlCommand com = new SqlCommand(" SELECT Curse.id_cursa, Curse.plecare, Curse.destinatie, Curse.data_plecare, Curse.data_intoarcere, Curse.distanta, Curse.tip_cursa, Camioane.nr_inmatriculare, Camioane.marca," +
                         "Camioane.an_fabricatie, Camioane.consum_mediu, Camioane.echipat_gps, Camioane.taho_digital, Camioane.clasa_poluare, Camioane.tip_camion, Camioane.capacitate, Revizii.motiv," +
                        "Revizii.cost_revizie, Revizii.data_inregistrare, Revizii.data_ridicare, Iesiri_marfa.tip_marfa, Iesiri_marfa.cantitate_marfa, Iesiri_marfa.um, Depozite.nume_depozit, Soferi.nume, Soferi.prenume, Soferi.varsta," +
                        " Soferi.data_angajarii, Clienti.nume_client, Clienti.telefon, Clienti.pers_contact, Clienti.telef_contact" +
                        " FROM Camioane INNER JOIN" +
                        " Curse ON Camioane.id_camion = Curse.id_camion INNER JOIN" +
                        " Clienti ON Curse.id_client = Clienti.id_client INNER JOIN" +
                        " Iesiri_marfa ON Curse.id_cursa = Iesiri_marfa.id_cursa INNER JOIN" +
                        " Depozite ON Iesiri_marfa.id_depozit = Depozite.id_depozit INNER JOIN" +
                        " Revizii ON Camioane.id_camion = Revizii.id_camion INNER JOIN" +
                        " Soferi ON Curse.id_sofer = Soferi.id_sofer AND Revizii.id_sofer = Soferi.id_sofer" +
                        " WHERE Curse.id_cursa = @id_cursa", conn);

            com.Parameters.AddWithValue("@id_cursa", Convert.ToInt32(txtCautare.Text));
            SqlDataReader da = com.ExecuteReader();
            while (da.Read())
            {
                lblPlecare.Text = da.GetValue(1).ToString();
                lblDestinatie.Text = da.GetValue(2).ToString();
                lblDataPlecare.Text = Convert.ToDateTime(da.GetValue(3).ToString()).ToString("yyyy-MMM-dd");
                lblDataIntoarcere.Text = Convert.ToDateTime(da.GetValue(4).ToString()).ToString("yyyy-MMM-dd");
                lblDistanta.Text = da.GetValue(5).ToString();
                lblTipCursa.Text = da.GetValue(6).ToString();
                lblInmatriculare.Text = da.GetValue(7).ToString();
                lblMarca.Text = da.GetValue(8).ToString();
                lblAnFabricatie.Text = da.GetValue(9).ToString();
                lblConsumMediu.Text = da.GetValue(10).ToString();
                lblEchipatGPS.Text = da.GetValue(11).ToString();
                lblTahograf.Text = da.GetValue(12).ToString();
                lblClasaPoluare.Text = da.GetValue(13).ToString();
                lblTipCamion.Text = da.GetValue(14).ToString();
                lblCapacitatea.Text = da.GetValue(15).ToString();
                lblMotivRevizie.Text = da.GetValue(16).ToString();
                lblCostRevizie.Text = da.GetValue(17).ToString();
                lblDataInregistrare.Text = Convert.ToDateTime(da.GetValue(18).ToString()).ToString("yyyy-MMM-dd");
                lblDataRidicare.Text = Convert.ToDateTime(da.GetValue(19).ToString()).ToString("yyyy-MMM-dd");
                lblTipMarfa.Text = da.GetValue(20).ToString();
                lblCantitate.Text = da.GetValue(21).ToString();
                lblUM.Text = da.GetValue(22).ToString();
                lblNumeDep.Text = da.GetValue(23).ToString();
                lblNumeSofer.Text = da.GetValue(24).ToString();
                lblPrenumeSofer.Text = da.GetValue(25).ToString();
                lblVarsta.Text = da.GetValue(26).ToString();
                lblDataAngajare.Text = Convert.ToDateTime(da.GetValue(27).ToString()).ToString("yyyy-MMM-dd");
                lblNumeClient.Text = da.GetValue(28).ToString();
                lblTelefClient.Text = da.GetValue(29).ToString();
                lblPersContact.Text = da.GetValue(30).ToString();
                lblTelefContact.Text = da.GetValue(31).ToString();


            }

            conn.Close();
        }


        private void txtCautare_MouseClick(object sender, MouseEventArgs e)
        {
            txtCautare.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dropdown)
            {
                paneldd.Height += 30;
                if (paneldd.Size == paneldd.MaximumSize)
                {
                    timer1.Stop();
                    dropdown = false;
                }
            }
            else
            {
                paneldd.Height -= 30;
                if (paneldd.Size == paneldd.MinimumSize)
                {
                    timer1.Stop();
                    dropdown = true;
                }
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Documente f1 = new Documente();
            f1.ShowDialog();
            this.Hide();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            f1.ShowDialog();
            this.Hide();
        
        }

       

        private void statisticiCurseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Form2 frm = new Form2();
            frm.TopLevel = false;
            mainpanel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

       

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //mainpanel.Controls.Clear();
            //Adaugacursa frm = new Adaugacursa();
            //frm.TopLevel = false;
            //mainpanel.Controls.Add(frm);
            //frm.Dock = DockStyle.Fill;
            //frm.Show();
           // Adaugacursa f1 = new Adaugacursa();
           // this.Hide();
//f1.ShowDialog();
         //   this.Close();
           
        }

        private void statisiciSoferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Form3 frm = new Form3();
            frm.TopLevel = false;
            mainpanel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form4 f1 = new Form4();
            f1.ShowDialog();
            this.Hide();
          
        }


        private void panelheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Adaugacursa frm = new Adaugacursa();
            frm.TopLevel = false;
            mainpanel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            // mainpanel frm = new mainpanel();
            //  frm.TopLevel = false;
            //    mainpanel.Controls.Add(frm);
            //  frm.Dock = DockStyle.Fill;
            //  frm.Show();

            Main nextform = new Main();
            this.Hide();
            nextform.ShowDialog();
            this.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Documente frm = new Documente();
            frm.TopLevel = false;
            mainpanel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            Map frm = new Map();
            frm.TopLevel = false;
            mainpanel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            Form1 nextForm = new Form1();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            mainpanel.Controls.Clear();
            Form4 frm = new Form4();
            frm.TopLevel = false;
            mainpanel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}