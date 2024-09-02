using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Lab2_Proje3
{
    internal interface HastaIslemler
    {
        int hasta_ekle(string tc, string ad, string soyad, string dtarih, string cinsiyet, string telefon, string adres, string sifre);
        int hasta_guncelle(string tc, string ad, string soyad, string dtarih, string cinsiyet, string telefon, string adres, string sifre);
        int hasta_sil(string tc);
        SqlDataReader hasta_listele();

        int kayıt_sil(string tc,string sifre);
    }
}
