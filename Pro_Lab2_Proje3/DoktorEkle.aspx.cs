using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Pro_Lab2_Proje3
{
    public partial class DoktorEkle : System.Web.UI.Page
    {
        sql_connection bgl=new sql_connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropDownList(); 
                BindDropDownList2(); 
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Boolean alanlar_bos = false;
            
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text) || string.IsNullOrEmpty(TextBox6.Text)  )
            {
                alanlar_bos = true;
            }
            if (alanlar_bos)
            {
                Response.Write("<script>alert('Lütfen tüm alanları doldurunuz.');</script>");
                return;
            }
            Doktor islem = new Doktor();
            int satir=islem.doktor_ekle(TextBox1.Text, TextBox2.Text, TextBox6.Text,Convert.ToInt32( DropDownList2.SelectedValue), Convert.ToInt32(DropDownList1.SelectedValue));

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox6.Text = "";
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;

            if (satir > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Ekleme Başarılı'); window.location = 'YoneticiSayfası.aspx';", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Ekleme Başarısız'); window.location = 'DoktorEkle.aspx';", true);
            }



        }

        protected void BindDropDownList()
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Branslar", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DropDownList1.DataTextField = "Brans"; // Görünen metin için sütun adı
            DropDownList1.DataValueField = "BransID"; // Değer için sütun adı
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

            DropDownList2.DataTextField = "HastaneAdı"; // Görünen metin için sütun adı
            DropDownList2.DataValueField = "HastaneID"; // Değer için sütun adı
            DropDownList2.DataSource = dt;
            DropDownList2.DataBind();

            bgl.baglanti().Close();
        }
    }
}