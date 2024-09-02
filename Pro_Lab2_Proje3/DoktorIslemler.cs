using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Lab2_Proje3
{
    internal interface DoktorIslemler
    {
        int doktor_ekle(string ad, string soyad, string sifre, int hastaneID, int bransID);
        int doktor_guncelle(int doktorID, string yeniAd, string yeniSoyad, string yeniSifre, int yeniHastaneID, int yeniBransID);
        int doktor_sil(int doktorID);
        SqlDataReader doktor_listele();
    }
}
