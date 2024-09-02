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
    public partial class Hastalar : System.Web.UI.Page
    {
        sql_connection bgl =new sql_connection();

        protected void Page_Load(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            int doktorid =Convert.ToInt32( doktor.Doktorid);
            Label1.Text = "Doktor ID: " + doktorid;

            SqlDataReader rd=doktor.hasta_listele(doktorid);

            while(rd.Read())
            {
                string hastaID = rd[0].ToString();
                string adsoyad = rd[1].ToString()+" "+ rd[2].ToString(); 
                string dogumTarihi = rd[3].ToString();
                string cinsiyet = rd[4].ToString();
                string telefon = rd[5].ToString();
                string adres = rd[6].ToString();

                // Tabloya ekle
                HtmlTableRow row = new HtmlTableRow();
                HtmlTableCell cell1 = new HtmlTableCell();
                cell1.InnerText = hastaID;
                row.Cells.Add(cell1);

                HtmlTableCell cell2 = new HtmlTableCell();
                cell2.InnerText = adsoyad;
                row.Cells.Add(cell2);

                HtmlTableCell cell3 = new HtmlTableCell();
                cell3.InnerText = dogumTarihi;
                row.Cells.Add(cell3);

                HtmlTableCell cell4 = new HtmlTableCell();
                cell4.InnerText = cinsiyet;
                row.Cells.Add(cell4);

                HtmlTableCell cell5 = new HtmlTableCell();
                cell5.InnerText = telefon;
                row.Cells.Add(cell5);

                HtmlTableCell cell6 = new HtmlTableCell();
                cell6.InnerText = adres;
                row.Cells.Add(cell6);


                TableHastalar.Rows.Add(row);

            }
        }
    }
}