﻿using System;
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
        private string connString = @"Data Source=veritabani.db3";

        /// <summary>
        /// Yeni ürün eklemek için kullanılır. Yeni ürün ekleme 
        /// formundan alınan bilgiler bu fonksiyona verilir ve 
        /// veritabanına yeni kayıt olarak eklenir
        /// </summary>
        public void Ekle1(Urun urun)
        {
            if (urun.Ad.Length == 0) throw new Exception("Ürün adı boş geçilemez.");

            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = connString;

            string selectSQL = string.Format("INSERT INTO urunler (ad, miktar, miktar_birim_id, aciklama) VALUES ('{0}', {1}, {2}, '{3}')", urun.Ad.Replace("'", "''"), urun.Miktar, urun.MiktarBirimi.Id, urun.Aciklama.Replace("'", "''")); 

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
            conn.ConnectionString = connString;

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
            conn.ConnectionString = connString;

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

        public Urun getDetay1(int id)
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = connString;
            
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
"WHERE urunler.id = " + id.ToString();

            SQLiteCommand command = new SQLiteCommand(selectSQL, conn);

            SQLiteDataReader reader;

            Urun urun = new Urun();

            try
            {
                conn.Open();

                reader = command.ExecuteReader();

                if (reader.HasRows == false) throw new Exception("Kayıt bulunamadı.");

                int satirSayisi = 0;

                while (reader.Read())
                {
                    satirSayisi++;

                    urun.Id = reader.GetInt32(0);
                    urun.Ad = reader.GetString(1);
                    urun.Miktar = reader.GetInt32(2);
                    urun.Aciklama = reader.GetString(3);

                    urun.MiktarBirimi.Ad = reader.GetString(4);
                    urun.MiktarBirimi.Id = reader.GetInt32(5);
                }

                if (satirSayisi != 1) throw new Exception("Sistemsel bir hata meydana geldi. Lütfen program üreticisi ile irtibata geçiniz. Adet: " + reader.RecordsAffected.ToString() + ", Id: " + id.ToString());

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

            return urun;
        }

        public void Guncelle1(Urun urun)
        {
            if (urun.Id == 0) throw new Exception("Ürün Id bilgisi tanımsız.");
            if (urun.Ad.Length == 0) throw new Exception("Ürün adı boş geçilemez.");

            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = connString;

            string selectSQL = string.Format("UPDATE urunler SET ad = '{0}', miktar = {1}, miktar_birim_id = {2}, aciklama = '{3}' WHERE id = {4}", urun.Ad.Replace("'", "''"), urun.Miktar, urun.MiktarBirimi.Id, urun.Aciklama.Replace("'", "''"), urun.Id);

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

        public bool IsVarWhereMiktarBirimId(int aktifBirimId)
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = connString;

            string selectSQL = String.Format(
"SELECT " +
  "COUNT(*) AS adet " +
"FROM " +
  "urunler " +
"WHERE urunler.miktar_birim_id = {0}", aktifBirimId);

            SQLiteCommand command = new SQLiteCommand(selectSQL, conn);

            SQLiteDataReader reader;

            Urun urun = new Urun();

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
    }
}
