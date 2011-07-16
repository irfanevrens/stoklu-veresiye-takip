using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace SVTLib
{
    public class VeresiyelerTablosu
    {
        public void SilWhereMusteriId(int musteriId)
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = Ayarlar.connString;

            string deleteSQL = "DELETE FROM veresiyeler WHERE musteri_id = " + musteriId;

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
