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
    public partial class MesaiEkle : Form
    {
        public MesaiEkle()
        {
            InitializeComponent();
        }
        SQL c = new SQL();
        private void MesaiEkle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Personeller", c.Sql());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                comboPersonelAdsoyad.Items.Add(reader["Adi"]);
               // comboBox1.Items.Add(reader["Soyadi"]);
            }
            dateTimeBaslangic.Format = DateTimePickerFormat.Custom;
            dateTimeBaslangic.CustomFormat = "dd/MM/yyyy HH:mm ";

            dateTimeBitis.Format = DateTimePickerFormat.Custom;
            dateTimeBitis.CustomFormat = "dd/MM/yyyy HH:mm ";

           
        }
        

        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            
                SqlCommand komut = new SqlCommand("insert into Mesai (PersonelID,adsoyad,saatbas,saatbit,mesaiucret,tutar,aciklama,Odenme) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", c.Sql());

                komut.Parameters.AddWithValue("@p1", label6.Text);
                komut.Parameters.AddWithValue("@p2", label8.Text);
                komut.Parameters.AddWithValue("@p3", dateTimeBaslangic.Text);
                komut.Parameters.AddWithValue("@p4", dateTimeBitis.Text);
                komut.Parameters.AddWithValue("@p5", txtMesaiSaatUcreti.Text);
                komut.Parameters.AddWithValue("@p6", txtTutar.Text);
                komut.Parameters.AddWithValue("@p7", txtAciklama.Text);
                komut.Parameters.AddWithValue("@p8", "Ödenmedi");
                komut.ExecuteNonQuery();

                c.Sql().Close();


            MessageBox.Show("Mesai Başarıyla Eklendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);







        }

        private void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            string baslangic = dateTimeBaslangic.Text;
            string bitis = dateTimeBitis.Text;
            TimeSpan saatfarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
            double MSaatUcreti = Convert.ToDouble(txtMesaiSaatUcreti.Text);
            double tutar = saatfarki.TotalHours * MSaatUcreti;
            txtTutar.Text = tutar.ToString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        private void comboPersonelAdsoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Personeller where Adi=@PersonelID", c.Sql());
            komut.Parameters.AddWithValue("@PersonelID", comboPersonelAdsoyad.Text);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
               label6.Text = reader["PersonelID"].ToString();

            }
            SqlCommand komut1 = new SqlCommand("Select * From Personeller where PersonelID=@PersonelID", c.Sql());
            komut1.Parameters.AddWithValue("@PersonelID", label6.Text);
            SqlDataReader reader1 = komut1.ExecuteReader();
            while (reader1.Read())
            {
                comboBox1.Text = reader1["Soyadi"].ToString();

            }
            label8.Text = comboPersonelAdsoyad.Text + " " + comboBox1.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
    }

