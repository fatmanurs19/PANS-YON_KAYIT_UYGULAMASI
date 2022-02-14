﻿using System;
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
    public partial class frmStoklar : Form
    {
        public frmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=192.168.2.160\\ATHENA;Initial Catalog=PANSİYON;Integrated Security=True");
         

         private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar ",baglanti);
            SqlDataReader oku = komut.ExecuteReader();  
            while(oku.Read())
            {
               ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add (oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);


            } 
            baglanti.Close();
        }
        private void veriler2()

        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);


            }
            baglanti.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar (Gida,İcecek,Cerezler) values ('" + txtGida.Text + "','" + txtİcecek.Text + "','" + txtAtistirmalik.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void frmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();

        }

        private void btnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar (Elektrik,Su,İnternet) values ('" + txtElektrik.Text + "','" + txtSu.Text + "','" + txtİnternet.Text + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
