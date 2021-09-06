using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace login
{
    public partial class Imprimer_copie_integrale : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=AYOUBLAFAR-PC\ADMINISTRATEUR ; initial catalog=Etat_Civil ; integrated security=SSPI");

        public Imprimer_copie_integrale()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cr3 v = new cr3();
            SqlDataAdapter da = new SqlDataAdapter("select * from  PersonneA a,PersonneB b where a.Num_Acte = b.Num_Acte and a.Num_Acte='" + textBox1.Text + "'", cnx);
            DataSet ds = new DataSet();
            da.Fill(ds,"PersonneA");
            da.Fill(ds, "PersonneB");
            v.SetDataSource(ds);
            crystalReportViewer1.ReportSource = v;
            crystalReportViewer1.Refresh();
            cnx.Close();
        }
    }
}
