using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class page_principal : Form
    {
        public page_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            add_acte a = new add_acte();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Recherche_Acte r = new Recherche_Acte();
            r.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            copie_integral c = new copie_integral();
            c.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Add_deces a = new Add_deces();
            this.Hide();
            a.Show();
        }

        private void page_principal_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Etat_deces k = new Etat_deces();
            k.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imprimer_acte i = new imprimer_acte();
            i.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Imprimer_copie_integrale f = new Imprimer_copie_integrale();
            f.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            imprimer_acte x = new imprimer_acte();
            x.Show();
        }
    }
}
