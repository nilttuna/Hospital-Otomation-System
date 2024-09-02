using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class RandevuAl : System.Web.UI.Page
    {
        sql_connection bgl=new sql_connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Sayfa ilk kez yüklendiğinde
            {
                SqlCommand komut = new SqlCommand("SELECT Distinct h.HastaneAdı FROM Tbl_Doktorlar d INNER JOIN Tbl_Hastane h ON d.Hastane = h.HastaneID", bgl.baglanti());
                SqlDataReader rd = komut.ExecuteReader();
                while (rd.Read())
                {
                    string hastaneAdi = rd["HastaneAdı"].ToString();
                    ddlHastane.Items.Add(hastaneAdi);
                }

                rd.Close();
                bgl.baglanti().Close();
                FillBransDropDown();
                FillDoktorlarDropDown();
            }
           

        }
        protected void ddlHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillBransDropDown();
            FillDoktorlarDropDown();
        }

        protected void ddlBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

            FillDoktorlarDropDown();
        }


        private void FillBransDropDown()
        {
            string selectedHastane = ddlHastane.SelectedItem.Text;
            SqlCommand komut = new SqlCommand("SELECT DISTINCT b.Brans FROM Tbl_Doktorlar d  INNER JOIN Tbl_Hastane h ON d.Hastane = h.HastaneID INNER JOIN Tbl_Branslar b ON d.UzmanlikAlan = b.BransID WHERE h.HastaneAdı=@hastane", bgl.baglanti());
            komut.Parameters.AddWithValue("@hastane", selectedHastane);

            SqlDataReader rd = komut.ExecuteReader();

            ddlBrans.Items.Clear(); 
            while (rd.Read())
            {
                string uzmanlikAlani = rd["Brans"].ToString();
                ddlBrans.Items.Add(uzmanlikAlani);
            }

            rd.Close();
            bgl.baglanti().Close();
        }
        private void FillDoktorlarDropDown()
        {
            string selectedHastane = ddlHastane.SelectedItem.Text;
            string selectedBrans = ddlBrans.SelectedItem.Text;

            SqlCommand komut = new SqlCommand("SELECT d.DoktorAd,d.DoktorSoyad FROM Tbl_Doktorlar d  INNER JOIN Tbl_Hastane h ON d.Hastane = h.HastaneID INNER JOIN Tbl_Branslar b ON d.UzmanlikAlan = b.BransID WHERE h.HastaneAdı=@hastane and b.Brans=@brans", bgl.baglanti());
            komut.Parameters.AddWithValue("@hastane", selectedHastane);
            komut.Parameters.AddWithValue("@brans", selectedBrans);


            SqlDataReader rd = komut.ExecuteReader();

            ddlDoktor.Items.Clear(); 
            while (rd.Read())
            {
                string adSoyad = rd["DoktorAd"].ToString() + " " + rd["DoktorSoyad"].ToString();
                ddlDoktor.Items.Add(adSoyad);
            }

            rd.Close();
            bgl.baglanti().Close();

        }

        protected void btnRandevuAl_Click(object sender, EventArgs e)
        {
            Boolean alanlar_bos = false;
            string HastaTC = Request.QueryString["hastatc"];

            string selectedDoktorAdi = ddlDoktor.SelectedItem.Text;

            string randevuTarihi = txtTarih.Text;
            string randevuSaati = txtSaat.Text;
            string hastane = ddlHastane.SelectedItem.Text;
            string brans = ddlBrans.SelectedItem.Text; 
            string notlar = txtNot.Text;

            SqlCommand komut = new SqlCommand("SELECT DoktorID FROM Tbl_Doktorlar WHERE CONCAT(DoktorAd, ' ', DoktorSoyad) = @Ad",bgl.baglanti());
            komut.Parameters.AddWithValue("@Ad", selectedDoktorAdi);
            SqlDataReader rd = komut.ExecuteReader();
            int doktorID = 0;

            if (rd.Read()) 
            {
                doktorID = Convert.ToInt32(rd["DoktorID"]);
            }

            bgl.baglanti().Close();

            if (string.IsNullOrEmpty(txtTarih.Text) || string.IsNullOrEmpty(txtSaat.Text) || string.IsNullOrEmpty(txtNot.Text) )
            {
                alanlar_bos = true;
            }
            if (alanlar_bos)
            {
                Response.Write("<script>alert('Lütfen tüm alanları doldurunuz.');</script>");
                return;
            }

            TimeSpan saat = TimeSpan.Parse(randevuSaati);
            randevuSaati = saat.ToString("hh\\:mm\\:ss");

            Randevu randevu = new Randevu();
            Boolean kontrol = randevu.randevu_kontrolu(randevuTarihi, randevuSaati,doktorID,hastane,brans);
            if (kontrol==true)
            {
                if (randevu.hasta_randevu_kontrolü(HastaTC, doktorID))
                {
                    if (doktorID > 0)
                    {
                        randevu.randevu_al(HastaTC, doktorID, randevuTarihi, randevuSaati, notlar);

                        txtSaat.Text = "";
                        txtNot.Text = "";
                        ddlHastane.SelectedIndex = 0;
                        ddlBrans.SelectedIndex = 0;
                        ddlDoktor.SelectedIndex = 0;
                        txtTarih.Text = "";
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Randevu Alımı Başarılı'); window.location = 'HastaSayfasi.aspx?hastatc=" + HastaTC + "';", true);


                    }
                    else
                    {
                        Response.Write("Seçilen doktor bulunamadı.");
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Randevu Alımı Başarısız'); window.location = 'RandevuAl.aspx?hastatc=" + HastaTC + "';", true);

                }

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Randevu Alımı Başarısız'); window.location = 'RandevuAl.aspx?hastatc=" + HastaTC + "';", true);
            }


        }



    }
}