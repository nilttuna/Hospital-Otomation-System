using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class Randevularım : System.Web.UI.Page
    {
        sql_connection bgl = new sql_connection();

        protected void Page_Load(object sender, EventArgs e)
        {
            string hastatc = Request.QueryString["hastatc"];
            Label1.Text = "Hasta ID: " + hastatc;

            Randevu randevu=new Randevu();
            SqlDataReader rd = randevu.Aktif_randevu_listele(hastatc);


            while (rd.Read())
            {
                string hastaneAdi = rd[0].ToString();
                string brans = rd[1].ToString();
                string doktor = rd[2].ToString() + " " + rd[3].ToString();
                string tarih = rd[4].ToString();
                string saat = rd[5].ToString();
                string notlar = rd[6].ToString();
                string randevuID = rd[7].ToString();

                // Tabloya ekle
                HtmlTableRow row = new HtmlTableRow();

                HtmlTableCell cell1 = new HtmlTableCell();
                cell1.InnerHtml = hastaneAdi;
                row.Cells.Add(cell1);

                HtmlTableCell cell2 = new HtmlTableCell();
                cell2.InnerText = brans;
                row.Cells.Add(cell2);

                HtmlTableCell cell3 = new HtmlTableCell();
                cell3.InnerText = doktor;
                row.Cells.Add(cell3);

                HtmlTableCell cell4 = new HtmlTableCell();
                cell4.InnerText = tarih;
                row.Cells.Add(cell4);

                HtmlTableCell cell5 = new HtmlTableCell();
                cell5.InnerText = saat;
                row.Cells.Add(cell5);

                HtmlTableCell cell6 = new HtmlTableCell();
                cell6.InnerText = notlar;
                row.Cells.Add(cell6);

                HtmlTableCell cell7 = new HtmlTableCell();
                Button btnIptalEt = new Button();
                btnIptalEt.Text = "iptal et";
                btnIptalEt.ID = "btnIptalEt_" + randevuID;
                btnIptalEt.CommandArgument = randevuID; // Butonun CommandArgument özelliğini randevu ID'sine ayarlayın
                btnIptalEt.Click += btnIptalEt_Click;
                cell7.Controls.Add(btnIptalEt);
                row.Cells.Add(cell7);

                HtmlTableCell cell8 = new HtmlTableCell();
                Button btnGuncelle = new Button();
                btnGuncelle.Text = "Güncelle";
                btnGuncelle.ID = "btnGuncelle_" + randevuID;
                btnGuncelle.CommandArgument = randevuID; // Butonun CommandArgument özelliğini randevu ID'sine ayarlayın
                btnGuncelle.Click += btnGuncelle_Click;
                cell8.Controls.Add(btnGuncelle);
                row.Cells.Add(cell8);


                TableRandevular.Rows.Add(row);

            }
            rd.Close();
            bgl.baglanti().Close();

        }

        protected void btnIptalEt_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            Button clickedButton = (Button)sender;
            string randevuID = clickedButton.CommandArgument;

            int etkilenen_satir = randevu.randevu_sil(randevuID);

            if (etkilenen_satir > 0)
            {
                Response.Write("<script>alert('Randevu iptal edildi.');</script>");


                // Randevu iptal edildikten sonra sayfayı yeniden yükle
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                Response.Write("Randevu iptal edilirken bir hata oluştu.");
            }


        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            Button clickedButton = (Button)sender;
            string randevuID = clickedButton.CommandArgument;

            Response.Redirect("RandevuGüncelle.aspx?randevuID=" + randevuID);
        }

    }
}