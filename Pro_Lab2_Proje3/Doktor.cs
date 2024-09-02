using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace Pro_Lab2_Proje3
{
   
    public class Doktor:DoktorIslemler,Giris_Kontrol
    {
       sql_connection bgl = new sql_connection();

        static string doktorid;
        string sifre;

        public string Doktorid
        {
            set { doktorid = value; }
            get { return doktorid; }
        }

        public string Sifre
        {
            set { sifre = value; }
            get { return sifre; }
        }

        public Boolean giris_kontrol(string id, string sifre)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorID=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id);
            komut.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                bgl.baglanti().Close();
                return true;
            }
            else
            {
                bgl.baglanti().Close();
                return false;
            }


        }

        public SqlDataReader doktor_listele()
        {
            SqlCommand komut = new SqlCommand("SELECT d.DoktorID, d.DoktorAd, d.DoktorSoyad, d.DoktorSifre, h.HastaneAdı  ,b.Brans\r\nFROM Tbl_Doktorlar d \r\nINNER JOIN Tbl_Hastane h ON d.Hastane = h.HastaneID\r\nINNER JOIN Tbl_Branslar b ON d.UzmanlikAlan = b.BransID", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            return dr;
        }
        public int doktor_guncelle(int doktorID, string yeniAd, string yeniSoyad, string yeniSifre, int yeniHastaneID, int yeniBransID)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Doktorlar SET DoktorAd=@ad, DoktorSoyad=@soyad, DoktorSifre=@sifre, Hastane=@hastaneID, UzmanlikAlan=@bransID WHERE DoktorID=@doktorID", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", yeniAd);
            komut.Parameters.AddWithValue("@soyad", yeniSoyad);
            komut.Parameters.AddWithValue("@sifre", yeniSifre);
            komut.Parameters.AddWithValue("@hastaneID", yeniHastaneID);
            komut.Parameters.AddWithValue("@bransID", yeniBransID);
            komut.Parameters.AddWithValue("@doktorID", doktorID);
            try
            {
                int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                return etkilenenSatirSayisi;
            }
            catch (Exception ex)
            {
                bgl.baglanti().Close();
                return 0;
            }
        }

        public int doktor_sil(int doktorID)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Doktorlar WHERE DoktorID=@doktorID", bgl.baglanti());
            komut.Parameters.AddWithValue("@doktorID", doktorID);
            try
            {
                int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                return etkilenenSatirSayisi;
            }
            catch (Exception ex)
            {
                bgl.baglanti().Close();
                return 0;
            }
        }

        public int doktor_ekle(string ad, string soyad, string sifre, int hastaneID, int bransID)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Doktorlar (DoktorAd, DoktorSoyad, DoktorSifre, Hastane, UzmanlikAlan) VALUES (@ad, @soyad, @sifre, @hastaneID, @bransID)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@soyad", soyad);
            komut.Parameters.AddWithValue("@sifre", sifre);
            komut.Parameters.AddWithValue("@hastaneID", hastaneID);
            komut.Parameters.AddWithValue("@bransID", bransID);
            int guncellenensatir = komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            return guncellenensatir;


        }

        public SqlDataReader hasta_listele(int doktorid)
        {
            SqlCommand komut = new SqlCommand("SELECT HastaTC, HastaAd, HastaSoyad, DogumTarihi, HastaCinsiyet, HastaTel, HastaAdres FROM Tbl_Hastalar WHERE HastaTC IN (SELECT  HastaID FROM Tbl_Randevular WHERE DoktorID = @p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", doktorid);
            SqlDataReader rd = komut.ExecuteReader();
            return rd;

        }


    }
}