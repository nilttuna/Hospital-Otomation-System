using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class DoktorRaporlar : System.Web.UI.Page
    {
        int doktorid;
        Doktor doktor=new Doktor();
        protected void Page_Load(object sender, EventArgs e)
        {
            doktorid = Convert.ToInt32( doktor.Doktorid);
            if (!IsPostBack)
            {

                Raporlar rapor = new Raporlar();
                DataTable dt = rapor.hasta_listele(doktorid);

                ddlHastalar.DataTextField = "HastaAdSoyad";
                ddlHastalar.DataValueField = "HastaTC";
                ddlHastalar.DataSource = dt;
                ddlHastalar.DataBind();

                ddlRapor(ddlHastalar.SelectedValue);


            }

        }

        private void ddlRapor(string hastaID)
        {
            ddlSil.Items.Clear();
            Raporlar rapor = new Raporlar();
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

                string secilenhastaID = ddlHastalar.SelectedValue;

                int DoktorID =doktorid;

                string secilenTarih = txtTarih.Text;


                Raporlar rapor = new Raporlar();
                rapor.rapor_ekle(secilenhastaID, DoktorID, secilenTarih, dosyaAdi, dosyaVerisi, jsonData);

                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Rapor Yüklendi.');", true);
                ddlRapor(secilenhastaID);


            }
            else
            {
                Response.Write("Lütfen bir dosya seçin.");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            int selectedRaporid=0;
            try
            {
                 selectedRaporid = Convert.ToInt32(ddlSil.SelectedValue);

            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Rapor Silinemedi.');", true);
                return;

            }

            if (selectedRaporid != 0)
            {
                Raporlar rapor = new Raporlar();
                rapor.rapor_sil(selectedRaporid);

                ddlRapor(ddlHastalar.SelectedValue);
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Rapor Silindi.');", true);
            }
            else
            {
                Response.Write("Lütfen bir rapor seçin.");
            }
        }
    }
}