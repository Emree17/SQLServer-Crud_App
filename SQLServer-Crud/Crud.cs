using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_Crud
{
    class Crud
    {
        public static bool ESG (string sql,SqlCommand command)
        {
            if(Veritabanı.baglanti.State==ConnectionState.Closed)
            {
                Veritabanı.baglanti.Open();
            }
            command.Connection = Veritabanı.baglanti;
#pragma warning disable CS1002 // ; bekleniyor
            command.CommandText=sql
#pragma warning restore CS1002 // ; bekleniyor
            command.ExecuteNonQuery();
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Veritabanı.baglanti.Close();
            }

        }

        public static DataTable List(string sql)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(sql,Veritabanı.baglanti);
            adtr.Fill(tbl);
            return tbl;
        }
            
            
#pragma warning disable CS1513 // } bekleniyor
    }
#pragma warning restore CS1513 // } bekleniyor
