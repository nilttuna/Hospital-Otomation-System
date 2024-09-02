using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Pro_Lab2_Proje3
{
    public class Yonetici:Giris_Kontrol
    {
        string yoneticiid;
        string sifre;

        public string Yoneticiid
        {
            set { yoneticiid = value; }
            get { return yoneticiid; }
        }

        public string Sifre
        {
            set { sifre = value; }
            get { return sifre; }
        }

        sql_connection bgl = new sql_connection();
        public Boolean giris_kontrol(string id, string sifre)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where YoneticiID=@p1 and YoneticiSifre=@p2", bgl.baglanti());
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
        
    }
}