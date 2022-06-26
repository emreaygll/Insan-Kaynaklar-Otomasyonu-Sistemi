using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace İnsan_Kaynakları_Otomasyonu_Sistemi
{
    class SQL
    {
        public SqlConnection Sql()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HLIBU6G;Integrated Security=SSPI;Initial Catalog=insan_kaynak123");
            baglanti.Open();
            return baglanti;
        }
    }
}
