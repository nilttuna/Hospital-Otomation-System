using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class HastaSayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string hastatc = Request.QueryString["hastatc"];

            Response.Redirect("HastaBilgisi.aspx?hastatc=" + hastatc);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string hastatc = Request.QueryString["hastatc"];

            Response.Redirect("HastaBilgisiGüncelle.aspx?hastatc=" + hastatc);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnaSayfa.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string hastatc = Request.QueryString["hastatc"];
            Response.Redirect("RandevuAl.aspx?hastatc=" + hastatc);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string hastatc = Request.QueryString["hastatc"];
            Response.Redirect("Randevularım.aspx?hastatc=" + hastatc);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string hastatc = Request.QueryString["hastatc"];
            Response.Redirect("GecmisRandevularım.aspx?hastatc=" + hastatc);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string hastatc = Request.QueryString["hastatc"];
            Response.Redirect("Raporlar.aspx?hastatc=" + hastatc);
        }
    }
}