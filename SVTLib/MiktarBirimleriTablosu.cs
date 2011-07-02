using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SQLite;

namespace SVTLib
{
    public class MiktarBirimleriTablosu
    {
        /// <summary>
        /// Yeni Ürün Eklerken ürün miktarı için seçilmesi gereken
        /// birim vardır. Bu birim seçilirken combobox kullanılıyordu
        /// bu comboboxun içini doldurmak için bu fonksiyon kullanılır.
        /// </summary>
        /// <returns>ArrayList</returns>
        public ArrayList GetListe1()
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = @"Data Source=veritabani.db3";

            string selectSQL = "SELECT * FROM miktar_birimleri ORDER BY ad ASC";

            SQLiteCommand command = new SQLiteCommand(selectSQL, conn);

            SQLiteDataReader reader;

            ArrayList arrayList = new ArrayList();

            try
            {
                conn.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    arrayList.Add(new MiktarBirimi(reader.GetInt32(0), reader.GetString(1)));
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

        public void Ekle1(MiktarBirimi miktarBirimi)
        {
            SQLiteConnection conn = new SQLiteConnection();

            conn.ConnectionString = @"Data Source=veritabani.db3";

            string selectSQL = "INSERT INTO miktar_birimleri (ad) VALUES ('" + miktarBirimi.Ad + "')";

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
