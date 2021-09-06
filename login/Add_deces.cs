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
    public partial class Add_deces : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=AYOUBLAFAR-PC\ADMINISTRATEUR ; initial catalog=Etat_Civil ; integrated security=SSPI");
        SqlDataReader dr;
        int pos, nbr = 0;
        public void naviguer()
        {
            SqlCommand cmd = new SqlCommand("select * from Deces", cnx);
            dr = cmd.ExecuteReader();
            for (int i = 0; i <= pos; i++)
            {
                dr.Read();
            }
            textBox1.Text = dr["Num_Acte"].ToString();
            textBox2.Text = dr["Annee_Acte"].ToString();
            textBox3.Text = dr["Nom_ar"].ToString();
            textBox4.Text = dr["Prenom_ar"].ToString();
            dateTimePicker1.Text = dr["Date_Deces"].ToString();
        }
        public Add_deces()
        {
            InitializeComponent();
        }

        private void Add_deces_Load(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Deces", cnx);
            nbr = Convert.ToInt32(cmd.ExecuteScalar());
            cnx.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from Deces where Num_Acte='" + textBox1.Text + "'", cnx);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                textBox1.Text = dr["Num_Acte"].ToString();
                textBox2.Text = dr["Annee_Acte"].ToString();
                textBox3.Text = dr["Nom_ar"].ToString();
                textBox4.Text = dr["Prenom_ar"].ToString();
                dateTimePicker1.Text = dr["Date_Deces"].ToString();
            }
            cnx.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("!??المرجو ملء جميع الخانات");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Deces values('" + textBox1.Text + "','" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "','" + dateTimePicker1.Value.ToString() + "')", cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("!! (-_-) لقد تمت الاضافة بنجاح");
            }
           
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("update Deces set Annee_Acte='"+textBox2.Text+"',Nom_ar=N'"+textBox3.Text+"',Prenom_ar=N'"+textBox4.Text+"',Date_Deces='"+dateTimePicker1.Value.ToString()+"'where Num_Acte='"+textBox1.Text+"'",cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("!! (-_-) لقد تم التعديل بنجاح");
            cnx.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            page_principal p = new page_principal();
            this.Hide();
            p.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cnx.Open();
            if (pos == 0)
            {
                pos = 0;
                naviguer();
                MessageBox.Show("أنت في العقد الأول");
            }

            cnx.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cnx.Open();
            if (pos == nbr - 1)
            {
                MessageBox.Show("أنت في العقد الأخير ");
            }
            else
            {
                pos += 1;
                naviguer();
            }
            cnx.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cnx.Open();
            if (pos == 0)
            {
                MessageBox.Show("أنت في العقد الأول");
            }
            else
            {
                pos -= 1;
                naviguer();
            }
            cnx.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cnx.Open();
            if (pos == nbr - 1)
            {
                MessageBox.Show("أنت في العقد الأخير ");
            }
            else
            {
                pos = nbr - 1;
                naviguer();
            }
            cnx.Close();
        }
    }
}
