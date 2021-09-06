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
    public partial class add_acte : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=AYOUBLAFAR-PC\ADMINISTRATEUR ; initial catalog=Etat_Civil ; integrated security=SSPI");
        SqlDataReader dr;
        int pos, nbr = 0;
        public void naviguer()
        {
            SqlCommand cmd = new SqlCommand("select * from PersonneA", cnx);
            dr = cmd.ExecuteReader();
            for(int i=0 ; i<=pos ; i++)
            {
                dr.Read();
            }
            t1.Text = dr["Num_Acte"].ToString();
            t9.Text = dr["Annee_Acte"].ToString();
            t2.Text = dr["Nom_ar"].ToString();
            t3.Text = dr["Prenom_ar"].ToString();
            t4.Text = dr["Nationalite_ar"].ToString();
            t5.Text = dr["Lieu_naiss_ar"].ToString();
            t6.Text = dr["Prenom_pere_ar"].ToString();
            t7.Text = dr["Prenom_mere_ar"].ToString();
            t8.Text = dr["Bayan"].ToString();
            t10.Text = dr["Nom_fr"].ToString();
            t11.Text = dr["Prenom_fr"].ToString();
            t12.Text = dr["Nationalite_fr"].ToString();
            t13.Text = dr["Lieu_naiss_fr"].ToString();
            t14.Text = dr["Prenom_pere_fr"].ToString();
            t15.Text = dr["Prenom_mere_fr"].ToString();
            t16.Text = dr["Bayan_fr"].ToString();
            c7.Text = dr["Sexe"].ToString();
            c3.Text = dr["Date_N_jr_ar"].ToString();
            c2.Text = dr["Date_N_mo_ar"].ToString();
            c1.Text = dr["Date_N_an_ar"].ToString();
            c6.Text = dr["Date_N_jr_fr"].ToString();
            c5.Text = dr["Date_N_mo_fr"].ToString();
            c4.Text = dr["Date_N_an_fr"].ToString();
        }
        public add_acte()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            page_principal p = new page_principal();
            p.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.Clear();
            t2.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            t6.Clear();
            t7.Clear();
            t8.Clear();
            t9.Clear();
            t10.Clear();
            t11.Clear();
            t12.Clear();
            t13.Clear();
            t14.Clear();
            t15.Clear();
            t16.Clear();
            t1.Focus();
        }

        private void add_acte_Load(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd= new SqlCommand("select count(*) from PersonneA",cnx);
            nbr=Convert.ToInt32(cmd.ExecuteScalar());
            t12.Text = "MAROCAINE";
            t4.Text = "مغربية";
            c3.Items.Add("فاتح");
            c3.Items.Add("ثاني");
            c3.Items.Add("ثالث");
            c3.Items.Add("رابع");
            c3.Items.Add("خامس");
            c3.Items.Add("سادس");
            c3.Items.Add("سابع");
            c3.Items.Add("ثامن");
            c3.Items.Add("تاسع");
            c3.Items.Add("عاشر");
            c3.Items.Add("الحادي عشر");
            c3.Items.Add("الثاني عشر");
            c3.Items.Add("الثالث عشر");
            c3.Items.Add("الرابع عشر");
            c3.Items.Add("الخامس عشر");
            c3.Items.Add("السادس عشر");
            c3.Items.Add("السابع عشر");
            c3.Items.Add("الثامن عشر");
            c3.Items.Add("التاسع عشر");
            c3.Items.Add("العشرين");
            c3.Items.Add("إحدى و العشرين");
            c3.Items.Add("إثنان و العشرين");
            c3.Items.Add("ثلاثة و العشرين");
            c3.Items.Add("رابع و العشرين");
            c3.Items.Add("خامس و العشرين");
            c3.Items.Add("سادس و العشرين");
            c3.Items.Add("سابع و العشرين");
            c3.Items.Add("ثامن و العشرين");
            c3.Items.Add("تاسع و العشرين");
            c3.Items.Add("الثلاثون");
            c3.Items.Add("إحدى والثلاثون");
            c7.Items.Add("ذكر");   
            c7.Items.Add("أنثى");  
            c2.Items.Add("محرم"); 
            c2.Items.Add("صفر");  
            c2.Items.Add("ربيع الأول");
            c2.Items.Add("ربيع الثاني"); 
            c2.Items.Add("جمادى الأولى");  
            c2.Items.Add("جمادى الثانية");  
            c2.Items.Add("رجب");  
            c2.Items.Add("شعبان");  
            c2.Items.Add("رمضان");  
            c2.Items.Add("شوال");  
            c2.Items.Add("ذو القعدة");  
            c2.Items.Add("ذو الحجة"); 
            c5.Items.Add("يناير");  
            c5.Items.Add("فبراير"); 
            c5.Items.Add("مارس");  
            c5.Items.Add("أبريل");  
            c5.Items.Add("ماي");  
            c5.Items.Add("يونيو");  
            c5.Items.Add("يوليوز");  
            c5.Items.Add("غشت"); 
            c5.Items.Add("سبتمبر");  
            c5.Items.Add("أكتوبر");  
            c5.Items.Add("نونبر"); 
            c5.Items.Add("دجنبر");  
            c6.Items.Add("1");
            c6.Items.Add("2");
            c6.Items.Add("3");
            c6.Items.Add("4");
            c6.Items.Add("5");
            c6.Items.Add("6");
            c6.Items.Add("7");
            c6.Items.Add("8");
            c6.Items.Add("9");
            c6.Items.Add("10");
            c6.Items.Add("11");
            c6.Items.Add("12");
            c6.Items.Add("13");
            c6.Items.Add("14");
            c6.Items.Add("15");
            c6.Items.Add("16");
            c6.Items.Add("17");
            c6.Items.Add("18");
            c6.Items.Add("19");
            c6.Items.Add("20");
            c6.Items.Add("21");
            c6.Items.Add("22");
            c6.Items.Add("23");
            c6.Items.Add("24");
            c6.Items.Add("25");
            c6.Items.Add("26");
            c6.Items.Add("27");
            c6.Items.Add("29");
            c6.Items.Add("30");
            c6.Items.Add("31");
            c4.Items.Add("1980");
            c4.Items.Add("1981");
            c4.Items.Add("1982");
            c4.Items.Add("1983");
            c4.Items.Add("1984");
            c4.Items.Add("1985");
            c4.Items.Add("1986");
            c4.Items.Add("1987");
            c4.Items.Add("1988");
            c4.Items.Add("1989");
            c4.Items.Add("1990");
            c4.Items.Add("1991");
            c4.Items.Add("1992");
            c4.Items.Add("1993");
            c4.Items.Add("1994");
            c4.Items.Add("1995");
            c4.Items.Add("1996");
            c4.Items.Add("1997");
            c4.Items.Add("1998");
            c4.Items.Add("1999");
            c4.Items.Add("2000");
            c4.Items.Add("2001");
            c4.Items.Add("2002");
            c4.Items.Add("2003");
            c4.Items.Add("2004");
            c4.Items.Add("2005");
            c4.Items.Add("2006");
            c4.Items.Add("2007");
            c4.Items.Add("2008");
            c4.Items.Add("2009");
            c4.Items.Add("2010");
            c4.Items.Add("2011");
            c4.Items.Add("2012");
            c4.Items.Add("2013");
            c4.Items.Add("2014");
            c4.Items.Add("2015");
            c4.Items.Add("2016");
            c4.Items.Add("2017");
            c4.Items.Add("2018");
            c1.Items.Add("1400");
            c1.Items.Add("1401");
            c1.Items.Add("1402");
            c1.Items.Add("1403");
            c1.Items.Add("1404");
            c1.Items.Add("1405");
            c1.Items.Add("1406");
            c1.Items.Add("1407");
            c1.Items.Add("1408");
            c1.Items.Add("1409");
            c1.Items.Add("1410");
            c1.Items.Add("1411");
            c1.Items.Add("1412");
            c1.Items.Add("1413");
            c1.Items.Add("1414");
            c1.Items.Add("1415");
            c1.Items.Add("1416");
            c1.Items.Add("1417");
            c1.Items.Add("1418");
            c1.Items.Add("1419");
            c1.Items.Add("1420");
            c1.Items.Add("1421");
            c1.Items.Add("1422");
            c1.Items.Add("1423");
            c1.Items.Add("1424");
            c1.Items.Add("1425");
            c1.Items.Add("1426");
            c1.Items.Add("1427");
            c1.Items.Add("1428");
            c1.Items.Add("1429");
            c1.Items.Add("1430");
            c1.Items.Add("1431");
            c1.Items.Add("1432");
            c1.Items.Add("1433");
            c1.Items.Add("1434");
            c1.Items.Add("1435");
            c1.Items.Add("1436");
            c1.Items.Add("1437");
            c1.Items.Add("1438");
            c1.Items.Add("1439");
            c1.Items.Add("1440");
            cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            if (t9.Text == "" && t3.Text == "" && t10.Text == "")
            {
                MessageBox.Show("!??المرجو ملء جميع الخانات");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into PersonneA values('" + t9.Text + "',N'" + t2.Text + "',N'" + t3.Text + "',N'" + c3.Text + "',N'" + c2.Text + "',N'" + c1.Text + "',N'" + t4.Text + "',N'" + t5.Text + "',N'" + t6.Text + "',N'" + t7.Text + "',N'" + t8.Text + "',N'" + t10.Text + "',N'" + t11.Text + "',N'" + c6.Text + "',N'" + c5.Text + "',N'" + c4.Text + "',N'" + t12.Text + "',N'" + t13.Text + "',N'" + t14.Text + "',N'" + t15.Text + "',N'" + t16.Text + "',N'" + c7.Text + "')", cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("!! (-_-) لقد تمت الاضافة بنجاح");
            }
            
            cnx.Close();
        }

        private void c4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void c1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select * from PersonneA where Num_Acte='" + t1.Text + "'", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                t1.Text = dr["Num_Acte"].ToString();
                t9.Text = dr["Annee_Acte"].ToString();
                t2.Text = dr["Nom_ar"].ToString();
                t3.Text = dr["Prenom_ar"].ToString();
                t4.Text = dr["Nationalite_ar"].ToString();
                t5.Text = dr["Lieu_naiss_ar"].ToString();
                t6.Text = dr["Prenom_pere_ar"].ToString();
                t7.Text = dr["Prenom_mere_ar"].ToString();
                t8.Text = dr["Bayan"].ToString();
                t10.Text = dr["Nom_fr"].ToString();
                t11.Text = dr["Prenom_fr"].ToString();
                t12.Text = dr["Nationalite_fr"].ToString();
                t13.Text = dr["Lieu_naiss_fr"].ToString();
                t14.Text = dr["Prenom_pere_fr"].ToString();
                t15.Text = dr["Prenom_mere_fr"].ToString();
                t16.Text = dr["Bayan_fr"].ToString();
                c7.Text = dr["Sexe"].ToString();
                c3.Text = dr["Date_N_jr_ar"].ToString();
                c2.Text = dr["Date_N_mo_ar"].ToString();
                c1.Text = dr["Date_N_an_ar"].ToString();
                c6.Text = dr["Date_N_jr_fr"].ToString();
                c5.Text = dr["Date_N_mo_fr"].ToString();
                c4.Text = dr["Date_N_an_fr"].ToString();
            }
            dr.Close();
            cnx.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnx.Open();
            if(pos==0)
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
            if(pos==nbr-1)
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
            if (pos == nbr-1)
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
