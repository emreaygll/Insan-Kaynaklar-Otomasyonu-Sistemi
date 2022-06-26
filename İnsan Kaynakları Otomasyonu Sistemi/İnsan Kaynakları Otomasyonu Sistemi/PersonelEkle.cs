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
    public partial class PersonelEkle : Form
    {
        SQL c = new SQL();
        public PersonelEkle()
        {
            InitializeComponent();
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
           
                SqlCommand komut = new SqlCommand("insert into Personeller (Adi,Soyadi,Telefon,Adres,Email,Departman,Maas,GirisTarihi,İs) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", c.Sql());

                komut.Parameters.AddWithValue("@p1", txtAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyadi.Text);
                komut.Parameters.AddWithValue("@p3", (txtTelefon.Text));
                komut.Parameters.AddWithValue("@p4", txtAdres.Text);
                komut.Parameters.AddWithValue("@p5", txtEmail.Text);
                komut.Parameters.AddWithValue("@p6", comboDepartman.Text);
                komut.Parameters.AddWithValue("@p7", txtMaasi.Text);
                komut.Parameters.AddWithValue("@p8", dateTimePickerGirisTarihi.Text);
                komut.Parameters.AddWithValue("@p9", txtis.Text);
                int i = komut.ExecuteNonQuery();


                if (i != 0)
                {
                    MessageBox.Show("Personel Başarıyla Eklendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                    MessageBox.Show("Hata!! Lütfen Bilgileri Eksiksiz Giriniz.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            

            GetPersonel();
            c.Sql().Close();
        }

        private void GetPersonel()
        {

       
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
           
            SqlCommand komut = new SqlCommand("Select * From Departman", c.Sql());
            SqlDataReader reader = komut.ExecuteReader();


            while (reader.Read())
            {
                comboDepartman.Items.Add(reader["Departman"]);
            }
       
        }

        
    }
}
