using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace İnsan_Kaynakları_Otomasyonu_Sistemi
{
    public partial class Login : Form
    {
        SQL c = new SQL();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kullainiciAd.Text) && !string.IsNullOrEmpty(kullaniciSifre.Text))
            {
                SqlCommand komut = new SqlCommand("Select * From [Kullanicilar] where kullainiciAd=@p1 and kullaniciSifre=@p2", c.Sql());
                komut.Parameters.AddWithValue("@p1", kullainiciAd.Text);
                komut.Parameters.AddWithValue("@p2", kullaniciSifre.Text);
                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    Anasayfa sayfa = new Anasayfa();
                    sayfa.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış.Lütfen Tekrar Deneyiniz.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                kullainiciAd.Select();
                MessageBox.Show("Lütfen kullanıcı adı ve parolayı giriniz.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            Kayıt sayfa = new Kayıt();
            sayfa.Show();
            Hide();
        }

      

        

        private void Login_Load(object sender, EventArgs e)
        {
            kullaniciSifre.UseSystemPasswordChar = true;
            guna2Panel1.FillColor = Color.FromArgb(100, 0, 0, 0);
            guna2ControlBox1.FillColor = Color.FromArgb(100, 0, 0, 0);
            
        }

        private void kullaniciSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void SifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (SifreGoster.Checked)
            {
                kullaniciSifre.UseSystemPasswordChar = false;
            }
            else
            {
                kullaniciSifre.UseSystemPasswordChar = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
