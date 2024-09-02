using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class DoktorBilgileri : System.Web.UI.Page
    {
        sql_connection bgl = new sql_connection();
        Doktor doktor = new Doktor();
        protected void Page_Load(object sender, EventArgs e)
        {
            string doktorid = doktor.Doktorid;

            SqlCommand komut = new SqlCommand("SELECT d.DoktorID, d.DoktorAd, d.DoktorSoyad, d.DoktorSifre, h.HastaneAdı  ,b.Brans\r\nFROM Tbl_Doktorlar d \r\nINNER JOIN Tbl_Hastane h ON d.Hastane = h.HastaneID\r\nINNER JOIN Tbl_Branslar b ON d.UzmanlikAlan = b.BransID where DoktorID= '" + doktorid + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
        }
    }
}