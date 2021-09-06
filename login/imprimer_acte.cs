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
    public partial class imprimer_acte : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=AYOUBLAFAR-PC\ADMINISTRATEUR ; initial catalog=Etat_Civil ; integrated security=SSPI");

        public imprimer_acte()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cr2 v = new cr2();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from PersonneA a,PersonneB b where a.Num_Acte='"+textBox1.Text+"'",cnx);
            da.Fill(ds,"PersonneA");
            da.Fill(ds, "PersonneB");
            v.SetDataSource(ds);
            crystalReportViewer1.ReportSource = v;
            crystalReportViewer1.Refresh();
            cnx.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
