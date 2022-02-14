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
    public partial class frmMusteriMesajlari : Form
    {
        public frmMusteriMesajlari()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESTEK25\ATHENA;Initial Catalog=PANSİYON;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(AdSoyad,Mesaj) values('"+textBox1.Text+"','"+richTextBox1.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void frmMusteriMesajlari_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
        
        }
    }
}
