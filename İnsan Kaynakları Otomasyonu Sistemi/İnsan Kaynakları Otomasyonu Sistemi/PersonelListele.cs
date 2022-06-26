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
    public partial class PersonelListele : Form
    {
        SQL c = new SQL();
        public PersonelListele()
        {
            InitializeComponent();
        }

        void GetPersonel()
        {
            // TODO: Bu kod satırı 'perosnel.Personeller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personellerTableAdapter.Fill(this.perosnel.Personeller);
        }

     

        private void PersonelListele_Load(object sender, EventArgs e)
        {
            GetPersonel();
            // TODO: Bu kod satırı 'peroneller.Personeller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            SqlCommand komut = new SqlCommand("Select * From Departman", c.Sql());
            SqlDataReader reader = komut.ExecuteReader();


            while (reader.Read())
            {
                comboDepartman.Items.Add(reader["Departman"]);
            }
           
        }

        private void txtPersonelAdAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter aramayap1 = new SqlDataAdapter("select * from [Personeller] where [Adi] like '%" + txtPersonelAdAra.Text + "%'", c.Sql());
            aramayap1.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        private void txtPersonelSoyadAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter aramayap1 = new SqlDataAdapter("select * from [Personeller] where [Soyadi] like '%" + txtPersonelSoyadAra.Text + "%'", c.Sql());
            aramayap1.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        private void txtTelefonAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter aramayap1 = new SqlDataAdapter("select * from [Personeller] where [Telefon] like '%" + txtTelefonAra.Text + "%'", c.Sql());
            aramayap1.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        private void txtPersonelIDAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter aramayap1 = new SqlDataAdapter("select * from [Personeller] where [PersonelID] like '%" + txtPersonelIDAra.Text + "%'", c.Sql());
            aramayap1.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        private void dateTimePickerG_Tarihi_ValueChanged(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter aramayap1 = new SqlDataAdapter("select * from [Personeller] where [GirisTarihi] like '%" + dateTimePickerG_Tarihi.Text + "%'", c.Sql());
            aramayap1.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete From Personeller Where PersonelID=@PersonelID", c.Sql());
            command.Parameters.AddWithValue("@PersonelID", Convert.ToInt32(PersonelID.Text));
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
        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            PersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboDepartman.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtMaasi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateTimePickerGirisTarihi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtis.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

           
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close(); ;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
                SqlCommand komut = new SqlCommand("Update Personeller Set Adi=@p1,Soyadi=@p2,Telefon=@p3,Adres=@p4,Email=@p5,Departman=@p6,Maas=@p7,GirisTarihi=@p8,İs=@p9 Where PersonelID=@PersonelID", c.Sql());
                komut.Parameters.AddWithValue("@PersonelID", Convert.ToInt32(PersonelID.Text));
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
                MessageBox.Show("Personel Başarıyla Güncellendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           

            GetPersonel();
            c.Sql().Close();
        }

       
    }
}
