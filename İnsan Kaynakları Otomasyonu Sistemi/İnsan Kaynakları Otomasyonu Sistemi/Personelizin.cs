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
    public partial class Personelizin : Form
    {
        SQL c = new SQL();
        public Personelizin()
        {
            InitializeComponent();
        }
        

        private void btnizinTurleri_Click(object sender, EventArgs e)
        {
            Personelizintur sayfa = new Personelizintur();
            sayfa.Show();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
                SqlCommand komut = new SqlCommand("insert into izin (ad,izintur,izinbas,izinbit,açıklama) values(@p1,@p2,@p3,@p4,@p5)", c.Sql());

                komut.Parameters.AddWithValue("@p1", comboPersonelAdsoyad.Text);
                komut.Parameters.AddWithValue("@p2", comboizinTuru.Text);
                komut.Parameters.AddWithValue("@p3", dateTimeBaslangic.Value.Date);
                komut.Parameters.AddWithValue("@p4", dateTimeBitis.Value.Date);
                komut.Parameters.AddWithValue("@p5", txtAciklama.Text);
                
                int i = komut.ExecuteNonQuery();


                if (i != 0)
                {
                    MessageBox.Show("İzin Başarıyla Eklendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                    MessageBox.Show("Hata!! Lütfen Bilgileri eksiksiz giriniz.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            

            GetPersonel();
            c.Sql().Close();
        }

        private void Personelizin_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From izintur", c.Sql());
            SqlDataReader reader = komut.ExecuteReader();


            while (reader.Read())
            {
                comboizinTuru.Items.Add(reader["izinTuru"]);
            }
            GetPersonel();
           

            SqlCommand komut1 = new SqlCommand("Select * From Personeller", c.Sql());
            SqlDataReader reader1 = komut1.ExecuteReader();
            while (reader1.Read())
            {
                comboPersonelAdsoyad.Items.Add(reader1["Adi"] + " " + reader1["Soyadi"]);

            }



        }
        
        void GetPersonel()
        {
            // TODO: Bu kod satırı 'izinler.izin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.izinTableAdapter.Fill(this.izinler.izin);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
                 txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                 comboPersonelAdsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboizinTuru.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimeBaslangic.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimeBitis.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
 
          


            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
                SqlCommand komut = new SqlCommand("Update izin Set ad=@p1,izintur=@p2,izinbas=@p3,izinbit=@p4,açıklama=@p5 Where id=@id", c.Sql());
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                komut.Parameters.AddWithValue("@p1", comboPersonelAdsoyad.Text);
                komut.Parameters.AddWithValue("@p2", comboizinTuru.Text);
                komut.Parameters.AddWithValue("@p3", dateTimeBaslangic.Value.Date);
                komut.Parameters.AddWithValue("@p4", dateTimeBitis.Value.Date);
                komut.Parameters.AddWithValue("@p5", txtAciklama.Text);
                int i = komut.ExecuteNonQuery();


                if (i != 0)
                {
                MessageBox.Show("İzin Başarıyla Güncellendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                    MessageBox.Show("Hata!! Lütfen Bilgileri eksiksiz giriniz.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            

            GetPersonel();
            c.Sql().Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete From izin Where id=@id", c.Sql());
            command.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
            int i = command.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Kayıt Silindi", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hata!!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            GetPersonel();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        private void comboizinTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboizinTuru_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

    



