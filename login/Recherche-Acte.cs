using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class Recherche_Acte : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=AYOUBLAFAR-PC\ADMINISTRATEUR ; initial catalog=Etat_Civil ; integrated security=SSPI");
        SqlDataReader dr;
        public Recherche_Acte()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t1.Clear();
            t1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(r2.Checked)
          {
              cnx.Open();
              SqlCommand cmd = new SqlCommand("select * from Deces where Num_Acte='" + t1.Text + "'", cnx);
              dr = cmd.ExecuteReader();
              DataTable dt = new DataTable();
              dt.Load(dr);
              dataGridView1.DataSource = dt;
              cnx.Close();
          }
          if (r1.Checked)
          {
              cnx.Open();
              SqlCommand cmd = new SqlCommand("select * from PersonneA where Num_Acte='" + t1.Text + "'", cnx);
              dr = cmd.ExecuteReader();
              DataTable dt = new DataTable();
              dt.Load(dr);
              dataGridView1.DataSource = dt;
              cnx.Close();
          }
          if (r3.Checked)
          {
              cnx.Open();
              SqlCommand cmd = new SqlCommand("select * from PersonneA a,PersonneB b where a.Num_Acte=b.Num_Acte and a.Num_Acte='" + t1.Text + "'", cnx);
              dr = cmd.ExecuteReader();
              DataTable dt = new DataTable();
              dt.Load(dr);
              dataGridView1.DataSource = dt;
              cnx.Close();
          }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            page_principal l = new page_principal();
            this.Hide();
            l.Show();
        }
    }
}
