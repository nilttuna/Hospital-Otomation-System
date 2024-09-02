using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class DoktorSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string doktorid = Request.QueryString["doktorid"];
            Response.Redirect("DoktorBilgileri.aspx?doktorid=" + doktorid);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string doktorid = Request.QueryString["doktorid"];
            Response.Redirect("DoktorBilgiGuncelle.aspx?doktorid=" + doktorid);
  
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string doktorid = Request.QueryString["doktorid"];
            Response.Redirect("Hastalar.aspx?doktorid=" + doktorid);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string doktorid = Request.QueryString["doktorid"];
            Response.Redirect("DoktorRaporlar.aspx?doktorid=" + doktorid);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnaSayfa.aspx");
        }
    }
}