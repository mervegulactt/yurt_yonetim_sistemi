using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtYonetimSistemi
{
    public static class Baglanti
    {

        public static SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.; Initial Catalog=YurtData; Integrated Security=true");
            baglanti.Open();
            SqlConnection.ClearPool(baglanti);
            SqlConnection.ClearAllPools();

            return baglanti;
        }


        public static int idu(string sqlcumle)
        {

            SqlConnection baglan = Baglanti.baglan();
            SqlCommand sorgu = new SqlCommand(sqlcumle, baglan);
            int sonuc = 0;
            try
            {
                sonuc = sorgu.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            sorgu.Dispose();
            baglan.Close();
            baglan.Dispose();
            return (sonuc);
        }


        public static DataTable DataTableGetir(string sql)
        {
            SqlConnection baglan = Baglanti.baglan();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, baglan);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            adapter.Dispose();
            baglan.Close();
            baglan.Dispose();
            return dt;

        }

        public static DataRow DataRowGetir(string sql)
        {
            DataTable tablo = DataTableGetir(sql);
            if (tablo.Rows.Count == 0)
                return null;
            return tablo.Rows[0];
        }
    }
}
