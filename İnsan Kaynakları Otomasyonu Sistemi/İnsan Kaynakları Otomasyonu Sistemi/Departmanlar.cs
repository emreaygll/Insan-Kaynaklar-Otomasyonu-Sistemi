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
    public partial class Departmanlar : Form

    {
        SQL c = new SQL();
        public Departmanlar()
        {
            InitializeComponent();
        }

       

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
                SqlCommand komut = new SqlCommand("insert into Departman (Departman,Aciklama) values(@p2,@p3)", c.Sql());

               
                komut.Parameters.AddWithValue("@p2", Departman.Text);
                komut.Parameters.AddWithValue("@p3", Aciklama.Text);
               
                int i = komut.ExecuteNonQuery();


                if (i != 0)
                {
                MessageBox.Show("Başarıyla Eklendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                {
                MessageBox.Show("Hata!! Lütfen Bilgilerinizi Eksiksiz Giriniz.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }



            GetDepartman();
            c.Sql().Close();
        }

        private void Departmanlar_Load(object sender, EventArgs e)
        {
           

            GetDepartman();

        }
        void GetDepartman()
        {
            // TODO: Bu kod satırı 'departmans.Departman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmanTableAdapter.Fill(this.departmans.Departman);


        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DepartmanID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            Departman.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Aciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Departman Where Departman=@Departman", c.Sql());
            komut.Parameters.AddWithValue("@Departman", Departman.Text);
            int i = komut.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Kayıt Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hata!!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            GetDepartman();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
                SqlCommand komut = new SqlCommand("Update Departman Set Departman=@p1,Aciklama=@p2 Where DepartmanID=@DepartmanID", c.Sql());
                komut.Parameters.AddWithValue("@DepartmanID", Convert.ToInt32(DepartmanID.Text));
                komut.Parameters.AddWithValue("@p1", Departman.Text);
                komut.Parameters.AddWithValue("@p2", Aciklama.Text);
                
                int i = komut.ExecuteNonQuery();

                if (i != 0)
                {
                MessageBox.Show("Liste Başarıyla güncellendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            c.Sql().Close();
            GetDepartman();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }

       
    }
}




