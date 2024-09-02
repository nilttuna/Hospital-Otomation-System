using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class RandevuGüncelle : System.Web.UI.Page
    {
        sql_connection bgl=new sql_connection();
        int randevuID;
        protected void Page_Load(object sender, EventArgs e)
        {
            randevuID = Convert.ToInt32( Request.QueryString["randevuID"]);
            if (!IsPostBack)
            {
                alanlari_doldur();

            }
        }


        private void alanlari_doldur()
        {
            randevuID = Convert.ToInt32( Request.QueryString["randevuID"]);
            SqlCommand komut = new SqlCommand("SELECT RandevuTarih, RandevuSaat, Notlar FROM Tbl_Randevular  where RandevuID='" + randevuID + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                TimeSpan saat = TimeSpan.Parse(dr[1].ToString());
                txtTarih.Text = dr[0].ToString();
                txtSaat.Text = saat.ToString("hh\\:mm\\:ss");
                txtNot.Text = dr[2].ToString();
 
               
            }
            dr.Close();
            bgl.baglanti().Close();
        }

        protected void btnRandevuGuncelle_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            Boolean alanlar_bos = false;
            string HastaTC = hasta.HastaTC;

           

            string randevuTarihi = txtTarih.Text;
            string randevuSaati = txtSaat.Text;
            string notlar = txtNot.Text;

           

            if (string.IsNullOrEmpty(txtTarih.Text) || string.IsNullOrEmpty(txtSaat.Text) || string.IsNullOrEmpty(txtNot.Text))
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
            Boolean kontrol = randevu.randevu_guncelle_kontrolu(randevuTarihi, randevuSaati,HastaTC);
            if (kontrol)
            {
                int etkilenensatir = randevu.randevu_guncelle(randevuID, randevuTarihi, randevuSaati, notlar);
                if (etkilenensatir > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Randevu Güncellendi'); window.location = 'HastaSayfasi.aspx?hastatc=" + HastaTC + "';", true);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Randevu Değiştirilmedi1'); window.location = 'RandevuGüncelle.aspx?randevuID=" + randevuID + "';", true);
                }

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Randevu Değiştirilmedi2'); window.location = 'RandevuGüncelle.aspx?randevuID=" + randevuID + "';", true);
            }


        }

    }
}