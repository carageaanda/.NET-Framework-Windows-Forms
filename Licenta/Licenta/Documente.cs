using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Licenta
{
    public partial class Documente : Form
    {


    

        public Documente()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FACTURĂ", new Font("Arial", 22, FontStyle.Bold), Brushes.DarkBlue, new Point(320, 200));

            e.Graphics.DrawString("Furnizor: " + Furnizor.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 50));
            e.Graphics.DrawString("Nr.ord.registru com./an: " + ordregfz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 80));
            e.Graphics.DrawString("Capital social: " + capital.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 110));
            e.Graphics.DrawString("C.I.F.: " + CIFfz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 140));
            e.Graphics.DrawString("Sediul: " + Sediufz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 170));
            e.Graphics.DrawString("Contul: " + Contul.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 200));
            e.Graphics.DrawString("Banca: " + IBANfz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 230));
            e.Graphics.DrawString("Telefon: " + Telefonfz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 260));


            e.Graphics.DrawString("Seria " + Serie.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(600, 50));
            e.Graphics.DrawString("Nr. " + Nr.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(720, 50));

            e.Graphics.DrawString("Cumpărător: " + Cumparator.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 80));
            e.Graphics.DrawString("Nr.Ord.Reg.Com./an " + ordregcump.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 110));
            e.Graphics.DrawString("C.I.F. " + CIFcl.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 140));
            e.Graphics.DrawString("Sediul: " + Sediucl.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 170));
            e.Graphics.DrawString("Județul: " + Judet.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 200));
            e.Graphics.DrawString("Contul: " + Contcl.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 230));
            e.Graphics.DrawString("Banca: " + Bancacl.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 260));


     
            e.Graphics.DrawString("Nr. facturii: " + Nrfact.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(285, 250));
            e.Graphics.DrawString("Data:    " + Datafact.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(285, 275));
            e.Graphics.DrawString("Nr. aviz de insotire:  " + Nraviz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(285, 300));


            e.Graphics.DrawString("Cota T.V.A. " + CotaTVA.Text + " %", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 340));
            e.Graphics.DrawString("Nr.Crt. ", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 370));
            e.Graphics.DrawString("   0", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 395));
            e.Graphics.DrawString("  " + nrcrt.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 435));
            e.Graphics.DrawString("Denumirea produse/servicii ", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(70, 370));
            e.Graphics.DrawString("   1", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(150, 395));
            e.Graphics.DrawString("" + Denumireprod.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(70, 435));
            e.Graphics.DrawString("U.M. ", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(300, 370));
            e.Graphics.DrawString("   2", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(300, 395));
            e.Graphics.DrawString(" " + UM.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(300, 435));
            e.Graphics.DrawString("Cantitatea ", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(365, 370));
            e.Graphics.DrawString("   3", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(385, 395));
            e.Graphics.DrawString(" " + Cantitatea.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(365, 435));
            e.Graphics.DrawString("Preț unitar fără TVA ", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(465, 370));
            e.Graphics.DrawString("   4", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(510, 395));
            e.Graphics.DrawString("         " + Pretunit.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(465, 435));
            e.Graphics.DrawString("Valoarea", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(635, 370));
            e.Graphics.DrawString("   5", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(650, 395));
            e.Graphics.DrawString(" " + Valoarea.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(635, 435));
            e.Graphics.DrawString("Valoarea T.V.A.", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(730, 370));
            e.Graphics.DrawString("   6", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(760, 395));
            e.Graphics.DrawString(" " + ValoareaTVA.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(730, 435));


            e.Graphics.DrawString("Semnatura", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 520));
            e.Graphics.DrawString("si stampila", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 540));
            e.Graphics.DrawString("furnizorului", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 560));
            e.Graphics.DrawString("Date privind expeditia", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 520));
            e.Graphics.DrawString("Numele delegatului:    " + Numedelegat.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 540));
            e.Graphics.DrawString("Buletin/cartea de identitate", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 560));
            e.Graphics.DrawString("seria " + Seriebuletin.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 580));
            e.Graphics.DrawString("nr. " + nrbuletin.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(290, 580));
            e.Graphics.DrawString("eliberat(a)  " + eliberat.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(380, 580));
            e.Graphics.DrawString("Expedierea s-a efectuat în prezenta noastra la", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 600));
            e.Graphics.DrawString("Data:  " + Dataexp.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 620));
            e.Graphics.DrawString("ora  " + Oraexp.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(360, 620));
            e.Graphics.DrawString("Semnaturile...........", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 650));


            e.Graphics.DrawString("Semnătura", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(600, 520));
            e.Graphics.DrawString("de primire", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(600, 540));
            e.Graphics.DrawString("Total de plată", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(730, 520));
            e.Graphics.DrawString("(col.5+col.6)", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(730, 540));
            e.Graphics.DrawString("   "+ TotalPlata.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(730, 570));


            e.Graphics.DrawString("Conform Legii nr. 82/1991, Legii 571/2003 si O.M.F.P., nr. 2226/2006 - Sistemul de inscriere si numerotare asigurat si gestionat de utilizator si aflat in responsabilitatea acestuia", new Font("Arial", 6, FontStyle.Regular), Brushes.DarkBlue, new Point(0, 1000));

            //linia 1
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(0, 350));

            //linia 2
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(0, 377));

            //linia 3
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(0, 398));

            //linia 4
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(0, 462));
           

            //linii rand 1

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 366));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 382));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 398));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 414));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 430));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 446));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 462));

            //linii rand 2

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 366));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 382));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 398));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 414));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 430));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 446));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 462));

            //linii rand 3


            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 366));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 382));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 398));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 414));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 430));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 446));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 462));

            //linii rand 4

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 366));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 382));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 398));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 414));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 430));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 446));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 462));

            //linii rand 5

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(620, 366));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(620, 382));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(620, 398));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(620, 414));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(620, 430));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(620, 446));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(620, 462));


            //linii rand 6

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(712, 366));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(712, 382));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(712, 398));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(712, 414));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(712, 430));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(712, 446));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(712, 462));




        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

       

        private void Furnizor_MouseClick(object sender, MouseEventArgs e)
        {
            Furnizor.Text = "";
        }

        private void ordregfz_MouseClick(object sender, MouseEventArgs e)
        {
            ordregfz.Text = "";

        }

        private void capital_MouseClick(object sender, MouseEventArgs e)
        {
            capital.Text = "";
        }

        private void CIFfz_MouseClick(object sender, MouseEventArgs e)
        {
            CIFfz.Text = "";
        }

        private void Sediufz_MouseClick(object sender, MouseEventArgs e)
        {
            Sediufz.Text = "";
        }

        private void Contul_MouseClick(object sender, MouseEventArgs e)
        {
            Contul.Text = "";
        }

        private void IBANfz_MouseClick(object sender, MouseEventArgs e)
        {
            IBANfz.Text = "";
        }

        private void Telefonfz_MouseClick(object sender, MouseEventArgs e)
        {
            Telefonfz.Text= "";
        }

        private void Serie_MouseClick(object sender, MouseEventArgs e)
        {
            Serie.Text = "";
        }

        private void Nr_MouseClick(object sender, MouseEventArgs e)
        {
            Nr.Text = "";
        }

       

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {

            e.Graphics.DrawString("UNITATEA " + unitatea.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(40, 40));
            e.Graphics.DrawString("FOAIE DE PARCURS", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(300, 80));
            e.Graphics.DrawString("Tip autovehicul: ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(250, 150));
            e.Graphics.DrawString("Tip combustibil: ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(250, 190));
           
            if (radioButton1.Checked == true)
            {
                e.Graphics.DrawString("Persoane", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, 150));
            }

            else
            {
                e.Graphics.DrawString("Mărfuri", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, 150));
            }

            if (radioButton4.Checked == true)
            {
                e.Graphics.DrawString("Benzină", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, 190));
            }

            else
            {
                e.Graphics.DrawString("Motorină", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, 190));
            }

            e.Graphics.DrawString("Data ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 300));
            e.Graphics.DrawString(""+datafoaiep.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 340));

            e.Graphics.DrawString("Număr auto: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(270, 300));
            e.Graphics.DrawString("" + numarauto.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(270, 340));

            e.Graphics.DrawString("Nume șofer: ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(580, 300));
            e.Graphics.DrawString("" + numesofer.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(580, 340));

            e.Graphics.DrawString("Plecare ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 387));
            e.Graphics.DrawString("Locul ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 425));
            e.Graphics.DrawString(""+locplecare.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 465));
            e.Graphics.DrawString("Ora", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(208, 425));
            e.Graphics.DrawString("" + oraplecare.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(204, 465));

            e.Graphics.DrawString("Sosire", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(320, 387));
            e.Graphics.DrawString("Locul ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 425));
            e.Graphics.DrawString("" + locsosire.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(290, 465));
            e.Graphics.DrawString("Ora", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(408, 425));
            e.Graphics.DrawString("" + orasosire.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(408, 465));

            e.Graphics.DrawString("Km", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(470, 405));
            e.Graphics.DrawString("" + km.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(465, 460));

            e.Graphics.DrawString("Nr. act de", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 400));
            e.Graphics.DrawString("însoțire", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(530, 420));
            e.Graphics.DrawString("" + nract.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 460));

            e.Graphics.DrawString("Observații", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(610, 387));
            e.Graphics.DrawString("" + obs.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(610, 457));

            e.Graphics.DrawString("Consum specific  "+consumspecif.Text + " %", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 512));


            e.Graphics.DrawString("TOTAL KM  " + totalkm.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 512));


            e.Graphics.DrawString("Din care:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 512));

            e.Graphics.DrawString("în oraș  " + inoras.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 512));
            e.Graphics.DrawString("în exterior  " + inexter.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 552));

            e.Graphics.DrawString("Calculație                   " + calculatie.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 572));
            e.Graphics.DrawString("(Nr. de km X 10% consum specific X preț combustibil)", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(120, 600));

            e.Graphics.DrawString("Calculat,", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(120, 650));

            e.Graphics.DrawString("Șofer,", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 650));
            //Tabel

            //linii verticale


            //linia1

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 285));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 301));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 317));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 333));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 349));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 365));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 381));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 397));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 413));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 429));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 445));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 461));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(250, 477));

            //linie ora 
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, 413));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, 429));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, 445));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, 461));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, 477));
            //linie ora2

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(392, 413));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(392, 429));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(392, 445));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(392, 461));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(392, 477));

            //linia2

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(555, 285));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(555, 301));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(555, 317));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(555, 333));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(555, 349));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(555, 365));

            //linie km1
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(452, 380));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(452, 396));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(452, 412));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(452, 428));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(452, 445));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(452, 461));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(452, 477));

            //linie km2

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 380));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 396));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 412));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 428));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 445));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 461));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 477));

            //linie act

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 380));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 396));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 412));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 428));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 445));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 461));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 477));
            //linii orizontale

            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 270));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 364));
            e.Graphics.DrawString("______________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(-426, 396));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 430));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 477));



        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
                printDocument2.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog3.ShowDialog() == DialogResult.OK)
                printDocument3.Print();
        }

        private void printDocument3_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("A V I Z", new Font("Arial", 24, FontStyle.Bold), Brushes.DarkBlue, new Point(370, 230));
            e.Graphics.DrawString("DE ÎNSOȚIRE", new Font("Arial", 22, FontStyle.Bold), Brushes.DarkBlue, new Point(320, 270));
            e.Graphics.DrawString("A MĂRFII", new Font("Arial", 22, FontStyle.Bold), Brushes.DarkBlue, new Point(350, 310));

            e.Graphics.DrawString("Furnizor: " + fzaviz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 80));
            e.Graphics.DrawString("C.I.F. : " + ciffzaviz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 110));
            e.Graphics.DrawString("Nr. O.R.C. : " + nrorcfz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 140));
            e.Graphics.DrawString("Domiciliu/sediul: " + domiciliufz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 170));
            e.Graphics.DrawString("Județul: " + judetfz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 200));
            e.Graphics.DrawString("IBAN: " + ibanavizfz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 230));
            e.Graphics.DrawString("Banca: " + bancaavizfz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 260));
            e.Graphics.DrawString("Capital social: " + capsocfz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(20, 290));


            e.Graphics.DrawString("Cumpărător: " + cumpaviz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 80));
            e.Graphics.DrawString("C.I.F. : " + ciffzaviz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 110));
            e.Graphics.DrawString("Nr. O.R.C. : " + nrorccump.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 140));
            e.Graphics.DrawString("Domiciliu/sediul: " + domiciliucump.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 170));
            e.Graphics.DrawString("Județul: " + judetcump.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 200));
            e.Graphics.DrawString("IBAN: " + ibanavizfz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 230));
            e.Graphics.DrawString("Banca: " + bancacump.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(580, 260));


            e.Graphics.DrawString("Seria: " + serieaviz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(285, 380));
            e.Graphics.DrawString("nr. " + nravviz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(424, 380));
            e.Graphics.DrawString("Data(ziua, luna, anul)  " + dataav.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(285, 410));

            e.Graphics.DrawString("Nr.Crt. ", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 460));
            e.Graphics.DrawString("   0", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 497));
            e.Graphics.DrawString("  " + nrcrtaviz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 520));
            e.Graphics.DrawString("Specificația", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(130, 455));
            e.Graphics.DrawString("(produse, ambalaje etc.)", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(80, 477));
            e.Graphics.DrawString("   1", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(150, 497));
            e.Graphics.DrawString("" + specifavz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(70, 520));
            e.Graphics.DrawString("U.M. ", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(300, 460));
            e.Graphics.DrawString("   2", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(300, 497));
            e.Graphics.DrawString(" " + umavz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(300, 520));
            e.Graphics.DrawString("Cantitatea ", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(365, 460));
            e.Graphics.DrawString("   3", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(385, 497));
            e.Graphics.DrawString(" " + cantavz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(385, 520));
            e.Graphics.DrawString("Preț unitar", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(525, 455));
            e.Graphics.DrawString("(fără T.V.A.) - lei -", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(495, 477));
            e.Graphics.DrawString("   4", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(540, 497));
            e.Graphics.DrawString("         " + pretunitavz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(500, 520));
            e.Graphics.DrawString("Valoarea", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(735, 450));
            e.Graphics.DrawString("- lei -", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(750, 477));
            e.Graphics.DrawString("   5", new Font("Arial", 10, FontStyle.Regular), Brushes.DarkBlue, new Point(750, 497));
            e.Graphics.DrawString(" " + valoareavz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(745, 520));


            e.Graphics.DrawString("Semnatura", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 580));
            e.Graphics.DrawString("si stampila", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 600));
            e.Graphics.DrawString("furnizorului", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(10, 620));
            e.Graphics.DrawString("Date privind expeditia", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 580));
            e.Graphics.DrawString("Numele delegatului:    " + delegatavz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 600));
            e.Graphics.DrawString("Buletin/cartea de identitate", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 620));
            e.Graphics.DrawString("seria " + seriebuletinavz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 640));
            e.Graphics.DrawString("nr. " + nrbulavz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(290, 640));
            e.Graphics.DrawString("eliberat(a)  " + elibavz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(380, 640));
            e.Graphics.DrawString("Expedierea s-a efectuat în prezenta noastra la", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 660));
            e.Graphics.DrawString("Data:  " + dataexpavz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 680));
            e.Graphics.DrawString("ora  " + oraexpavz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(360, 680));
            e.Graphics.DrawString("Semnaturile...........", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(200, 710));

            e.Graphics.DrawString("Total", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(650, 600));
            e.Graphics.DrawString("" +totalavz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(650, 620));
            e.Graphics.DrawString("Semnatura", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(650, 660));
            e.Graphics.DrawString("de primire" , new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(650, 680));




            //linia 1
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(0, 430));

            //linia 2
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(0, 477));

            //linia 3
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(0, 498));

            //linia 4
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(0, 542));


            //linii rand 1

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 446));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 462));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 478));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 494));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 510));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 526));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(62, 542));

            //linii rand 2

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 446));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 462));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 478));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 494));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 510));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 526));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(282, 542));

            //linii rand 3


            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 446));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 462));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 478));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 494));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 510));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 526));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(345, 542));

            //linii rand 4

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 446));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 462));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 478));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 494));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 510));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 526));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(450, 542));

            //linii rand 5

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(680, 446));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(680, 462));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(680, 478));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(680, 494));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(680, 510));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(680, 526));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.DarkBlue, new Point(680, 542));





        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog4.ShowDialog() == DialogResult.OK)
                printDocument4.Print();
        }

        private void printDocument4_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("1", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(5, 40));
            e.Graphics.DrawString("Expeditor(nume, adresa, țara) Sender(name, address, country)", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(30, 45));
            e.Graphics.DrawString("Expediteur(nom, addresse, pays)", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(30, 60));
            e.Graphics.DrawString(""+numeexp1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 90));
            e.Graphics.DrawString("" + adresaexp1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 110));
            e.Graphics.DrawString("" + taraexp1.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 130));
            e.Graphics.DrawString("SCRISOARE DE TRANSPORT", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(420, 60));
            e.Graphics.DrawString("LETTRE DE VOITURE", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(420, 75));
            e.Graphics.DrawString("CONSIGNMENT NOTE", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(420, 90));
            e.Graphics.DrawString("(CMR)", new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(660, 50));
            e.Graphics.DrawString("2", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, 185));
            e.Graphics.DrawString("Destinatar(nume, adresa, țara), Consignee(name, address, country)", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(30, 190));
            e.Graphics.DrawString("Destinataire(nom, adresse, pays)", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(30, 205));
            e.Graphics.DrawString("" + numedest2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 227));
            e.Graphics.DrawString("" + adresadest2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 247));
            e.Graphics.DrawString("" + taradest2.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 267));
            e.Graphics.DrawString("3", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, 305));
            e.Graphics.DrawString("Loc descărcare(loc, țara, data)Lieu et date prevu pour la livraison de la marchandise", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(28, 310));
            e.Graphics.DrawString("Place and date of delivery of goods(place, country, date)", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(28, 325));
            e.Graphics.DrawString("" + locdesc3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 350));
            e.Graphics.DrawString("" + taradesc3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 370));
            e.Graphics.DrawString("" + datadesc3.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 390));
            e.Graphics.DrawString("4", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, 435));
            e.Graphics.DrawString("Locul încărcării(loc, țara, data), Lieu et date de la prise en charge de la marchandise", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(28, 440));
            e.Graphics.DrawString("Place and date of taking over the goods(place, country, date)", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(28, 455));
            e.Graphics.DrawString("" + locinc4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 490));
            e.Graphics.DrawString("" + tarainc4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 510));
            e.Graphics.DrawString("" + datainc4.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 530));
            e.Graphics.DrawString("5", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(1, 555));
            e.Graphics.DrawString("Documente anexate", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(28, 555));
            e.Graphics.DrawString("Documents attached", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(28, 570));
            e.Graphics.DrawString("Documents annexes", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(28, 585));
            e.Graphics.DrawString(""+ docanex5.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(180, 565));
            e.Graphics.DrawString("6", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(1, 600));
            e.Graphics.DrawString("Mărci și numere", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(20, 600));
            e.Graphics.DrawString("Marks and Nos", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(20, 613));
            e.Graphics.DrawString("Marques et numeros", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(20, 624));
            e.Graphics.DrawString(""+ marci6.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(20, 650));
            e.Graphics.DrawString("7", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(120, 600));
            e.Graphics.DrawString("Nr. de colete", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(139, 600));
            e.Graphics.DrawString("Number of packages", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(139, 613));
            e.Graphics.DrawString("Nombre des colis", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(139, 624));

            e.Graphics.DrawString(""+ colete7.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(139, 650));


            e.Graphics.DrawString("8", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(245, 600));
            e.Graphics.DrawString("Mod de ambalare", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(264, 600));
            e.Graphics.DrawString("Method of packing", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(264, 613));
            e.Graphics.DrawString("Mode d'emballage", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(264, 624));

            e.Graphics.DrawString("" + ambalare8.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(264, 650));

            e.Graphics.DrawString("9", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(350, 600));
            e.Graphics.DrawString("Natura mărfii", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(370, 600));
            e.Graphics.DrawString("Nature of the goods", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(370, 613));
            e.Graphics.DrawString("Nature de la marchandise", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(370, 624));

            e.Graphics.DrawString("" + natura9.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(370, 650));

            e.Graphics.DrawString("10", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(493, 600));
            e.Graphics.DrawString("Nr. statistic",new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(530, 600));
            e.Graphics.DrawString("Statistical number", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(530, 613));
            e.Graphics.DrawString("No statistique", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(530, 624));

            e.Graphics.DrawString("" + statistic10.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(530, 650));


            e.Graphics.DrawString("11", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(616, 600));
            e.Graphics.DrawString("Greutate brută, kg", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(648, 600));
            e.Graphics.DrawString("Gross weight, kg", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(648, 613));
            e.Graphics.DrawString("Polds brut, kg", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(648, 624));

            e.Graphics.DrawString("" + greutate11.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(648, 650));


            e.Graphics.DrawString("12", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(732, 600));
            e.Graphics.DrawString("Cubaj, m3", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(768, 600));
            e.Graphics.DrawString("Volume, m3", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(768, 613));
            e.Graphics.DrawString("Cubage, m3", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(768, 624));

            e.Graphics.DrawString("" + cubaj12.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(768, 650));



            e.Graphics.DrawString("13", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(1, 692));
            e.Graphics.DrawString("Instrucțiunile expeditorului", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 694));
            e.Graphics.DrawString("Sender's instructions", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 706));
            e.Graphics.DrawString("Instructions de l'expediteur", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 716));

            e.Graphics.DrawString("" + instructiuni13.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 740));


            e.Graphics.DrawString("14", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(1, 790));
            e.Graphics.DrawString("Instrucțiuni de plată", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 792));
            e.Graphics.DrawString("Instructions as to payment for carriage", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 802));
            e.Graphics.DrawString("Prescriptions d'affranchissement", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 812));


            e.Graphics.DrawString("" + plata14.SelectedItem, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 840));

            e.Graphics.DrawString("15", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(1, 890));
            e.Graphics.DrawString("Suma de plată", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 892));
            e.Graphics.DrawString("Cash on delivery", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 902));
            e.Graphics.DrawString("Ramboursement", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 912));

            e.Graphics.DrawString("" + suma15.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, 899));

            e.Graphics.DrawString("16", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(410, 185));
            e.Graphics.DrawString("Operator de transport(denumire, adresa, țara)", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(450, 190));
            e.Graphics.DrawString("Transporteur(nom, adresse, pays),Carrier(name, address, country)", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(450, 205));

            e.Graphics.DrawString("" + den16.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(430, 227));
            e.Graphics.DrawString("" + adresa16.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(430, 247));
            e.Graphics.DrawString("" + tara16.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(430, 267));

            e.Graphics.DrawString("17", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(410, 305));
            e.Graphics.DrawString("Transportatori succesivi(nume, adresa, țara)", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(445, 310));
            e.Graphics.DrawString("Succesive carriers(name, address, country),Transporteurs successifs(nom, adresse, pays)", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(445, 325));


            e.Graphics.DrawString("" + nume17.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(430, 350));
            e.Graphics.DrawString("" + adresa17.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(430, 370));
            e.Graphics.DrawString("" + tara17.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(430, 390));


            e.Graphics.DrawString("18", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(410, 435));
            e.Graphics.DrawString("Rezerve si observații ale transportorilor", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(445, 440));
            e.Graphics.DrawString("Carrier's reservation and observations,Reserves et observations du transporteur", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(445, 455));

            e.Graphics.DrawString("" + rezerve18.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(440, 510));

            e.Graphics.DrawString("19", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(410, 692));
            e.Graphics.DrawString("Conveții speciale", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(445, 694));
            e.Graphics.DrawString("Special agreements", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(445, 706));
            e.Graphics.DrawString("Conventions particulieres", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(445, 716));


            e.Graphics.DrawString("" + conventii19.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(440, 750));


            e.Graphics.DrawString("20", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(410, 790));
            e.Graphics.DrawString("Plata prin", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(445, 792));
            e.Graphics.DrawString("To be paid by", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(445, 802));
            e.Graphics.DrawString("A payer par", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(445, 812));

        

            e.Graphics.DrawString("Prețul transportului", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(410, 840));
            e.Graphics.DrawString("Carriage changes", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(410, 850));
            e.Graphics.DrawString("Prix de transport", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(410, 860));


            e.Graphics.DrawString(""+pretexp20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(566, 850));
            e.Graphics.DrawString(""+monedapret20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(670, 850));
            e.Graphics.DrawString(""+pretdest20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(765, 850));


            e.Graphics.DrawString("Sold/balance/solde", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(410, 887));

            e.Graphics.DrawString("" + soldexp20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(566, 887));
            e.Graphics.DrawString("" + mdsold20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(670, 887));
            e.Graphics.DrawString("" + solddest20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(765, 887));

            e.Graphics.DrawString("Taxe suplimentare", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(410, 910));
            e.Graphics.DrawString("Supplem charges", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(410, 920));
            e.Graphics.DrawString("Supplements", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(410, 930));

            e.Graphics.DrawString("" + taxesupexp20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(566, 920));
            e.Graphics.DrawString("" + taxesupmd20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(670, 920));
            e.Graphics.DrawString("" + taxesupdest20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(765, 920));

            e.Graphics.DrawString("Alte taxe", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(410, 950));
            e.Graphics.DrawString("Other changes", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(410, 960));
            e.Graphics.DrawString("Frais accesoires", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(410, 970));

            e.Graphics.DrawString("" + altetxexp20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(566, 960));
            e.Graphics.DrawString("" + altetxmd20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(670, 960));
            e.Graphics.DrawString("" + altetxdest20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(765, 960));

            e.Graphics.DrawString("Total", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(410, 995));

            e.Graphics.DrawString("" + totalexp20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(566, 995));
            e.Graphics.DrawString("" + totalmd20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(670, 995));
            e.Graphics.DrawString("" + totaldest20.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(765, 995));

            e.Graphics.DrawString("Expeditor", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(566, 793));
            e.Graphics.DrawString("Sender", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(566, 804));
            e.Graphics.DrawString("Expediteur", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(566, 815));



            e.Graphics.DrawString("Moneda", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(670, 793));
            e.Graphics.DrawString("Currency", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(670, 804));
            e.Graphics.DrawString("Monnaie", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(670, 815));



            e.Graphics.DrawString("Destinatar", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(765, 793));
            e.Graphics.DrawString("Consignee", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(765, 804));
            e.Graphics.DrawString("Destinataire", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(765, 815));




            e.Graphics.DrawString("21", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(1, 955));
            e.Graphics.DrawString("Stabilit în", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 952));
            e.Graphics.DrawString("data", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(275, 952));
            e.Graphics.DrawString("Established in", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 962));
            e.Graphics.DrawString("on", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(275, 962));
            e.Graphics.DrawString("Establie a", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(35, 972));
            e.Graphics.DrawString("le", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(275, 972));

            e.Graphics.DrawString("" + loc21.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(130, 962));
            e.Graphics.DrawString("" + data21.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(315, 962));


            e.Graphics.DrawString("22", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(1, 1015));
            e.Graphics.DrawString("Semnătura și ștampila expeditorului:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(75, 1065));
            e.Graphics.DrawString("Signature and stamp of the sender:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(75, 1075));
            e.Graphics.DrawString("Signature et timbre de l'expediteur:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(75, 1085));


            e.Graphics.DrawString("23", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(265, 1015));
            e.Graphics.DrawString("Semnătura și ștampila transportorului:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(339, 1065));
            e.Graphics.DrawString("Signature and stamp of the carrier:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(339, 1075));
            e.Graphics.DrawString("Signature et timbre du transporteur:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(339, 1085));


            e.Graphics.DrawString("24", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(544, 1015));
            e.Graphics.DrawString("Semnătura și ștampila destinatarului:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(618, 1065));
            e.Graphics.DrawString("Signature and stamp of the consignee:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(618, 1075));
            e.Graphics.DrawString("Signature et timbre du destinataire:", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(618, 1085));

            //linii orizontale

            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 20));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(-800, 60));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 167));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 207));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 287));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 327));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 415));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 455));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(-800, 535));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 581));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 677)); //aici
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 775));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(405, 820));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 865));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(405, 890 ));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 930));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(405, 970));
            e.Graphics.DrawString("________________________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 995));


            //linii verticale

            //linie mijloc

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 35));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 51));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 67));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 83));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 99));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 115));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 131));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 147));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 163));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 179));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 195));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 211));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 227));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 243));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 259));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 275));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 291));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 307));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 323));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 339));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 355));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 371));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 387));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 403));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 419));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 435));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 451));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 467));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 483));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 499));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 515));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 531));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 547)); 
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 563));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 579));


            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 691));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 707));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 723));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 739));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 755));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 771));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 787));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 803));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 819));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 835));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 851));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 867));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 883));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 899));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 915));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 931));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 947));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 963));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 979));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(404, 995));
          

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(490, 595));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(490, 611));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(490, 627));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(490, 643));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(490, 659));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(490, 675));


            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(610, 595));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(610, 611));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(610, 627));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(610, 643));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(610, 659));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(610, 675));


            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(730, 595));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(730, 611));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(730, 627));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(730, 643));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(730, 659));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(730, 675));

            //lini nr.20
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 790));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 806));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 822));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 838));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 854));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 870));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 886));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 902));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 918));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 934));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 950));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 966));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 982));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 998));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 1014));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 1030));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 1046));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 1062));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 1078));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(540, 1094));


            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 790));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 806));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 822));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 838));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 854));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 870));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 886));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 902));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 918));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 934));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 950));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 966));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 982));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(640, 995));

            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 790));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 806));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 822));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 838));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 854));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 870));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 886));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 902));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 918));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 934));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 950));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 966));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 982));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(740, 995));


            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(260, 1011));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(260, 1027));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(260, 1043));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(260, 1059));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(260, 1075));
            e.Graphics.DrawString("|", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(260, 1091));


        

        }

       
        


        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       




        private void statisticiCurseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.ShowDialog();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Documente f1 = new Documente();
            f1.ShowDialog();
            this.Hide();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Adaugacursa f1 = new Adaugacursa();
            f1.ShowDialog();
        }

        private void statisticiSoferiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.ShowDialog();
            this.Hide();
        }
    }
}