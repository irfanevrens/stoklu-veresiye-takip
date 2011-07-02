using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Collections;

namespace SVTLib
{
    public class UrunlerTablosu
    {
        /// <summary>
        /// Yeni ürün eklemek için kullanılır. Yeni ürün ekleme 
        /// formundan alınan bilgiler bu fonksiyona verilir ve 
        /// veritabanına yeni kayıt olarak eklenir
        /// </summary>
        public void Ekle1(Urun urun)
        {
            if (urun.Ad.Length == 0) throw new Exception("Ürün adı boş geçilemez.");

            SQLiteConnection conn = new SQLiteConnection();

            conn.ConnectionString = @"Data Source=veritabani.db3";

            string selectSQL = "INSERT INTO urunler (ad, miktar, miktar_birim_id, aciklama) VALUES ('" + urun.Ad + "', " + urun.Miktar + ", " + urun.MiktarBirimId + ", '" + urun.Aciklama + "')";

            SQLiteCommand command = new SQLiteCommand(selectSQL, conn);

            try
            {
                conn.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
