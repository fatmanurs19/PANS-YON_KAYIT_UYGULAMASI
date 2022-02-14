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
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=192.168.2.160\\ATHENA;Initial Catalog=PANSİYON;Integrated Security=True");
            try
            {
                baglanti.Open();
                string sql = "select*from AdminGiris where Kullanici=@Kullaniciadi AND Sifre=@Sifre";
                SqlParameter prm1 = new SqlParameter("Kullaniciadi",txtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifre",txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
               

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    frmAnaform fr = new frmAnaform();   
                    fr.ShowDialog();  
                    this.Hide();

                   
                }


            }
            catch (Exception)
            {

                MessageBox.Show("HATALI GİRİŞ!");
            }
        }
    }
}
