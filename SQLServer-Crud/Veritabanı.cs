using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_Crud
{
    class Veritabanı
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catolog=DBSirket;Integrated Security=True");
    }
}
