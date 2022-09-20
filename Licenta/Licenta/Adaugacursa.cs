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
    public partial class Adaugacursa : Form
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;
        int cursa_ID;


        public Adaugacursa()
        {
            InitializeComponent();
            showdata();

        }



        private void button5_Click(object sender, EventArgs e)
        {

            if (txtPlecare.Text == "" || txtDestinatie.Text == "" || txtDistanta.Text == "" || txtTarif.Text == "" || costcursa.Text == "" || cbtipcursa.Text == "" || cbcamion.Text == "" || cbclient.Text == "" || cbsofer.Text == "")

            {

                MessageBox.Show("Va rugam completati toate campurile");
            }

            else
            {


                con.Open();
                cmd = new SqlCommand("insert into Curse values('" + txtPlecare.Text + "','" + txtDestinatie.Text + "','" + dateTimePicker1.Value.Date + "','" + dateTimePicker2.Value.Date + "','" + txtDistanta.Text + "','" + txtTarif.Text + "','" + costcursa.Text + "','" + cbtipcursa.Text.ToString() + "','" + cbcamion.Text.ToString() + "','" + cbclient.Text.ToString() + "','" + cbsofer.Text.ToString() + "')", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Inregistrarea a fost adaugata cu succes! ");
                con.Close();
                showdata();
                txtPlecare.Text = "";
                txtDestinatie.Text = "";
                dateTimePicker1.CustomFormat = "";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                txtDistanta.Text = "";
                txtTarif.Text = "";
                costcursa.Text = "";
                cbtipcursa.SelectedIndex = -1;
                cbcamion.SelectedIndex = -1;
                cbclient.SelectedIndex = -1;
                cbsofer.SelectedIndex = -1;

            }

        }


        public void showdata()
        {
            adapt = new SqlDataAdapter("select * from Curse", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cursa_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtPlecare.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDestinatie.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDistanta.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTarif.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            costcursa.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbtipcursa.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cbcamion.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            cbclient.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            cbsofer.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {


            if (txtPlecare.Text == "" || txtDestinatie.Text == "" || txtDistanta.Text == "" || txtTarif.Text == "" || costcursa.Text == "" || cbtipcursa.Text == "" || cbcamion.Text == "" || cbclient.Text == "" || cbsofer.Text == "")

            {

                MessageBox.Show("Va rugam completati toate campurile");
            }
            else
            {


                try
                {
                    con.Open();
                    cmd = new SqlCommand("update Curse set plecare='" + txtPlecare.Text + "', destinatie='" + txtDestinatie.Text + "', data_plecare='" + dateTimePicker1.Value.Date + "', data_intoarcere='" + dateTimePicker2.Value.Date + "', distanta='" + txtDistanta.Text + "', tarif_cursa='" + txtTarif.Text + "', cost_transport='" + costcursa.Text + "', tip_cursa='" + cbtipcursa.Text.ToString() + "', id_camion='" + cbcamion.Text.ToString() + "',id_client='" + cbclient.Text.ToString() + "', id_sofer = '" + cbsofer.Text.ToString() + "' where id_cursa='" + cursa_ID + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inregistrarea a fost actualizata cu succes! ");
                    con.Close();
                    showdata();
                    txtPlecare.Text = "";
                    txtDestinatie.Text = "";
                    dateTimePicker1.CustomFormat = "";
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "";
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    txtDistanta.Text = "";
                    txtTarif.Text = "";
                    costcursa.Text = "";
                    cbtipcursa.SelectedIndex = -1;
                    cbcamion.SelectedIndex = -1;
                    cbclient.SelectedIndex = -1;
                    cbsofer.SelectedIndex = -1;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from Curse where id_cursa='" + cursa_ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inregistrarea a fost stearsa cu succes! ");
                showdata();
                txtPlecare.Text = "";
                txtDestinatie.Text = "";
                dateTimePicker1.CustomFormat = "";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                txtDistanta.Text = "";
                txtTarif.Text = "";
                costcursa.Text = "";
                cbtipcursa.SelectedIndex = -1;
                cbcamion.SelectedIndex = -1;
                cbclient.SelectedIndex = -1;
                cbsofer.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime todate = Convert.ToDateTime(dateTimePicker2.Text);
            if (fromdate >= todate)
            {
                MessageBox.Show("Alegeti o data corecta!");

            }

        }

        private void txtDistanta_Leave(object sender, EventArgs e)
        {
            if (!txtDistanta.Text.All(char.IsDigit))
           
                MessageBox.Show("Introduceti doar caractere numerice in campul 'Distanta'!");
               
                
        }

        private void txtTarif_Leave(object sender, EventArgs e)
        {
            if (!txtTarif.Text.All(char.IsDigit))
                MessageBox.Show("Introduceti doar caractere numerice in campul 'Tarfiul cursei'!");
        }

        private void costcursa_Leave(object sender, EventArgs e)
        {
            if (!costcursa.Text.All(char.IsDigit))
                MessageBox.Show("Introduceti doar caractere numerice in campul 'Costul cursei'!");
        }

        private void txtPlecare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDestinatie.Focus();
        }

        private void txtDestinatie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDistanta.Focus();
        }

        private void txtDistanta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTarif.Focus();
        }

        private void txtTarif_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                costcursa.Focus();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            f1.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Adaugacursa f1 = new Adaugacursa();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Documente f1 = new Documente();
            f1.ShowDialog();
            this.Hide();
        }

        private void statisticiCurseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.ShowDialog();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void statisticiSoferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.ShowDialog();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}