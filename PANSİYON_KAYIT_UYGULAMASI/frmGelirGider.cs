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
    public partial class frmGelirGider : Form
    {
        public frmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=192.168.2.160\\ATHENA;Initial Catalog=PANSİYON;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {

            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            lblPersonelMaas.Text = (personel * 1500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(lblKasaToplam.Text)-(Convert.ToInt32(lblPersonelMaas.Text)+Convert.ToInt32(lblAlinanUrunler1.Text)+Convert.ToInt32(lblAlinanUrunler2.Text)+Convert.ToInt32(lblAlinanUrunler3.Text)+Convert.ToInt32(lblFatura1.Text)+Convert.ToInt32(lblFatura2.Text)+Convert.ToInt32(lblFatura3.Text));
            lblSonuc.Text = sonuc.ToString();

        }

        private void frmGelirGider_Load(object sender, EventArgs e)
        {
            // kasadaki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as Toplam from MusteriEkle ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasaToplam.Text = oku["Toplam"].ToString();

            }
            baglanti.Close();
            //Stokların giderleri
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gida) as Toplam1 from Stoklar ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblAlinanUrunler1.Text = oku2["Toplam1"].ToString();

            }
            baglanti.Close();


            
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(İcecek) as Toplam2 from Stoklar ", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblAlinanUrunler2.Text = oku3["Toplam2"].ToString();

            }
            baglanti.Close();

          
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as Toplam3 from Stoklar ", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblAlinanUrunler3.Text = oku4["Toplam3"].ToString();

            }
            baglanti.Close();

            //Elektrik
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektrik) as Toplam4 from Faturalar ", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblFatura1.Text = oku5["Toplam4"].ToString();

            }
            baglanti.Close();


            //su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as Toplam5 from Faturalar ", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblFatura2.Text = oku6["Toplam5"].ToString();

            }
            baglanti.Close();

            //İnternet
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(İnternet) as Toplam6 from Faturalar ", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblFatura3.Text = oku7["Toplam6"].ToString();

            }
            baglanti.Close();

        }
    }
}
