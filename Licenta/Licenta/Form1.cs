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

namespace Licenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
     
    

      
        private void chkboxpass_CheckedChanged(object sender, EventArgs e)
        {

            if (chkboxpass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
               txtPass.PasswordChar = '•';
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BFNFJ6I;Initial Catalog=TransLo;Integrated Security=True");
            conn.Open();
            string utilizator, parola;

            utilizator = txtUser.Text;
            parola = txtPass.Text;

            if (txtUser.Text != "" && txtPass.Text != "")
            {

                string interog = "SELECT * FROM Login WHERE utilizator = '" + txtUser.Text + "' AND parola='" + txtPass.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(interog, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    utilizator = txtUser.Text;
                    parola = txtPass.Text;

                    Main nextForm = new Main();
                    this.Hide();
                    nextForm.ShowDialog();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Date de logare incorecte!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Clear();
                    txtPass.Clear();
                    txtUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Logarea a eșuat! Completați toate câmpurile!");
               
            }
            conn.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
