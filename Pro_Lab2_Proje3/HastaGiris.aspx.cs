using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class HastaGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void BtnGiris_Click1(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.HastaTC = TextBox1.Text;
            hasta.Sifre = TextBox2.Text;
            if(hasta.HastaTC.Length>11 || hasta.HastaTC.Length<11)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Hatalı kullanıcı adı veya şifre!');", true);
            }
            if (hasta.giris_kontrol(hasta.HastaTC, hasta.Sifre))
            {
                string hastatc = TextBox1.Text;

                Response.Redirect("HastaSayfasi.aspx?hastatc=" + hastatc);

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Hatalı kullanıcı adı veya şifre!');", true);
            }

        }
    }
}