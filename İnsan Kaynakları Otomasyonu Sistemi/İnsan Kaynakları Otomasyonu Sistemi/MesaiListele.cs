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
    public partial class MesaiListele : Form
    {
        SQL c = new SQL();
        public MesaiListele()
        {
            InitializeComponent();
        }
        void GetMesai()
        {
            
            this.mesaiTableAdapter.Fill(this.mesailer.Mesai);

        }
        private void MesaiListele_Load(object sender, EventArgs e)
        {
           
            GetMesai();
            SqlCommand komut1 = new SqlCommand("Select * From Personeller", c.Sql());
            SqlDataReader reader1 = komut1.ExecuteReader();
            while (reader1.Read())
            {
                comboPersonelAdsoyad.Items.Add(reader1["Adi"] );

            }

            dateTimeBaslangic.Format = DateTimePickerFormat.Custom;
            dateTimeBaslangic.CustomFormat = "dd/MM/yyyy HH:mm ";

            dateTimeBitis.Format = DateTimePickerFormat.Custom;
            dateTimeBitis.CustomFormat = "dd/MM/yyyy HH:mm ";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                
                }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMesaiID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboPersonelAdsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimeBaslangic.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimeBitis.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtMesaiSaatUcreti.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtTutar.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            label8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnMesaiOde_Click(object sender, EventArgs e)
        {
            
            if (label8.Text == "Ödendi")
            {
                MessageBox.Show("Bir Kayıt İçin Sadece Bir Kere Ödeme Yapabilirsiniz.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
            
                try
                {
                SqlCommand komut = new SqlCommand(" update Personeller set maas=maas+'" + txtTutar.Text + "'  where PersonelID= '" + Convert.ToInt16(textBox1.Text) + "'", c.Sql());
                SqlCommand komut1 = new SqlCommand("update Mesai set Odenme='" + "Ödendi" + "' where MesaiID='" + txtMesaiID.Text + "'", c.Sql());
                    komut1.ExecuteNonQuery();

                int i = komut.ExecuteNonQuery();


                    if (i != 0)
                    {
                        MessageBox.Show("Mesai Ödendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch
                {

                }
            }


            GetMesai();
            c.Sql().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
                SqlCommand komut = new SqlCommand("Update Mesai Set adsoyad=@p1,saatbas=@p2,saatbit=@p3,mesaiucret=@p4,tutar=@p5,aciklama=@p6 Where mesaiid=@mesaiid", c.Sql());
                komut.Parameters.AddWithValue("@mesaiid", Convert.ToInt32(txtMesaiID.Text));
                komut.Parameters.AddWithValue("@p1", comboPersonelAdsoyad.Text);
                komut.Parameters.AddWithValue("@p2", dateTimeBaslangic.Text);
                komut.Parameters.AddWithValue("@p3", (dateTimeBitis.Text));
                komut.Parameters.AddWithValue("@p4", txtMesaiSaatUcreti.Text);
                komut.Parameters.AddWithValue("@p5", txtTutar.Text);
                komut.Parameters.AddWithValue("@p6", txtAciklama.Text);
         
                int i = komut.ExecuteNonQuery();


                if (i != 0)
                {
                MessageBox.Show("Mesai Kaydı Güncellendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
           

            GetMesai();
            c.Sql().Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete From Mesai Where mesaiid=@mesaiid", c.Sql());
            command.Parameters.AddWithValue("@mesaiid", Convert.ToInt32(txtMesaiID.Text));
            int i = command.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Kayıt Silindi", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            



            GetMesai();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            Hide();
            this.Close();
        }

        private void btnTumMesaileriOde_Click(object sender, EventArgs e)
        {
             
                SqlCommand komut = new SqlCommand("update Mesai set Odenme='" + "ödendi" + "' where Odenme='" + "ödenmedi" + "'", c.Sql()); ;
                
                int i = komut.ExecuteNonQuery();


                if (i != 0)
                {
                    MessageBox.Show("Mesai Ödendi", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               
           

            GetMesai();
            c.Sql().Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMesaiID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeBitis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeBaslangic_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void mesaiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboPersonelAdsoyad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

      
    }
}
