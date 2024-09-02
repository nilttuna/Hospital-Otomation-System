using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class HastaBilgisiGüncelle : System.Web.UI.Page
    {
        sql_connection bgl=new sql_connection();
        Hasta hasta=new Hasta();
        protected void Page_Load(object sender, EventArgs e)
        {
            string hastatc = hasta.HastaTC;
            

            if (!IsPostBack)

            {

                SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar  where HastaTC='" + hastatc + "'", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    DateTime dateTime = Convert.ToDateTime(dr[3]);
                    TextBox1.Text = dr[0].ToString();
                    TextBox2.Text = dr[1].ToString();
                    TextBox3.Text = dr[2].ToString();
                    Text1.Value = dateTime.ToString("yyyy-MM-dd");
                    ddlCinsiyet.Value = dr[4].ToString();
                    TextBox4.Text = dr[5].ToString();
                    TextBox5.Text = dr[6].ToString();
                    TextBox6.Text = dr[7].ToString();

                }
                dr.Close();
                bgl.baglanti().Close();



            }
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
            Text1.Value = "";
            tarih = "";
            ddlCinsiyet.SelectedIndex= 0;
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";

            string hastatc = Request.QueryString["hastatc"];
            if(satir>0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Güncelleme Başarılı'); window.location = 'HastaSayfasi.aspx?hastatc=" + hastatc + "';", true);

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Güncelleme Başarısız'); window.location = 'HastaSayfasi.aspx?hastatc=" + hastatc + "';", true);

            }

        }

    }
}