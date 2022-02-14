using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PANSİYON_KAYIT_UYGULAMASI
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESTEK25\ATHENA;Initial Catalog=PANSİYON;Integrated Security=True");


        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TCKimlikNo"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id=int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTCKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpCikisTarihi.Text= listView1.SelectedItems[0].SubItems[10].Text;


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where MusteriID=("+id+")",baglanti);
            komut.ExecuteNonQuery();    
            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='" + txtAdi.Text + "',Soyadi='" + txtSoyadi.Text + "',Cinsiyet='" + cmbCinsiyet.Text + "',Telefon='" + mskTxtTelefon.Text + "',Mail='" + txtMail.Text + "',TCKimlikNo='" + txtTCKimlikNo.Text + "',OdaNo='" + txtOdaNo.Text + "',Ucret='" + txtUcret.Text + "',GirisTarihi='"+dtpGirisTarihi.Value.ToString("yyyy-MM-dd")+"',CikisTarihi='"+dtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"' where MusteriID="+id+"", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from MusteriEkle where Adi like '%"+textBox1.Text+"%'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TCKimlikNo"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();


        }
    }
}
