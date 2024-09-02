using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class YoneticiGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        protected void BtnGiris_Click1(object sender, EventArgs e)
        {
            Yonetici yonetici = new Yonetici();
            yonetici.Yoneticiid = TextBox1.Text;
            yonetici.Sifre = TextBox2.Text;

            if (yonetici.giris_kontrol(yonetici.Yoneticiid, yonetici.Sifre))
            {
                Response.Redirect("YoneticiSayfası.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Hatalı kullanıcı adı veya şifre!');", true);
            }
        }
    }
}