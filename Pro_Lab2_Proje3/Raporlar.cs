using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Pro_Lab2_Proje3
{
    public class Raporlar:RaporIslemler
    {
        sql_connection bgl=new sql_connection();
        public void rapor_ekle(string hastaID,int secilenDoktorID,string secilenTarih,string dosyaAdi, byte[] dosyaVerisi,string jsonData)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Raporlar ( HastaID, DoktorID, RaporTarihi, RaporAdi, PNG, JSON) VALUES ( @HastaID, @DoktorID, @RaporTarihi, @Rapor_Adi, @PNG_Data, @JSON_Data)", bgl.baglanti());
            komut.Parameters.AddWithValue("@HastaID", hastaID);
            komut.Parameters.AddWithValue("@DoktorID", secilenDoktorID);
            komut.Parameters.AddWithValue("@RaporTarihi", secilenTarih);
            komut.Parameters.AddWithValue("@Rapor_Adi", dosyaAdi);
            komut.Parameters.AddWithValue("@PNG_Data", dosyaVerisi);
            komut.Parameters.AddWithValue("@JSON_Data", jsonData);

            komut.ExecuteNonQuery();

        }

        public DataTable rapor_listele(string hastaID)
        {
            SqlCommand komut = new SqlCommand("SELECT RaporAdi, RaporID FROM Tbl_Raporlar WHERE HastaID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hastaID);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bgl.baglanti().Close();

            return dt;
        }

        public void rapor_sil(int raporid)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Raporlar WHERE RaporID = @RaporID", bgl.baglanti());
            komut.Parameters.AddWithValue("@RaporID", raporid);
            komut.ExecuteNonQuery();
        }

        public DataTable doktor_listele(string hastaID)
        {
            SqlCommand komut = new SqlCommand("SELECT CONCAT(d.DoktorAd, ' ', d.DoktorSoyad) AS DoktorAdSoyad, d.DoktorID FROM Tbl_Doktorlar d INNER JOIN Tbl_Randevular r ON d.DoktorID = r.DoktorID WHERE r.HastaID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hastaID);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bgl.baglanti().Close();

            return dt;
        }

        public DataTable hasta_listele(int doktorID)
        {
            SqlCommand komut = new SqlCommand("SELECT CONCAT(h.HastaAd, ' ', h.HastaSoyad) AS HastaAdSoyad, h.HastaTC FROM Tbl_Hastalar h INNER JOIN Tbl_Randevular r ON r.HastaID=h.HastaTC   WHERE r.DoktorID = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", doktorID);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bgl.baglanti().Close();

            return dt;
        }
    }
}