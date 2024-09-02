using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class DoktorGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void BtnGiris_Click1(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            doktor.Doktorid = TextBox1.Text;
            doktor.Sifre = TextBox2.Text;

            if (doktor.giris_kontrol(doktor.Doktorid, doktor.Sifre))
            {

                string doktorid = TextBox1.Text;


                Response.Redirect("DoktorSayfa.aspx?doktorid=" + doktorid);

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Hatalı kullanıcı adı veya şifre!');", true);
            }

        }
    }

 }