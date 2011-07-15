using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Collections;
using System.Data;

namespace SVTLib
{
    public class MusterilerTablosu
    {
        private string connString = Ayarlar.connString;

        /// <summary>
        /// Müşterilerin listesini almak için
        /// </summary>
        /// <returns></returns>
        public ArrayList GetListe1()
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = connString;

            string selectSQL =  
"SELECT id, adi " + 
"FROM " +
  "musteriler " +
"ORDER BY " + 
  "adi ASC";

            SQLiteCommand command = new SQLiteCommand(selectSQL, conn);

            SQLiteDataReader reader;

            ArrayList arrayList = new ArrayList();

            try
            {
                conn.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    arrayList.Add(new Musteri(reader.GetInt32(0), reader.GetString(1)));
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
    }
}
