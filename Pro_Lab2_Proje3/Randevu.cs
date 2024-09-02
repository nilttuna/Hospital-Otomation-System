using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Pro_Lab2_Proje3
{
    public class Randevu:RandevuIslemler
    {
        sql_connection bgl=new sql_connection();
        public int randevu_sil(string randevuid)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Randevular WHERE RandevuID = @RandevuID",bgl.baglanti());
            komut.Parameters.AddWithValue("@RandevuID",randevuid);
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
        public void randevu_al(string hastatc,int doktorid,string randevuTarih,string randevuSaat,string notlar )
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Randevular (HastaID, DoktorID, RandevuTarih, RandevuSaat,  Notlar) " +
                                                 "VALUES (@HastaID, @DoktorID, @RandevuTarih, @RandevuSaat,  @Notlar)",bgl.baglanti());

            komut.Parameters.AddWithValue("@HastaID", hastatc);
            komut.Parameters.AddWithValue("@DoktorID", doktorid);
            komut.Parameters.AddWithValue("@RandevuTarih", randevuTarih);
            komut.Parameters.AddWithValue("@RandevuSaat", randevuSaat);
            komut.Parameters.AddWithValue("@Notlar", notlar);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        public int randevu_guncelle(int randevuid,string randevutarih, string randevuSaat,string notlar)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Randevular SET RandevuTarih=@p1, RandevuSaat=@p2,Notlar=@p3 WHERE RandevuID = @RandevuID",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",randevutarih);
            komut.Parameters.AddWithValue("@p2", randevuSaat);
            komut.Parameters.AddWithValue("@p3", notlar);
            komut.Parameters.AddWithValue("@RandevuID", randevuid);

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

        public Boolean randevu_kontrolu(string randevuTarih, string randevuSaat,int doktorid,string Hastane,string Brans)
        {

            SqlCommand komut = new SqlCommand("SELECT H.HastaneAdı, B.Brans, D.DoktorID, R.RandevuTarih, R.RandevuSaat FROM Tbl_Randevular R INNER JOIN Tbl_Doktorlar D ON R.DoktorID = D.DoktorID INNER JOIN Tbl_Hastane H ON D.Hastane = H.HastaneID INNER JOIN Tbl_Branslar B ON D.UzmanlikAlan = B.BransID", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                string tarih = dr["RandevuTarih"].ToString();
                string zaman = dr["RandevuSaat"].ToString();
                string hastane = dr["HastaneAdı"].ToString();
                int Doktorid = Convert.ToInt32( dr["DoktorID"]);
                string brans = dr["Brans"].ToString();


                if (tarih== randevuTarih && zaman==randevuSaat && hastane==Hastane && Doktorid==doktorid && brans==(Brans))
                {
                    dr.Close();
                    bgl.baglanti().Close();
                    return false;
                }
            }
            dr.Close();
            bgl.baglanti().Close();
            return true;
        }

        public Boolean hasta_randevu_kontrolü(string tc, int doktorid)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Randevular where RandevuTarih >= (SELECT CAST(GETDATE() AS DATE) AS BugununTarihi)", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                int doktor =  Convert.ToInt32( dr["DoktorID"]);
                string hastatc = dr["HastaID"].ToString();
               

                if (doktor == doktorid && hastatc==tc  )
                {
                    dr.Close();
                    bgl.baglanti().Close();
                    return false;
                }
            }
            dr.Close();
            bgl.baglanti().Close();
            return true;
 
        }

        public Boolean randevu_guncelle_kontrolu(string randevuTarih, string randevuSaat,string hastatc)
        {

            SqlCommand komut = new SqlCommand("Select RandevuTarih,RandevuSaat,HastaID From Tbl_Randevular", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                string tarih = dr["RandevuTarih"].ToString();
                string zaman = dr["RandevuSaat"].ToString();
                string hasta = dr["HastaID"].ToString();

                if ((tarih == randevuTarih && zaman == randevuSaat && hasta==hastatc))
                {
                    dr.Close();
                    bgl.baglanti().Close();
                    return false;
                }
            }
            dr.Close();
            bgl.baglanti().Close();
            return true;
        }

        public SqlDataReader Aktif_randevu_listele(string hastatc)
        {
            SqlCommand komut = new SqlCommand("SELECT H.HastaneAdı, B.Brans, D.DoktorAd, D.DoktorSoyad, R.RandevuTarih, R.RandevuSaat, R.Notlar, R.RandevuID FROM Tbl_Randevular R " + " " +
                                              "INNER JOIN Tbl_Doktorlar D ON R.DoktorID = D.DoktorID " + " " +
                                              "INNER JOIN Tbl_Hastane H ON D.Hastane = H.HastaneID" + " " +
                                              "INNER JOIN Tbl_Branslar B ON D.UzmanlikAlan = B.BransID WHERE R.HastaID = @HastaID AND R.RandevuTarih >= (SELECT CAST(GETDATE() AS DATE) AS BugununTarihi)", bgl.baglanti());
            komut.Parameters.AddWithValue("@HastaID", hastatc);

            SqlDataReader rd = komut.ExecuteReader();
            return rd;
        }


        public SqlDataReader Gecmis_randevu_listele(string hastatc)
        {
            SqlCommand komut = new SqlCommand("SELECT H.HastaneAdı, B.Brans, D.DoktorAd, D.DoktorSoyad, R.RandevuTarih, R.RandevuSaat, R.Notlar, R.RandevuID FROM Tbl_Randevular R " + " " +
                                              "INNER JOIN Tbl_Doktorlar D ON R.DoktorID = D.DoktorID " + " " +
                                              "INNER JOIN Tbl_Hastane H ON D.Hastane = H.HastaneID" + " " +
                                              "INNER JOIN Tbl_Branslar B ON D.UzmanlikAlan = B.BransID WHERE R.HastaID = @HastaID AND R.RandevuTarih < (SELECT CAST(GETDATE() AS DATE) AS BugununTarihi)", bgl.baglanti());
            komut.Parameters.AddWithValue("@HastaID", hastatc);

            SqlDataReader rd = komut.ExecuteReader();
            return rd;
        }
    }
}