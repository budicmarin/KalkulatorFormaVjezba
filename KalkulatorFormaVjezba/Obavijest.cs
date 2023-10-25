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
    public partial class Obavijest : Form
    {
        public Obavijest()
        {
            InitializeComponent();
        }

        private void btnBroj_Click(object sender, EventArgs e)
        {
            
        }

        private void Obavijest_Load(object sender, EventArgs e)
        {

        }

        private void txUnos_TextChanged(object sender, EventArgs e)
        {
            int brojZnakova = 0;
            brojZnakova = txUnos.Text.Length;
            lbBroj.Text = brojZnakova.ToString();
        }
    }
}
