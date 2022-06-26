using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnsan_Kaynakları_Otomasyonu_Sistemi
{
    public partial class PersonelZam : Form
    {
        SQL c = new SQL();
        public PersonelZam()
        {
            InitializeComponent();
            comboPersoneller.SelectedIndex = 0;
            radioYuzde.Checked = true;
        }

        private void PersonelZam_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Personeller", c.Sql());
            SqlDataReader reader = komut.ExecuteReader();


            while (reader.Read())
            {
                comboPersoneller.Items.Add(reader["Adi"]);
            }
        }
        private void radioYuzde_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void radioFiyat_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
           
            

            if (radioYuzde.Checked)
            {
               if (comboPersoneller.SelectedIndex==0)
                {
                    int i = (int)numericUpDown1.Value;
                    SqlCommand komut = new SqlCommand(" update Personeller set maas=maas+(maas*'" + i + "')/100", c.Sql());
                    int a = komut.ExecuteNonQuery();
                    if (a != 0)
                    {
                        MessageBox.Show("Tüm Personellere Zam Eklenildi." + numericUpDown1.Text, "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                    {
                        MessageBox.Show("Hata!!!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
               else
                {
                    int i = (int)numericUpDown1.Value;
                    SqlCommand komut1 = new SqlCommand("update Personeller set maas = maas + (maas * '" + i + "') / 100 where PersonelID= '" + label6.Text +"'", c.Sql());
                    int a1 = komut1.ExecuteNonQuery();
                    if (a1 != 0)
                    {
                        MessageBox.Show(comboPersoneller.Text +" " +combosoyad.Text + " %"+numericUpDown1.Text  + " Zam Eklenildi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            if (radioFiyat.Checked)
            {
                if (comboPersoneller.SelectedIndex == 0)
                {
                    int y = Convert.ToInt32(txtFiyat.Text);
                    SqlCommand komut = new SqlCommand(" update Personeller set maas=maas+'" + y + "'" , c.Sql());
                    int a = komut.ExecuteNonQuery();
                    if (a != 0)
                    { 
                        MessageBox.Show(txtFiyat.Text+" TL"+"Tüm Personellere Zam Eklenildi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                    
                   
                }
            else
                {
                    int y = Convert.ToInt32(txtFiyat.Text);
                    SqlCommand komut = new SqlCommand(" update Personeller set maas=maas+'" + y + "'  where PersonelID= '" + label6.Text + "'", c.Sql());
                    int a = komut.ExecuteNonQuery();
                    if (a != 0)
                    {
                        MessageBox.Show(comboPersoneller.Text+" " +combosoyad.Text+" " + txtFiyat.Text +" TL" + " Zam Eklenildi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

        private void radioFiyat_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void comboPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Personeller where Adi=@PersonelID", c.Sql());
            komut.Parameters.AddWithValue("@PersonelID", comboPersoneller.Text);
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
                combosoyad.Text = reader1["Soyadi"].ToString();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void combosoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}