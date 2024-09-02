using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using System.Data.Common;

namespace Pro_Lab2_Proje3
{
    public partial class Randevular : System.Web.UI.Page
    {
        Hasta hasta = new Hasta();
        string hastaID;

        protected void Page_Load(object sender, EventArgs e)
        {
            hastaID = hasta.HastaTC;

            if (!IsPostBack)
            {

                Raporlar rapor=new Raporlar();
                DataTable dt= rapor.doktor_listele(hastaID);

                ddlDoktorlar.DataTextField = "DoktorAdSoyad";
                ddlDoktorlar.DataValueField = "DoktorID";
                ddlDoktorlar.DataSource = dt;
                ddlDoktorlar.DataBind();

                ddlRapor(hastaID);


            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            int selectedRaporid = 0;
            try
            {
                selectedRaporid = Convert.ToInt32(ddlSil.SelectedValue);

            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Rapor Silinemedi.');", true);
                return;

            }

            if (selectedRaporid !=0)
            {
                Raporlar rapor=new Raporlar();
                rapor.rapor_sil(selectedRaporid);

                ddlRapor(hastaID);
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Rapor Silindi.');", true);
            }
            else
            {
                Response.Write("Lütfen bir rapor seçin.");
            }
        }

    

        private void ddlRapor(string hastaID)
        {
            ddlSil.Items.Clear();
            Raporlar rapor=new Raporlar();
            DataTable dt = rapor.rapor_listele(hastaID);

            if (dt.Rows.Count > 0)
            {
                ddlSil.DataTextField = "RaporAdi";
                ddlSil.DataValueField = "RaporID";
                ddlSil.DataSource = dt;
                ddlSil.DataBind();

            }
            else
            {
                ddlSil.Items.Add(new ListItem("Rapor bulunamadı", ""));
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            if (fileUpload.HasFile)
            {
                // Dosyanın adını ve boyutunu al
                string dosyaAdi = fileUpload.FileName;
                int dosyaBoyutu = fileUpload.PostedFile.ContentLength;

                // Dosyayı byte dizisine dönüştür
                byte[] dosyaVerisi = new byte[dosyaBoyutu];
                fileUpload.PostedFile.InputStream.Read(dosyaVerisi, 0, dosyaBoyutu);

                // JSON veriyi oluştur
                string jsonData = "{\"dosyaAdi\": \"" + dosyaAdi + "\", \"dosyaBoyutu\": " + dosyaBoyutu + "}";

                string hastaID = hasta.HastaTC;

                int secilenDoktorID = Convert.ToInt32( ddlDoktorlar.SelectedValue);

                string secilenTarih = txtTarih.Text;


               Raporlar rapor =new Raporlar();
               rapor.rapor_ekle(hastaID, secilenDoktorID, secilenTarih, dosyaAdi, dosyaVerisi, jsonData);

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Rapor Yüklendi.');", true);
                ddlRapor(hastaID);


            }
            else
            {
                Response.Write("Lütfen bir dosya seçin.");
            }
        }


    }
}