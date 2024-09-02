using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Pro_Lab2_Proje3
{
    public class Hasta:HastaIslemler,Giris_Kontrol
    {
        sql_connection bgl = new sql_connection();


        static string hastaTC;
        string sifre;

        public string HastaTC
        {
            set { hastaTC = value; }
            get { return hastaTC; }
        }

        public string Sifre
        {
            set { sifre = value; }
            get { return sifre; }
        }

        public Boolean giris_kontrol(string id, string sifre)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
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


            public int hasta_ekle(string tc, string ad, string soyad, string dtarih, string cinsiyet, string telefon, string adres, string sifre)
        {
            SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Tbl_Hastalar WHERE HastaTc = @tc", bgl.baglanti());
            kontrolKomut.Parameters.AddWithValue("@tc", tc);
            int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

            if (kayitSayisi > 0)
            {             
                return -1; // Hata durumunda -1 dön
            }

            SqlCommand komut = new SqlCommand("Insert into Tbl_Hastalar (HastaTc,HastaAd,HastaSoyad,DogumTarihi,HastaCinsiyet,HastaTel,HastaAdres,HastaSifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8) ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            komut.Parameters.AddWithValue("@p2", ad);
            komut.Parameters.AddWithValue("@p3", soyad);
            komut.Parameters.AddWithValue("@p4", dtarih);
            komut.Parameters.AddWithValue("@p5", cinsiyet);
            komut.Parameters.AddWithValue("@p6", telefon);
            komut.Parameters.AddWithValue("@p7", adres);
            komut.Parameters.AddWithValue("@p8", sifre);

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

        public int hasta_guncelle(string tc, string ad, string soyad, string dtarih, string cinsiyet, string telefon, string adres, string sifre)
        {

            SqlCommand komut = new SqlCommand("Update Tbl_Hastalar Set HastaAd=@p1,HastaSoyad=@p2,DogumTarihi=@p3,HastaCİnsiyet=@p4,HastaTel=@p5,HastaAdres=@p6,HastaSifre=@p7 where HastaTC=@p8",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",ad);
            komut.Parameters.AddWithValue("@p2", soyad);
            komut.Parameters.AddWithValue("@p3", dtarih);
            komut.Parameters.AddWithValue("@p4", cinsiyet);
            komut.Parameters.AddWithValue("@p5", telefon);
            komut.Parameters.AddWithValue("@p6", adres);
            komut.Parameters.AddWithValue("@p7", sifre);
            komut.Parameters.AddWithValue("@p8", tc);

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
        public int hasta_sil(string tc)
        {
            SqlCommand komut2 = new SqlCommand("DELETE FROM Tbl_Randevular WHERE HastaID = @HastaID", bgl.baglanti());
            komut2.Parameters.AddWithValue("@HastaID", tc);
            komut2.ExecuteNonQuery();

            SqlCommand komut3 = new SqlCommand("DELETE FROM Tbl_Raporlar WHERE HastaID = @HastaID", bgl.baglanti());
            komut3.Parameters.AddWithValue("@HastaID", tc);
            komut3.ExecuteNonQuery();

            SqlCommand komut = new SqlCommand("Delete From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",tc);
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
        public SqlDataReader hasta_listele()
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            return dr;

        }

        public int kayıt_sil(string tc,string sifre)
        {
            SqlCommand komut2 = new SqlCommand("DELETE FROM Tbl_Randevular WHERE HastaID = @HastaID", bgl.baglanti());
            komut2.Parameters.AddWithValue("@HastaID", tc);
            komut2.ExecuteNonQuery();

            SqlCommand komut3 = new SqlCommand("DELETE FROM Tbl_Raporlar WHERE HastaID = @HastaID", bgl.baglanti());
            komut3.Parameters.AddWithValue("@HastaID", tc);
            komut3.ExecuteNonQuery();


            SqlCommand komut = new SqlCommand("Delete From Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            komut.Parameters.AddWithValue("@p2", sifre);

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
    }
}