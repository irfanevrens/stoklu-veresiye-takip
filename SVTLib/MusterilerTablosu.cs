using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Collections;
using System.Data;
using System.Drawing;

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
"SELECT " +
    "musteriler.id, " + 
    "musteriler.adi, " + 
    "(SELECT SUM(veresiyeler.miktar) AS FIELD_1 FROM veresiyeler WHERE veresiyeler.musteri_id = musteriler.Id) AS veresiye_toplami, " + 
    "(SELECT SUM(tahsilatlar.miktar) AS FIELD_1 FROM tahsilatlar WHERE tahsilatlar.musteri_id = musteriler.Id) AS tahsilat_toplami " + 
"FROM musteriler";

            SQLiteCommand command = new SQLiteCommand(selectSQL, conn);

            SQLiteDataReader reader;

            ArrayList arrayList = new ArrayList();

            try
            {
                conn.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    float veresiyeToplami;
                    float tahsilatToplami;

                    if (string.IsNullOrEmpty(reader[2].ToString()))
                        veresiyeToplami = 0;
                    else
                        veresiyeToplami = reader.GetFloat(2);

                    if (string.IsNullOrEmpty(reader[3].ToString()))
                        tahsilatToplami = 0;
                    else
                        tahsilatToplami = reader.GetFloat(3);



                    arrayList.Add(new Musteri(reader.GetInt32(0), reader.GetString(1), veresiyeToplami, tahsilatToplami));
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

        public string GetVeresiyeDurumu(Musteri musteri)
        {
            if ((musteri.VeresiyeToplami - musteri.TahsilatToplami) > 0) 
            {
                return (musteri.VeresiyeToplami - musteri.TahsilatToplami).ToString() + " TL Borcu Var";
            }
            else if ((musteri.TahsilatToplami - musteri.VeresiyeToplami) > 0)
            {
                return (musteri.TahsilatToplami - musteri.VeresiyeToplami).ToString() + " TL Bakiyesi Var";
            }
            else 
            {
                return "Borcu Yok";
            }
        }

        public Color GetVeresiyeDurumuRengi(Musteri musteri)
        {
            if ((musteri.VeresiyeToplami - musteri.TahsilatToplami) > 0)
            {
                return Color.Tomato;
            }
            else if ((musteri.TahsilatToplami - musteri.VeresiyeToplami) > 0)
            {
                return Color.SpringGreen;
            }
            else
            {
                return Color.Honeydew;
            }
        }

        public void Ekle1(Musteri musteri)
        {
            if (musteri.Adi.Trim().Length == 0) throw new Exception("Müşteri adını yazınız.");
            if (IsVarAdi(musteri)) throw new Exception("Bu isimde müşteri daha önce eklenmiş, farklı bir isimde ekleyiniz.");

            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = connString;

            string insertSQL = string.Format(
"INSERT " + 
    "INTO musteriler (adi, firma_adi, ev_telefonu, is_telefonu, cep_telefonu, adres) " + 
    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", 
    musteri.Adi.Replace("'", "''"),
    musteri.FirmaAdi.Replace("'", "''"),
    musteri.EvTelefonu.Replace("'", "''"),
    musteri.IsTelefonu.Replace("'", "''"),
    musteri.CepTelefonu.Replace("'", "''"),
    musteri.Adres.Replace("'", "''"));

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

        public bool IsVarAdi(Musteri musteri) 
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = connString;

            string selectSQL = String.Format(
"SELECT " +
  "COUNT(*) AS adet " +
"FROM " +
  "musteriler " +
"WHERE adi = '{0}'", musteri.Adi);

            SQLiteCommand command = new SQLiteCommand(selectSQL, conn);

            SQLiteDataReader reader;

            bool sonuc = false;
            int adet = 0;

            try
            {
                conn.Open();

                reader = command.ExecuteReader();

                if (reader.HasRows == false) throw new Exception("Sistemsel hata, program üreticisi ile görüşünüz.");

                int satirSayisi = 0;

                while (reader.Read())
                {
                    satirSayisi++;

                    adet = reader.GetInt32(0);
                }

                if (satirSayisi != 1) throw new Exception("Sistemsel bir hata meydana geldi. Lütfen program üreticisi ile irtibata geçiniz. Adet: " + reader.RecordsAffected.ToString());

                if (satirSayisi == 1)
                    if (adet == 0)
                        sonuc = false;
                    else
                        sonuc = true;

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

            return sonuc;
        }

        public bool IsYokBorcu(int aktifMusteriId)
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = connString;

            string selectSQL = String.Format(
"SELECT " +
    "(SELECT SUM(veresiyeler.miktar) FROM veresiyeler WHERE veresiyeler.musteri_id = musteriler.Id) AS veresiye_toplami, " +
    "(SELECT SUM(tahsilatlar.miktar) FROM tahsilatlar WHERE tahsilatlar.musteri_id = musteriler.Id) AS tahsilat_toplami " +
"FROM musteriler " +
"WHERE id = {0}", aktifMusteriId.ToString());

            SQLiteCommand command = new SQLiteCommand(selectSQL, conn);

            SQLiteDataReader reader;

            bool sonuc = false;

            try
            {
                conn.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    float veresiyeToplami;
                    float tahsilatToplami;

                    if (string.IsNullOrEmpty(reader[0].ToString()))
                        veresiyeToplami = 0;
                    else
                        veresiyeToplami = reader.GetFloat(0);

                    if (string.IsNullOrEmpty(reader[1].ToString()))
                        tahsilatToplami = 0;
                    else
                        tahsilatToplami = reader.GetFloat(1);

                    if ((veresiyeToplami - tahsilatToplami) == 0)
                        sonuc = true;
                    else
                        sonuc = false;
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

            return sonuc;
        }

        public void SilById(int id)
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = Ayarlar.connString;

            string deleteSQL = "DELETE FROM musteriler WHERE id = " + id;

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

        public ArrayList GetHareketler1(int musteriId)
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = connString;

            string selectVeresiyelerSQL =
"SELECT " +
    "id, " +
    "aciklama, " +
    "tarih, " +
    "miktar " +
"FROM veresiyeler " + 
"WHERE musteri_id = " + musteriId.ToString() + " " + 
"ORDER BY tarih DESC";

            string selectTahsilatlarSQL =
"SELECT " +
    "id, " +
    "aciklama, " +
    "tarih, " +
    "miktar " +
"FROM tahsilatlar " +
"WHERE musteri_id = " + musteriId.ToString() + " " +
"ORDER BY tarih DESC";

            SQLiteCommand commandVeresiyeler = new SQLiteCommand(selectVeresiyelerSQL, conn);
            SQLiteCommand commandTahsilatlar = new SQLiteCommand(selectTahsilatlarSQL, conn);

            SQLiteDataReader readerVeresiyeler;
            SQLiteDataReader readerTahsilatlar;

            ArrayList arrayList = new ArrayList();

            try
            {
                conn.Open();

                readerVeresiyeler = commandVeresiyeler.ExecuteReader();
                readerTahsilatlar = commandTahsilatlar.ExecuteReader();

                while (readerVeresiyeler.Read())
                {
                    arrayList.Add(new Hareket(readerVeresiyeler.GetInt32(0), readerVeresiyeler.GetString(1), readerVeresiyeler.GetDateTime(2), readerVeresiyeler.GetDecimal(3), Convert.ToDecimal(0), HareketTurleri.Veresiye));
                }

                while (readerTahsilatlar.Read())
                {
                    arrayList.Add(new Hareket(readerTahsilatlar.GetInt32(0), readerTahsilatlar.GetString(1), readerTahsilatlar.GetDateTime(2), Convert.ToDecimal(0), readerTahsilatlar.GetDecimal(3), HareketTurleri.Tahsilat));
                }

                readerVeresiyeler.Close();
                readerTahsilatlar.Close();
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