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

        private void btnPromjeniTekst_Click(object sender, EventArgs e)
        {
            lbNaslov.Text = "Kliknuo sam promjeni juhu";
            btnPromjeniTekst.Enabled = false;
        }
    }
}
