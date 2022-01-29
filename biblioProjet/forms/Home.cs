using biblioProjet.forms.stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioProjet.forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void livreBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            LivreForm f = new LivreForm();
            f.TopLevel = false;
            mainPanel.Controls.Add(f);
            f.Show();
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            StockForm f = new StockForm();
            f.TopLevel = false;
            mainPanel.Controls.Add(f);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AdherentsForm f = new AdherentsForm();
            f.TopLevel = false;
            mainPanel.Controls.Add(f);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            PeriodiqueForm f = new PeriodiqueForm();
            f.TopLevel = false;
            mainPanel.Controls.Add(f);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            CdForm f = new CdForm();
            f.TopLevel = false;
            mainPanel.Controls.Add(f);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            EmpruntForm f = new EmpruntForm();
            f.TopLevel = false;
            mainPanel.Controls.Add(f);
            f.Show();
        }
    }
}
