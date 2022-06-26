using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnsan_Kaynakları_Otomasyonu_Sistemi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        

        private void btn_show_Click_1(object sender, EventArgs e)
        {
            //guna2PictureBox1.Visible = true;
            btn_show.Visible = false;
            btn_hide.Visible = true;
            guna2Panel1.Visible = false;
            guna2Panel1.Width = 237;
            guna2Transition1.ShowSync(guna2Panel1);
        }

        private void btn_hide_Click_1(object sender, EventArgs e)
        {
            //guna2PictureBox1.Visible = false;
            guna2Panel1.Visible = false;
            btn_hide.Visible = false;
            btn_show.Visible = true;
            guna2Panel1.Width = 57;
            guna2Transition1.ShowSync(guna2Panel1);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {

        }

        private void btn_hide_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Departmanlar sayfa = new Departmanlar();
            sayfa.Show();
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            PersonelEkle sayfa = new PersonelEkle();
            sayfa.Show();
            
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            PersonelListele sayfa = new PersonelListele();
            sayfa.Show();
            
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            PersonelZam sayfa = new PersonelZam();
            sayfa.Show();
           
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            MesaiEkle sayfa = new MesaiEkle();
            sayfa.Show();
           
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            MesaiListele sayfa = new MesaiListele();
            sayfa.Show();
           
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            Personelizin sayfa = new Personelizin();
            sayfa.Show();
           
        }
    }
}
