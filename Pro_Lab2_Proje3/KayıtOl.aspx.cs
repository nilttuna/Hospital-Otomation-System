using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class KayıtOl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string cinsiyet = "";
            Boolean alanlar_bos = false;
            string tarih = Text1.Value;


            if (TextBox1.Text.Length > 11 || TextBox1.Text.Length < 11)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Hatalı TC');", true);
                return;
            }


            cinsiyet = ddlCinsiyet.Value;

            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text) || string.IsNullOrEmpty(TextBox3.Text) || string.IsNullOrEmpty(tarih) || string.IsNullOrEmpty(cinsiyet) || string.IsNullOrEmpty(TextBox5.Text) || string.IsNullOrEmpty(TextBox5.Text) || string.IsNullOrEmpty(TextBox6.Text))
            {
                alanlar_bos = true;
            }
            if (alanlar_bos)
            {
                Response.Write("<script>alert('Lütfen tüm alanları doldurunuz.');</script>");
                return;
            }


            Hasta islem = new Hasta();
            int satir = islem.hasta_ekle(TextBox1.Text, TextBox2.Text, TextBox3.Text, tarih, cinsiyet, TextBox4.Text, TextBox5.Text, TextBox6.Text);

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Text1.Value = "";
            tarih = "";
            ddlCinsiyet.SelectedIndex = 0;
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";

            if (satir > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Kayıt Başarılı'); window.location = 'HastaGiris.aspx';", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Kayıt Başarısız'); window.location = 'KayıtOl.aspx';", true);
            }

        }
    }
}