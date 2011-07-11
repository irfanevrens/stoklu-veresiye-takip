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
        private string connString = @"Data Source=veritabani.db3";

        /// <summary>
        /// Yeni Ürün Eklerken ürün miktarı için seçilmesi gereken
        /// birim vardır. Bu birim seçilirken combobox kullanılıyordu
        /// bu comboboxun içini doldurmak için bu fonksiyon kullanılır.
        /// </summary>
        /// <returns>ArrayList</returns>
        public ArrayList GetListe1()
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = connString;

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

            conn.ConnectionString = connString;

            string insertSQL = string.Format("INSERT INTO miktar_birimleri (ad) VALUES ('{0}')", miktarBirimi.Ad.Replace("'", "''"));

            SQLiteCommand command = new SQLiteCommand(insertSQL, conn);

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

        public void GuncelleAdiById(string yeniBirimAdi, int birimId)
        {
            SQLiteConnection conn = new SQLiteConnection();

            conn.ConnectionString = connString;

            string updateSQL = string.Format("UPDATE miktar_birimleri SET ad = '{0}' WHERE id = {1}", yeniBirimAdi.Replace("'", "''"), birimId);

            SQLiteCommand command = new SQLiteCommand(updateSQL, conn);

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

        public void SilById(int aktifBirimId)
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = connString;

            string deleteSQL = "DELETE FROM miktar_birimleri WHERE id = " + aktifBirimId;

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
