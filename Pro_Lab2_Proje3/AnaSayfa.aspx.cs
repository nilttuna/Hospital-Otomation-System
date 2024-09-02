using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Doktor_Click(object sender, EventArgs e)
        {
            DoktorGiris dr=new DoktorGiris();   
            Response.Redirect("DoktorGiris.aspx");
        }

        protected void Hasta_Click(object sender, EventArgs e)
        {
            Response.Redirect("HastaGiris.aspx");
        }

        protected void Yonetici_Click(object sender, EventArgs e)
        {
            Response.Redirect("YoneticiGiris.aspx");
        }
    }
}