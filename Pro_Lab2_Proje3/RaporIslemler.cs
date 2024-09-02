using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_Lab2_Proje3
{
    internal interface RaporIslemler
    {
        void rapor_ekle(string hastaID, int secilenDoktorID, string secilenTarih, string dosyaAdi, byte[] dosyaVerisi, string jsonData);

        DataTable rapor_listele(string hastaID);

        void rapor_sil(int raporid);
        DataTable doktor_listele(string hastaID);
        DataTable hasta_listele(int doktorID);

    }
}
