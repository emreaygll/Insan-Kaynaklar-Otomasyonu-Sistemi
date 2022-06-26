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
    public partial class Kayıt : Form
    {
        SQL c = new SQL();

        public Kayıt()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                if (!string.IsNullOrEmpty(kullainiciAd.Text) && !string.IsNullOrEmpty(kullaniciSifre.Text))
                {

                    SqlCommand komut = new SqlCommand("insert into [Kullanicilar] (kullainiciAd,kullaniciSifre) values(@p1,@p2)", c.Sql());
                    komut.Parameters.AddWithValue("@p1", kullainiciAd.Text);
                    komut.Parameters.AddWithValue("@p2", kullaniciSifre.Text);
                    if (kullaniciSifre.Text.Equals(kullaniciSifre2.Text))
                    {
                        int i = komut.ExecuteNonQuery();

                        if (i != 0)
                        {
                        MessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                    }
                    else
                    {
                    MessageBox.Show("Şifreler eşleşmiyor.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                }
                else
                {
                MessageBox.Show("Lütfen kullanıcı adı ve parolayı giriniz.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            Login sayfa = new Login();
            sayfa.Show();
            Hide();
        }

      

        

        private void Login_Load(object sender, EventArgs e)
        {
            guna2Panel1.FillColor = Color.FromArgb(100, 0, 0, 0);
            guna2ControlBox1.FillColor = Color.FromArgb(100, 0, 0, 0);
            
        }

        private void kullaniciSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void SifreGoster_CheckedChanged(object sender, EventArgs e)
        {
           
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

        private void kullainiciAd_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from [Kullanicilar]  where kullainiciAd=@p1 ", c.Sql());
            komut.Parameters.AddWithValue("@p1", kullainiciAd.Text);




            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                MessageBox.Show("Kullaanıcı Adı Kullanılıyor.", "Bilgilendirme Mesaajı", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
            {
                
            }
            c.Sql();
        }
    }
}
