using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorFormaVjezba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        float rezultat = 0;
        float prviBroj = 0;
        float drugiBroj = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            izracun(btnPlus.Text);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            izracun(btnMinus.Text);
        }

        private void buttonMnoz_Click(object sender, EventArgs e)
        {

            izracun(buttonMnoz.Text);
        }

        private void btnDijeljenje_Click(object sender, EventArgs e)
        {
            izracun(btnDijeljenje.Text);
        }
        void parsiranje( ) {
            Greska greska = new Greska();
            if (float.TryParse(txPrviBroj.Text, out prviBroj)) { }
            else {
                
                    greska.Show();
                    
                   }
            if (float.TryParse(txDrugiBroj.Text, out drugiBroj)) { }
            else
            {

                greska.Show();

            }


        }
        void izracun(string znak)
        {
            parsiranje();
            switch(znak)
            {
                case "+":
                    rezultat = prviBroj + drugiBroj;
                    txBoxRezultat.Text = rezultat.ToString();
                    break;
                case "-":
                
                    rezultat =prviBroj - drugiBroj;
                    txBoxRezultat.Text = rezultat.ToString();
                    break;
                case "*":
                    rezultat = prviBroj * drugiBroj;
                    txBoxRezultat.Text = rezultat.ToString();
                    break;
                case "/":
                    rezultat=prviBroj/drugiBroj;
                    txBoxRezultat.Text = rezultat.ToString();
                    break;



            }


        }

        private void btnOtvoriNovuFormu_Click(object sender, EventArgs e)
        {
            Obavijest obavijest = new Obavijest();
            obavijest.Show();
        }
    }
}
