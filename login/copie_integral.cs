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
    public partial class copie_integral : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=AYOUBLAFAR-PC\ADMINISTRATEUR ; initial catalog=Etat_Civil ; integrated security=SSPI");
        SqlDataReader dr;
        int pos, nbr = 0;
        public void naviguer()
        {
            SqlCommand cmd = new SqlCommand("select * from PersonneB", cnx);
            dr = cmd.ExecuteReader();
            for (int i = 0; i <= pos; i++)
            {
                dr.Read();
            }
            textBox1.Text = dr["Num_Acte"].ToString();
            textBox3.Text = dr["Nationalite_ar_pr"].ToString();
            textBox4.Text = dr["Nationalite_fr_pr"].ToString();
            t3.Text = dr["Lieu_naiss_ar_pr"].ToString();
            c10.Text = dr["Date_N_jr_ar_p"].ToString();
            c11.Text = dr["Date_N_mo_ar_p"].ToString();
            c12.Text = dr["Date_N_an_ar_p"].ToString();
            c3.Text = dr["Date_N_jr_fr_p"].ToString();
            c2.Text = dr["Date_N_mo_fr_p"].ToString();
            c1.Text = dr["Date_N_an_fr_p"].ToString();
            t5.Text = dr["profession_ar_pr"].ToString();
            t9.Text = dr["Nationalite_ar_mr"].ToString();
            t10.Text = dr["Nationalite_fr_mr"].ToString();
            t4.Text = dr["Lieu_naiss_ar_mr"].ToString();
            c7.Text = dr["Date_N_jr_ar_m"].ToString();
            c8.Text = dr["Date_N_mo_ar_m"].ToString();
            c9.Text = dr["Date_N_an_ar_m"].ToString();
            c6.Text = dr["Date_N_jr_fr_m"].ToString();
            c5.Text = dr["Date_N_mo_fr_m"].ToString();
            c4.Text = dr["Date_N_an_fr_m"].ToString();
            t6.Text = dr["profession_ar_mr"].ToString();
            t7.Text = dr["Domiciles_ar"].ToString();
            t8.Text = dr["Declaration_ar"].ToString();
            c13.Text = dr["Date_drs_fr_j"].ToString();
            c14.Text = dr["Date_drs_fr_mo"].ToString();
            c15.Text = dr["Date_drs_fr_an"].ToString();
            c16.Text = dr["Date_drs_ar_j"].ToString();
            c17.Text = dr["Date_drs_ar_mo"].ToString();
            c18.Text = dr["Date_drs_ar_an"].ToString();
            t9.Text = dr["Officier_etat_civil_ar"].ToString();
            t10.Text = dr["Hamich_ar"].ToString();
        }
        public copie_integral()
        {
            InitializeComponent();
        }

        private void copie_integral_Load(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from PersonneB", cnx);
            nbr = Convert.ToInt32(cmd.ExecuteScalar());
            c16.Items.Add("فاتح");
            c16.Items.Add("ثاني");
            c16.Items.Add("ثالث");
            c16.Items.Add("رابع");
            c16.Items.Add("خامس");
            c16.Items.Add("سادس");
            c16.Items.Add("سابع");
            c16.Items.Add("ثامن");
            c16.Items.Add("تاسع");
            c16.Items.Add("عاشر");
            c16.Items.Add("الحادي عشر");
            c16.Items.Add("الثاني عشر");
            c16.Items.Add("الثالث عشر");
            c16.Items.Add("الرابع عشر");
            c16.Items.Add("الخامس عشر");
            c16.Items.Add("السادس عشر");
            c16.Items.Add("السابع عشر");
            c16.Items.Add("الثامن عشر");
            c16.Items.Add("التاسع عشر");
            c16.Items.Add("العشرين");
            c16.Items.Add("إحدى و العشرين");
            c16.Items.Add("إثنان و العشرين");
            c16.Items.Add("ثلاثة و العشرين");
            c16.Items.Add("رابع و العشرين");
            c16.Items.Add("خامس و العشرين");
            c16.Items.Add("سادس و العشرين");
            c16.Items.Add("سابع و العشرين");
            c16.Items.Add("ثامن و العشرين");
            c16.Items.Add("تاسع و العشرين");
            c16.Items.Add("الثلاثون");
            c16.Items.Add("إحدى والثلاثون");
            c13.Items.Add("1");
            c13.Items.Add("2");
            c13.Items.Add("3");
            c13.Items.Add("4");
            c13.Items.Add("5");
            c13.Items.Add("6");
            c13.Items.Add("7");
            c13.Items.Add("8");
            c13.Items.Add("9");
            c13.Items.Add("10");
            c13.Items.Add("11");
            c13.Items.Add("12");
            c13.Items.Add("13");
            c13.Items.Add("14");
            c13.Items.Add("15");
            c13.Items.Add("16");
            c13.Items.Add("17");
            c13.Items.Add("18");
            c13.Items.Add("19");
            c13.Items.Add("20");
            c13.Items.Add("21");
            c13.Items.Add("22");
            c13.Items.Add("23");
            c13.Items.Add("24");
            c13.Items.Add("25");
            c13.Items.Add("26");
            c13.Items.Add("27");
            c13.Items.Add("29");
            c13.Items.Add("30");
            c13.Items.Add("31");
            c17.Items.Add("محرم");
            c17.Items.Add("صفر");
            c17.Items.Add("ربيع الأول");
            c17.Items.Add("ربيع الثاني");
            c17.Items.Add("جمادى الأولى");
            c17.Items.Add("جمادى الثانية");
            c17.Items.Add("رجب");
            c17.Items.Add("شعبان");
            c17.Items.Add("رمضان");
            c17.Items.Add("شوال");
            c17.Items.Add("ذو القعدة");
            c17.Items.Add("ذو الحجة"); 
            c14.Items.Add("يناير");
            c14.Items.Add("فبراير");
            c14.Items.Add("مارس");
            c14.Items.Add("أبريل");
            c14.Items.Add("ماي");
            c14.Items.Add("يونيو");
            c14.Items.Add("يوليوز");
            c14.Items.Add("غشت");
            c14.Items.Add("سبتمبر");
            c14.Items.Add("أكتوبر");
            c14.Items.Add("نونبر");
            c14.Items.Add("دجنبر");
            c18.Items.Add("1400");
            c18.Items.Add("1401");
            c18.Items.Add("1402");
            c18.Items.Add("1403");
            c18.Items.Add("1404");
            c18.Items.Add("1405");
            c18.Items.Add("1406");
            c18.Items.Add("1407");
            c18.Items.Add("1408");
            c18.Items.Add("1409");
            c18.Items.Add("1410");
            c18.Items.Add("1411");
            c18.Items.Add("1412");
            c18.Items.Add("1413");
            c18.Items.Add("1414");
            c18.Items.Add("1415");
            c18.Items.Add("1416");
            c18.Items.Add("1417");
            c18.Items.Add("1418");
            c18.Items.Add("1419");
            c18.Items.Add("1420");
            c18.Items.Add("1421");
            c18.Items.Add("1422");
            c18.Items.Add("1423");
            c18.Items.Add("1424");
            c18.Items.Add("1425");
            c18.Items.Add("1426");
            c18.Items.Add("1427");
            c18.Items.Add("1428");
            c18.Items.Add("1429");
            c18.Items.Add("1430");
            c18.Items.Add("1431");
            c18.Items.Add("1432");
            c18.Items.Add("1433");
            c18.Items.Add("1434");
            c18.Items.Add("1435");
            c18.Items.Add("1436");
            c18.Items.Add("1437");
            c18.Items.Add("1438");
            c18.Items.Add("1439");
            c18.Items.Add("1440");
            c15.Items.Add("1980");
            c15.Items.Add("1981");
            c15.Items.Add("1982");
            c15.Items.Add("1983");
            c15.Items.Add("1984");
            c15.Items.Add("1985");
            c15.Items.Add("1986");
            c15.Items.Add("1987");
            c15.Items.Add("1988");
            c15.Items.Add("1989");
            c15.Items.Add("1990");
            c15.Items.Add("1991");
            c15.Items.Add("1992");
            c15.Items.Add("1993");
            c15.Items.Add("1994");
            c15.Items.Add("1995");
            c15.Items.Add("1996");
            c15.Items.Add("1997");
            c15.Items.Add("1998");
            c15.Items.Add("1999");
            c15.Items.Add("2000");
            c15.Items.Add("2001");
            c15.Items.Add("2002");
            c15.Items.Add("2003");
            c15.Items.Add("2004");
            c15.Items.Add("2005");
            c15.Items.Add("2006");
            c15.Items.Add("2007");
            c15.Items.Add("2008");
            c15.Items.Add("2009");
            c15.Items.Add("2010");
            c15.Items.Add("2011");
            c15.Items.Add("2012");
            c15.Items.Add("2013");
            c15.Items.Add("2014");
            c15.Items.Add("2015");
            c15.Items.Add("2016");
            c15.Items.Add("2017");
            c15.Items.Add("2018");
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
            c2.Items.Add("يناير");
            c2.Items.Add("فبراير");
            c2.Items.Add("مارس");
            c2.Items.Add("أبريل");
            c2.Items.Add("ماي");
            c2.Items.Add("يونيو");
            c2.Items.Add("يوليوز");
            c2.Items.Add("غشت");
            c2.Items.Add("سبتمبر");
            c2.Items.Add("أكتوبر");
            c2.Items.Add("نونبر");
            c2.Items.Add("دجنبر"); 
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
            c1.Items.Add("1980");
            c1.Items.Add("1981");
            c1.Items.Add("1982");
            c1.Items.Add("1983");
            c1.Items.Add("1984");
            c1.Items.Add("1985");
            c1.Items.Add("1986");
            c1.Items.Add("1987");
            c1.Items.Add("1988");
            c1.Items.Add("1989");
            c1.Items.Add("1990");
            c1.Items.Add("1991");
            c1.Items.Add("1992");
            c1.Items.Add("1993");
            c1.Items.Add("1994");
            c1.Items.Add("1995");
            c1.Items.Add("1996");
            c1.Items.Add("1997");
            c1.Items.Add("1998");
            c1.Items.Add("1999");
            c1.Items.Add("2000");
            c1.Items.Add("2001");
            c1.Items.Add("2002");
            c1.Items.Add("2003");
            c1.Items.Add("2004");
            c1.Items.Add("2005");
            c1.Items.Add("2006");
            c1.Items.Add("2007");
            c1.Items.Add("2008");
            c1.Items.Add("2009");
            c1.Items.Add("2010");
            c1.Items.Add("2011");
            c1.Items.Add("2012");
            c1.Items.Add("2013");
            c1.Items.Add("2014");
            c1.Items.Add("2015");
            c1.Items.Add("2016");
            c1.Items.Add("2017");
            c1.Items.Add("2018");
            textBox3.Text = "مغربية";
            textBox9.Text = "مغربية";
            textBox4.Text = "MAROCAINE";
            textBox10.Text = "MAROCAINE";
            c10.Items.Add("فاتح");
            c10.Items.Add("ثاني");
            c10.Items.Add("ثالث");
            c10.Items.Add("رابع");
            c10.Items.Add("خامس");
            c10.Items.Add("سادس");
            c10.Items.Add("سابع");
            c10.Items.Add("ثامن");
            c10.Items.Add("تاسع");
            c10.Items.Add("عاشر");
            c10.Items.Add("الحادي عشر");
            c10.Items.Add("الثاني عشر");
            c10.Items.Add("الثالث عشر");
            c10.Items.Add("الرابع عشر");
            c10.Items.Add("الخامس عشر");
            c10.Items.Add("السادس عشر");
            c10.Items.Add("السابع عشر");
            c10.Items.Add("الثامن عشر");
            c10.Items.Add("التاسع عشر");
            c10.Items.Add("العشرين");
            c10.Items.Add("إحدى و العشرين");
            c10.Items.Add("إثنان و العشرين");
            c10.Items.Add("ثلاثة و العشرين");
            c10.Items.Add("رابع و العشرين");
            c10.Items.Add("خامس و العشرين");
            c10.Items.Add("سادس و العشرين");
            c10.Items.Add("سابع و العشرين");
            c10.Items.Add("ثامن و العشرين");
            c10.Items.Add("تاسع و العشرين");
            c10.Items.Add("الثلاثون");
            c10.Items.Add("إحدى والثلاثون");
            c7.Items.Add("فاتح");
            c7.Items.Add("ثاني");
            c7.Items.Add("ثالث");
            c7.Items.Add("رابع");
            c7.Items.Add("خامس");
            c7.Items.Add("سادس");
            c7.Items.Add("سابع");
            c7.Items.Add("ثامن");
            c7.Items.Add("تاسع");
            c7.Items.Add("عاشر");
            c7.Items.Add("الحادي عشر");
            c7.Items.Add("الثاني عشر");
            c7.Items.Add("الثالث عشر");
            c7.Items.Add("الرابع عشر");
            c7.Items.Add("الخامس عشر");
            c7.Items.Add("السادس عشر");
            c7.Items.Add("السابع عشر");
            c7.Items.Add("الثامن عشر");
            c7.Items.Add("التاسع عشر");
            c7.Items.Add("العشرين");
            c7.Items.Add("إحدى و العشرين");
            c7.Items.Add("إثنان و العشرين");
            c7.Items.Add("ثلاثة و العشرين");
            c7.Items.Add("رابع و العشرين");
            c7.Items.Add("خامس و العشرين");
            c7.Items.Add("سادس و العشرين");
            c7.Items.Add("سابع و العشرين");
            c7.Items.Add("ثامن و العشرين");
            c7.Items.Add("تاسع و العشرين");
            c7.Items.Add("الثلاثون");
            c7.Items.Add("إحدى والثلاثون");
            c3.Items.Add("1");
            c3.Items.Add("2");
            c3.Items.Add("3");
            c3.Items.Add("4");
            c3.Items.Add("5");
            c3.Items.Add("6");
            c3.Items.Add("7");
            c3.Items.Add("8");
            c3.Items.Add("9");
            c3.Items.Add("10");
            c3.Items.Add("11");
            c3.Items.Add("12");
            c3.Items.Add("13");
            c3.Items.Add("14");
            c3.Items.Add("15");
            c3.Items.Add("16");
            c3.Items.Add("17");
            c3.Items.Add("18");
            c3.Items.Add("19");
            c3.Items.Add("20");
            c3.Items.Add("21");
            c3.Items.Add("22");
            c3.Items.Add("23");
            c3.Items.Add("24");
            c3.Items.Add("25");
            c3.Items.Add("26");
            c3.Items.Add("27");
            c3.Items.Add("29");
            c3.Items.Add("30");
            c3.Items.Add("31");
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
            c8.Items.Add("محرم");
            c8.Items.Add("صفر");
            c8.Items.Add("ربيع الأول");
            c8.Items.Add("ربيع الثاني");
            c8.Items.Add("جمادى الأولى");
            c8.Items.Add("جمادى الثانية");
            c8.Items.Add("رجب");
            c8.Items.Add("شعبان");
            c8.Items.Add("رمضان");
            c8.Items.Add("شوال");
            c8.Items.Add("ذو القعدة");
            c8.Items.Add("ذو الحجة"); 
            c11.Items.Add("محرم");
            c11.Items.Add("صفر");
            c11.Items.Add("ربيع الأول");
            c11.Items.Add("ربيع الثاني");
            c11.Items.Add("جمادى الأولى");
            c11.Items.Add("جمادى الثانية");
            c11.Items.Add("رجب");
            c11.Items.Add("شعبان");
            c11.Items.Add("رمضان");
            c11.Items.Add("شوال");
            c11.Items.Add("ذو القعدة");
            c11.Items.Add("ذو الحجة"); 
            c12.Items.Add("1400");
            c12.Items.Add("1401");
            c12.Items.Add("1402");
            c12.Items.Add("1403");
            c12.Items.Add("1404");
            c12.Items.Add("1405");
            c12.Items.Add("1406");
            c12.Items.Add("1407");
            c12.Items.Add("1408");
            c12.Items.Add("1409");
            c12.Items.Add("1410");
            c12.Items.Add("1411");
            c12.Items.Add("1412");
            c12.Items.Add("1413");
            c12.Items.Add("1414");
            c12.Items.Add("1415");
            c12.Items.Add("1416");
            c12.Items.Add("1417");
            c12.Items.Add("1418");
            c12.Items.Add("1419");
            c12.Items.Add("1420");
            c12.Items.Add("1421");
            c12.Items.Add("1422");
            c12.Items.Add("1423");
            c12.Items.Add("1424");
            c12.Items.Add("1425");
            c12.Items.Add("1426");
            c12.Items.Add("1427");
            c12.Items.Add("1428");
            c12.Items.Add("1429");
            c12.Items.Add("1430");
            c12.Items.Add("1431");
            c12.Items.Add("1432");
            c12.Items.Add("1433");
            c12.Items.Add("1434");
            c12.Items.Add("1435");
            c12.Items.Add("1436");
            c12.Items.Add("1437");
            c12.Items.Add("1438");
            c12.Items.Add("1439");
            c12.Items.Add("1440");
            c9.Items.Add("1400");
            c9.Items.Add("1401");
            c9.Items.Add("1402");
            c9.Items.Add("1403");
            c9.Items.Add("1404");
            c9.Items.Add("1405");
            c9.Items.Add("1406");
            c9.Items.Add("1407");
            c9.Items.Add("1408");
            c9.Items.Add("1409");
            c9.Items.Add("1410");
            c9.Items.Add("1411");
            c9.Items.Add("1412");
            c9.Items.Add("1413");
            c9.Items.Add("1414");
            c9.Items.Add("1415");
            c9.Items.Add("1416");
            c9.Items.Add("1417");
            c9.Items.Add("1418");
            c9.Items.Add("1419");
            c9.Items.Add("1420");
            c9.Items.Add("1421");
            c9.Items.Add("1422");
            c9.Items.Add("1423");
            c9.Items.Add("1424");
            c9.Items.Add("1425");
            c9.Items.Add("1426");
            c9.Items.Add("1427");
            c9.Items.Add("1428");
            c9.Items.Add("1429");
            c9.Items.Add("1430");
            c9.Items.Add("1431");
            c9.Items.Add("1432");
            c9.Items.Add("1433");
            c9.Items.Add("1434");
            c9.Items.Add("1435");
            c9.Items.Add("1436");
            c9.Items.Add("1437");
            c9.Items.Add("1438");
            c9.Items.Add("1439");
            c9.Items.Add("1440");
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page_principal p = new page_principal();
            p.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            t3.Clear();
            t4.Clear();
            t5.Clear();
            t6.Clear();
            t7.Clear();
            t8.Clear();
            t9.Clear();
            t10.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnx.Open();
            if (t3.Text == "" && t4.Text == "" && t7.Text == "")
            {
                MessageBox.Show("!??المرجو ملء جميع الخانات");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into PersonneB values(N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + t3.Text + "',N'" + c10.Text + "',N'" + c11.Text + "',N'" + c12.Text + "',N'" + c3.Text + "',N'" + c2.Text + "',N'" + c1.Text + "',N'" + t5.Text + "',N'" + textBox9.Text + "',N'" + textBox10.Text + "',N'" + t4.Text + "',N'" + c7.Text + "',N'" + c8.Text + "',N'" + c9.Text + "',N'" + c6.Text + "',N'" + c5.Text + "',N'" + c4.Text + "',N'" + t6.Text + "',N'" + t7.Text + "',N'" + t8.Text + "',N'" + c13.Text + "',N'" + c14.Text + "',N'" + c15.Text + "',N'" + c16.Text + "',N'" + c17.Text + "',N'" + c18.Text + "',N'" + t9.Text + "',N'" + t10.Text + "')", cnx);
                cmd.ExecuteNonQuery();
                MessageBox.Show("!! (-_-) لقد تمت الاضافة بنجاح");
            }
            cnx.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("update PersonneB set Nationalite_ar_pr=N'" + textBox3.Text + "',Nationalite_fr_pr=N'" + textBox4.Text + "',Lieu_naiss_ar_pr=N'" + t3.Text + "',Date_N_jr_ar_p=N'" + c10.Text + "',Date_N_mo_ar_p=N'" + c11.Text+ "',Date_N_an_ar_p=N'" + c12.Text + "',Date_N_jr_fr_p=N'" + c3.Text + "',Date_N_mo_fr_p=N'" + c2.Text + "',Date_N_an_fr_p=N'" + c1.Text + "',profession_ar_pr=N'" + t5.Text + "',Nationalite_ar_mr=N'" + textBox9.Text + "',Nationalite_fr_mr=N'" + textBox10.Text + "',Lieu_naiss_ar_mr=N'" + t4.Text + "',Date_N_jr_ar_m=N'" + c7.Text + "',Date_N_mo_ar_m=N'" + c8.Text + "',Date_N_an_ar_m=N'" + c9.Text + "',Date_N_jr_fr_m=N'" + c6.Text + "',Date_N_mo_fr_m=N'" + c5.Text + "',Date_N_an_fr_m=N'" + c4.Text + "',profession_ar_mr=N'" + t6.Text + "',Domiciles_ar=N'" + t7.Text + "',Declaration_ar=N'" + t8.Text + "',Date_drs_fr_j=N'" + c13.Text + "',Date_drs_fr_mo=N'" + c14.Text + "',Date_drs_fr_an=N'" + c15.Text + "',Date_drs_ar_j=N'" + c16.Text + "',Date_drs_ar_mo=N'" + c17.Text + "',Date_drs_ar_an=N'" + c18.Text + "',Officier_etat_civil_ar=N'" + t9.Text + "',Hamich_ar=N'" + t10.Text + "'where Num_Acte='" + textBox1.Text+"'", cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("!! (-_-) لقد تم التعديل بنجاح");
            cnx.Close(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Select * from PersonneB where Num_Acte='"+textBox1.Text+"'",cnx);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                textBox1.Text = dr["Num_Acte"].ToString();
                textBox3.Text = dr["Nationalite_ar_pr"].ToString();
                textBox4.Text = dr["Nationalite_fr_pr"].ToString();
                t3.Text = dr["Lieu_naiss_ar_pr"].ToString();
                c10.Text = dr["Date_N_jr_ar_p"].ToString();
                c11.Text = dr["Date_N_mo_ar_p"].ToString();
                c12.Text = dr["Date_N_an_ar_p"].ToString();
                c3.Text = dr["Date_N_jr_fr_p"].ToString();
                c2.Text = dr["Date_N_mo_fr_p"].ToString();
                c1.Text = dr["Date_N_an_fr_p"].ToString();
                t5.Text = dr["profession_ar_pr"].ToString();
                t9.Text = dr["Nationalite_ar_mr"].ToString();
                t10.Text = dr["Nationalite_fr_mr"].ToString();
                t4.Text = dr["Lieu_naiss_ar_mr"].ToString();
                c7.Text = dr["Date_N_jr_ar_m"].ToString();
                c8.Text = dr["Date_N_mo_ar_m"].ToString();
                c9.Text = dr["Date_N_an_ar_m"].ToString();
                c6.Text = dr["Date_N_jr_fr_m"].ToString();
                c5.Text = dr["Date_N_mo_fr_m"].ToString();
                c4.Text = dr["Date_N_an_fr_m"].ToString();
                t6.Text = dr["profession_ar_mr"].ToString();
                t7.Text = dr["Domiciles_ar"].ToString();
                t8.Text = dr["Declaration_ar"].ToString();
                c13.Text = dr["Date_drs_fr_j"].ToString();
                c14.Text = dr["Date_drs_fr_mo"].ToString();
                c15.Text = dr["Date_drs_fr_an"].ToString();
                c16.Text = dr["Date_drs_ar_j"].ToString();
                c17.Text = dr["Date_drs_ar_mo"].ToString();
                c18.Text = dr["Date_drs_ar_an"].ToString();
                t9.Text = dr["Officier_etat_civil_ar"].ToString();
                t10.Text = dr["Hamich_ar"].ToString();
            }
            cnx.Close();
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
