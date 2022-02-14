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
    public partial class frmYeniMusteri : Form
    {
        public frmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=192.168.2.160\\ATHENA;Initial Catalog=PANSİYON;Integrated Security=True");
        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Gösterir.");
        }

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir.");
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime buyukTarih = Convert.ToDateTime(dtpCikisTarihi.Text);

            TimeSpan sonuc;
            sonuc = buyukTarih - kucukTarih;
            label11.Text = sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(label11.Text)*50;
            txtUcret.Text = ucret.ToString();



        }

        private void btnKaydet_Click(object sender, EventArgs e)
           
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TCKimlikNo,OdaNo,Ucret,GirisTarihi,CikisTarihi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + cmbCinsiyet.Text + "','"+mskTxtTelefon.Text+"','"+txtMail.Text+"','"+txtTCKimlikNo.Text+"','"+txtOdaNo.Text+"','"+txtUcret.Text+"','"+dtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"','"+dtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("MÜŞTERİ KAYDI YAPILDI");
            
            
        }

        private void btnKayıtTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            cmbCinsiyet.Text = "";
            mskTxtTelefon.Clear();
            txtMail.Clear();
            txtTCKimlikNo.Clear();
            txtOdaNo.Clear();
            txtUcret.Clear();
            dtpCikisTarihi.Text = "";
            dtpGirisTarihi.Text = "";
        }

        private void frmYeniMusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select*from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btnOda101.Text = oku1["Adi"].ToString() + "" + oku1["Soyadi"].ToString();

            }
            baglanti.Close();
            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor = Color.Red;
                btnOda101.Enabled = false;
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
                btnOda102.Enabled = false;
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
                btnOda103.Enabled = false;
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
                btnOda107.Enabled = false;
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
                btnOda109.Enabled = false;
            }
        }

        
    }
}
