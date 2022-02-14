using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PANSİYON_KAYIT_UYGULAMASI
{
    public partial class frmOdalar : Form
    {
        public frmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti =new SqlConnection("Data Source=192.168.2.160\\ATHENA;Initial Catalog=PANSİYON;Integrated Security=True");
        private void frmOdalar_Load(object sender, EventArgs e)
        { 
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select*from Oda101",baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btnOda101.Text = oku1["Adi"].ToString() +""+ oku1["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select*from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btnOda102.Text = oku2["Adi"].ToString() + "" + oku2["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select*from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btnOda103.Text = oku3["Adi"].ToString() + "" + oku3["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Red;
            }




            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select*from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                btnOda107.Text = oku7["Adi"].ToString() + "" + oku7["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Red;
            }



            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select*from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                btnOda109.Text = oku9["Adi"].ToString() + "" + oku9["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Red;
            }

        }
    }
}
