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
    public partial class frmGuncelle : Form
    {
        public frmGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESTEK25\ATHENA;Initial Catalog=PANSİYON;Integrated Security=True");
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + txtKullanici2.Text + "',Sifre='" + txtSifre2.Text +"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
        }
    
    }
}
