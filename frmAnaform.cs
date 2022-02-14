using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PANSİYON_KAYIT_UYGULAMASI
{
    public partial class frmAnaform : Form
    {
        public frmAnaform()
        {
            InitializeComponent();
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            frmAdminGiris fr = new frmAdminGiris(); 
            fr.ShowDialog();    
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmYeniMusteri fr = new frmYeniMusteri();
            fr.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmOdalar fr = new frmOdalar();
            fr.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriler fr = new frmMusteriler(); 
            fr.ShowDialog();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayçiçeği Pansiyon Kayıt Uygulaması /07.01.2022/ANTALYA");
        }

        

        private void frmAnaform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGelirGider fr = new frmGelirGider();
            fr.ShowDialog();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmStoklar fr = new frmStoklar();
            fr.ShowDialog();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmRadyoDinle fr = new frmRadyoDinle();
            fr.ShowDialog();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmGazete fr = new frmGazete();
            fr.ShowDialog();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmGuncelle fr = new frmGuncelle();
            fr.ShowDialog();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMusteriMesajlari fr = new frmMusteriMesajlari();
            fr.ShowDialog();
            this.Hide();

        }
    }
}
