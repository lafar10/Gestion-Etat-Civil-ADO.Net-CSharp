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
    public partial class loginForm : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=AYOUBLAFAR-PC\ADMINISTRATEUR ; initial catalog=Etat_Civil ; integrated security=SSPI");

        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "select * from users where Login='" + textBox1.Text + "'and Pass_Word='" + textBox2.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, cnx);
            DataTable ds = new DataTable();
            da.Fill(ds);
            if (ds.Rows.Count == 1)
            {
                page_principal f = new page_principal();
                this.Hide(); 
                f.Show();
                
            }
            else
            {
                ll.Visible = true;
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)

                textBox2.UseSystemPasswordChar = true;
           
            else
                textBox2.UseSystemPasswordChar =false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
