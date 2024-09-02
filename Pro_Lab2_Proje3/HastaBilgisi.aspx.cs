using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class HastaBilgisi : System.Web.UI.Page
    {
        sql_connection bgl=new sql_connection();
        Hasta hasta = new Hasta();
        protected void Page_Load(object sender, EventArgs e)
        {
            string hastatc = hasta.HastaTC;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC= '" + hastatc + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            DataList1.DataSource = dr;
            DataList1.DataBind();
        }
    }
}