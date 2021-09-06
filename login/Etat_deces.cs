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
using System.Data;

namespace login
{
    public partial class Etat_deces : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=AYOUBLAFAR-PC\ADMINISTRATEUR ; initial catalog=Etat_Civil ; integrated security=SSPI");

        public Etat_deces()
        {
            InitializeComponent();
        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cr1 c = new cr1();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from Deces d where d.Annee_Acte='" + textBox1.Text + "'", cnx);
            da.Fill(ds,"Deces");
            c.SetDataSource(ds);
            crystalReportViewer1.ReportSource = c;
            crystalReportViewer1.Refresh();
            cnx.Close();
        }
    }
}
