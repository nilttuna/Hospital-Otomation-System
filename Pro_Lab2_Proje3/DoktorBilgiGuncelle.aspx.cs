using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class DoktorBilgiGuncelle : System.Web.UI.Page
    {
        sql_connection bgl = new sql_connection();
        Doktor doktor = new Doktor();

        protected void Page_Load(object sender, EventArgs e)
        {
            string doktorid = doktor.Doktorid;

            if (!IsPostBack)

            {
                BindDropDownList();
                BindDropDownList2();
                
                SqlCommand komut = new SqlCommand("SELECT d.DoktorID, d.DoktorAd, d.DoktorSoyad, d.DoktorSifre, d.Hastane  ,d.UzmanlikAlan FROM Tbl_Doktorlar d where DoktorID='" + doktorid + "'", bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TextBox7.Text = dr[0].ToString();
                    TextBox1.Text = dr[1].ToString();
                    TextBox2.Text = dr[2].ToString();
                    TextBox6.Text = dr[3].ToString();
                    DropDownList1.SelectedValue = dr[5].ToString();
                    DropDownList2.SelectedValue = dr[4].ToString();

                }

                dr.Close();
                bgl.baglanti().Close();
                



            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Boolean alanlar_bos = false;

            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text) || string.IsNullOrEmpty(TextBox6.Text))
            {
                alanlar_bos = true;
            }
            if (alanlar_bos)
            {
                Response.Write("<script>alert('Lütfen tüm alanları doldurunuz.');</script>");
                return;
            }
            Doktor islem = new Doktor();
            int satir = islem.doktor_guncelle(Convert.ToInt32(TextBox7.Text), TextBox1.Text, TextBox2.Text, TextBox6.Text, Convert.ToInt32(DropDownList2.SelectedValue), Convert.ToInt32(DropDownList1.SelectedValue));

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;

            string doktorid = doktor.Doktorid;

            if (satir > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Güncelleme Başarılı'); window.location = 'DoktorSayfa.aspx?doktorid=" + doktorid + "';", true);

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Güncelleme Başarısız'); window.location = 'DoktorSayfa.aspx?doktorid=" + doktorid + "';", true);
            }

        }

        protected void BindDropDownList()
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Branslar", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DropDownList1.DataTextField = "Brans"; 
            DropDownList1.DataValueField = "BransID"; 
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();

            bgl.baglanti().Close();
        }
        protected void BindDropDownList2()
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastane", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DropDownList2.DataTextField = "HastaneAdı"; 
            DropDownList2.DataValueField = "HastaneID"; 
            DropDownList2.DataSource = dt;
            DropDownList2.DataBind();

            bgl.baglanti().Close();
        }
    }
}