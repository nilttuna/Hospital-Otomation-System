using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Globalization;

namespace Pro_Lab2_Proje3
{
    public partial class HastaGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Hasta islem = new Hasta();
            DataList1.DataSource = islem.hasta_listele();
            DataList1.DataBind();
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";
            Boolean alanlar_bos = false;

            string tarih = Text1.Value;

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
            int satir=islem.hasta_guncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, tarih, cinsiyet, TextBox4.Text, TextBox5.Text, TextBox6.Text);

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            tarih = "";
            ddlCinsiyet.SelectedIndex = 0;
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";

            if (satir > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Güncelleme Başarılı')", true );
                Hasta islem2 = new Hasta();
                DataList1.DataSource = islem.hasta_listele();
                DataList1.DataBind();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Güncelleme hatası: İşlem başarısız.');", true);
            }



        }

    
    }
}