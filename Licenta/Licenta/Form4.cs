using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Licenta
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }


        
       private decimal calcul(string calc1,string calc2)
       {
            
           decimal S1 = calc1 == "" ? 0: Convert.ToDecimal(calc1);
           decimal S2 = calc2 == "" ? 0: Convert.ToDecimal(calc2);
           decimal R1 = S1 * 1 / (1 + S2 / 100);
       
          return decimal.Round(R1, 2);

       }

        private decimal calcul2(string calc1, string calc2)
        {
            decimal rez = Convert.ToDecimal(txtAdd1.Text);
            decimal S1 = calc1 == "" ? 0 : Convert.ToDecimal(calc1);
            decimal S2 = calc2 == "" ? 0 : Convert.ToDecimal(calc2);
            decimal R1 = S1 / ((1 + S2 / 100)*(1 + rez / 100));


            return decimal.Round(R1, 2);
           
        }

        private decimal calcul3(string calc1, string calc2)
        {
            decimal rez = Convert.ToDecimal(txtAdd1.Text);
            decimal rez2 = Convert.ToDecimal(txtAdd2.Text);
            decimal S1 = calc1 == "" ? 0 : Convert.ToDecimal(calc1);
            decimal S2 = calc2 == "" ? 0 : Convert.ToDecimal(calc2);
            decimal R1 = S1 / ((1 + S2 / 100) * (1 + rez / 100) * (1 + rez2 / 100));

            return decimal.Round(R1, 2);

        }

        private decimal calcul4(string calc1, string calc2)
        {
            decimal rez = Convert.ToDecimal(txtAdd1.Text);
            decimal rez2 = Convert.ToDecimal(txtAdd2.Text);
            decimal rez3 = Convert.ToDecimal(txtAdd3.Text);
            decimal S1 = calc1 == "" ? 0 : Convert.ToDecimal(calc1);
            decimal S2 = calc2 == "" ? 0 : Convert.ToDecimal(calc2);
            decimal R1 = S1 / ((1 + S2 / 100) * (1 + rez / 100) * (1 + rez2 / 100) * (1 + rez3 / 100));

            return decimal.Round(R1, 2);

        }



        private int calcul5(string calc1, string calc2)
        {
           
                decimal S1 = calc1 == "" ? 0 : Convert.ToDecimal(calc1);
                decimal S2 = calc2 == "" ? 0 : Convert.ToDecimal(calc2);
                int R1 = Convert.ToInt32((S1 / S2) * 100);
                return R1;
        }


        private int calcul6(string calc1, string calc2, int n)
        {

            double S1 = calc1 == "" ? 0 : Convert.ToDouble(calc1);
            double S2 = calc2 == "" ? 0 : Convert.ToDouble(calc2);
            double aux = (double) 1 / (n - 1);
            double aux2 = S1 / S2;
            int R1 = Convert.ToInt32(Math.Pow(aux2, aux)*100-100);

            return R1;

        }

       


        private void button5_Click(object sender, EventArgs e)
        {
            if (txtAd1.Text != "" && txtAdd1.Text != "" && txtAd2.Text != "" && txtAdd2.Text != "" && txtAd3.Text != "" && txtAdd3.Text != "" && txtAd4.Text != "" && txtAdd4.Text != "")
            {
                txtCA1.Text = Convert.ToString(calcul(txtAd1.Text, txtAdd1.Text));
                txtCA2.Text = Convert.ToString(calcul2(txtAd2.Text, txtAdd2.Text));
                txtCA3.Text = Convert.ToString(calcul3(txtAd3.Text, txtAdd3.Text));
                txtCA4.Text = Convert.ToString(calcul4(txtAd4.Text, txtAdd4.Text));
                txtDin1.Text = Convert.ToString(calcul5(txtCA1.Text, txtCA1.Text));
                txtDin2.Text = Convert.ToString(calcul5(txtCA2.Text, txtCA1.Text));
                txtDin3.Text = Convert.ToString(calcul5(txtCA3.Text, txtCA1.Text));
                txtDin4.Text = Convert.ToString(calcul5(txtCA4.Text, txtCA1.Text));
                txtLant1.Text = Convert.ToString(calcul5(txtCA1.Text, txtCA1.Text));
                txtLant2.Text = Convert.ToString(calcul5(txtCA2.Text, txtCA1.Text));
                txtLant3.Text = Convert.ToString(calcul5(txtCA3.Text, txtCA2.Text));
                txtLant4.Text = Convert.ToString(calcul5(txtCA4.Text, txtCA3.Text));
                txtRitm.Text = Convert.ToString(calcul6(txtCA4.Text, txtCA1.Text, 4));

            }
            else
            {
                MessageBox.Show("Calculul nu s-a putut efectua! Completați toate câmpurile!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (txtAd1.Text != "" && txtAdd1.Text != "" && txtAd2.Text != "" && txtAdd2.Text != "" && txtAd3.Text != "" && txtAdd3.Text != "" && txtAd4.Text != "" && txtAdd4.Text != "")
            {
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("ReportParameter1", txtAd1.Text));
                reportParameters.Add(new ReportParameter("ReportParameter2", txtAd2.Text));
                reportParameters.Add(new ReportParameter("ReportParameter3", txtAd3.Text));
                reportParameters.Add(new ReportParameter("ReportParameter4", txtAd4.Text));
                reportParameters.Add(new ReportParameter("ReportParameter5", txtAdd1.Text));
                reportParameters.Add(new ReportParameter("ReportParameter6", txtAdd2.Text));
                reportParameters.Add(new ReportParameter("ReportParameter7", txtAdd3.Text));
                reportParameters.Add(new ReportParameter("ReportParameter8", txtAdd4.Text));
                reportParameters.Add(new ReportParameter("ReportParameter9", txtCA1.Text));
                reportParameters.Add(new ReportParameter("ReportParameter10", txtCA2.Text));
                reportParameters.Add(new ReportParameter("ReportParameter11", txtCA3.Text));
                reportParameters.Add(new ReportParameter("ReportParameter12", txtCA4.Text));
                reportParameters.Add(new ReportParameter("ReportParameter13", txtDin1.Text));
                reportParameters.Add(new ReportParameter("ReportParameter14", txtDin2.Text));
                reportParameters.Add(new ReportParameter("ReportParameter15", txtDin3.Text));
                reportParameters.Add(new ReportParameter("ReportParameter16", txtDin4.Text));
                reportParameters.Add(new ReportParameter("ReportParameter17", txtLant1.Text));
                reportParameters.Add(new ReportParameter("ReportParameter18", txtLant2.Text));
                reportParameters.Add(new ReportParameter("ReportParameter19", txtLant3.Text));
                reportParameters.Add(new ReportParameter("ReportParameter20", txtLant4.Text));
                reportParameters.Add(new ReportParameter("ReportParameter21", txtRitm.Text));
                reportParameters.Add(new ReportParameter("ReportParameter21", txtRitm.Text));
                reportParameters.Add(new ReportParameter("ReportParameter23", "Aprecierea dinamicii afacerii"));

                if (Convert.ToInt32(txtRitm.Text) > 0)
                {
                   reportParameters.Add(new ReportParameter("ReportParameter22", "Întreprinderea se află în etapa de dezvoltare, având o evoluție favorabilă a indicatorilor de dinamică și un ritm mediu anual al variației care a înregistrat o creștere semnificativă de " + txtRitm.Text + "%"));

                 
                }
                else if(Convert.ToInt32(txtRitm.Text) == 0)
                {
                    reportParameters.Add(new ReportParameter("ReportParameter22", "Întreprinderea se află în etapa de menținere, având o evoluție constantă a indicatorilor de dinamică și un ritm mediu anual al variației care nu a înregistrat o modificare, acesta având valoarea de " + txtRitm.Text + "%"));
                }
                else 
                {
                    reportParameters.Add(new ReportParameter("ReportParameter22", "Întreprinderea se află în etapa de recesiune, având o evoluție nefavorabilă a indicatorilor de dinamică și un ritm mediu anual al variației care a înregistrat o scădere semnificativă de " + txtRitm.Text + "%"));
                }
                reportViewer1.LocalReport.SetParameters(reportParameters);
                this.reportViewer1.RefreshReport();
            }

            else
            {
                MessageBox.Show("Raportul nu s-a putut genera! Completați toate câmpurile!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
