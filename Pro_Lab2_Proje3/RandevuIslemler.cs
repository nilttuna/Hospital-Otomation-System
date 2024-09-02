using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Lab2_Proje3
{
    internal interface RandevuIslemler
    {
        int randevu_sil(string randevuid);

        void randevu_al(string hastatc, int doktorid, string randevuTarih, string randevuSaat, string notlar);

        int randevu_guncelle(int randevuid, string randevutarih, string randevuSaat, string notlar);

        Boolean randevu_kontrolu(string randevuTarih, string randevuSaat, int doktorid, string Hastane, string Brans);

        Boolean hasta_randevu_kontrolü(string tc, int doktorid);

        Boolean randevu_guncelle_kontrolu(string randevuTarih, string randevuSaat, string hastatc);
        SqlDataReader Gecmis_randevu_listele(string hastatc);

        SqlDataReader Aktif_randevu_listele(string hastatc);


    }
}
