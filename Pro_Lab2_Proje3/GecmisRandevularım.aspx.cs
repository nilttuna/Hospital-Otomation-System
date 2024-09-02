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
    public partial class GecmisRandevularım : System.Web.UI.Page
    {
        sql_connection bgl=new sql_connection();
        Hasta hasta=new Hasta();
        protected void Page_Load(object sender, EventArgs e)
        {
            string hastatc = hasta.HastaTC ;
            Label1.Text = "Hasta ID: " + hastatc;

            Randevu randevu = new Randevu();
            SqlDataReader rd = randevu.Gecmis_randevu_listele(hastatc);

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



                TableRandevular.Rows.Add(row);

            }
            rd.Close();
            bgl.baglanti().Close();

        }
    }
}