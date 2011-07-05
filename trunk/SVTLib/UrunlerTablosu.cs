using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Collections;
using System.Data;

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

            string selectSQL = "INSERT INTO urunler (ad, miktar, miktar_birim_id, aciklama) VALUES ('" + urun.Ad + "', " + urun.Miktar + ", " + urun.MiktarBirimi.Id + ", '" + urun.Aciklama + "')";

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

        /// <summary>
        /// Ürün listeleme formunda ürünlerin listesini göstermek için
        /// </summary>
        /// <returns></returns>
        public ArrayList GetListe1()
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = @"Data Source=veritabani.db3";

            string selectSQL =  
"SELECT " +
  "urunler.id, " + 
  "urunler.ad, " +
  "urunler.miktar, " + 
  "urunler.aciklama, " +
  "miktar_birimleri.ad AS miktar_birim_ad, " + 
  "urunler.miktar_birim_id " + 
"FROM " +
  "urunler " +
  "INNER JOIN miktar_birimleri ON (urunler.miktar_birim_id = miktar_birimleri.id) " +
"ORDER BY " + 
  "urunler.ad";

            SQLiteCommand command = new SQLiteCommand(selectSQL, conn);

            SQLiteDataReader reader;

            ArrayList arrayList = new ArrayList();

            try
            {
                conn.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    arrayList.Add(new Urun(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5)));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return arrayList;
        }

        public void UrunSilById(int urun_id)
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = @"Data Source=veritabani.db3";

            string deleteSQL = "DELETE FROM urunler WHERE id = " + urun_id;

            SQLiteCommand command = new SQLiteCommand(deleteSQL, conn);

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
