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
    public partial class Personelizintur : Form

    {
        SQL c = new SQL();
        public Personelizintur()
        {
            InitializeComponent();
        }

       
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
                SqlCommand komut = new SqlCommand("insert into izintur (izinTuru) values(@p1)", c.Sql());

               
                komut.Parameters.AddWithValue("@p1", txtizin.Text);
               
                int i = komut.ExecuteNonQuery();


                if (i != 0)
                {
                MessageBox.Show("Başarıyla Eklendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




            Getizin();
            c.Sql().Close();
        }

        private void Departmanlar_Load(object sender, EventArgs e)
        {
          
            Getizin();

        }

        void Getizin()
        {
            // TODO: Bu kod satırı 'izinturleri.izintur' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.izinturTableAdapter.Fill(this.izinturleri.izintur);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            izinİD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtizin.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete From izintur Where izinTurID=@izinTurID", c.Sql());
            command.Parameters.AddWithValue("@izinTurID", izinİD.Text);
            int i = command.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Kayıt Silindi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




            Getizin();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
                SqlCommand command = new SqlCommand("Update izintur Set izinTuru=@p1 Where izinTurID=@izinTurID", c.Sql());
                command.Parameters.AddWithValue("@izinTurID", Convert.ToInt32(izinİD.Text));
                command.Parameters.AddWithValue("@p1", txtizin.Text);
               
                
                int i = command.ExecuteNonQuery();

                if (i != 0)
                {
                MessageBox.Show("Başarıyla Güncellendi.", "Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            c.Sql().Close();
            Getizin();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
           
            Hide();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}




