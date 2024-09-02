using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class DoktorGuncelle : System.Web.UI.Page
    {
        sql_connection bgl = new sql_connection();

        protected void Page_Load(object sender, EventArgs e)
        {
            Doktor islem = new Doktor();
            DataList1.DataSource = islem.doktor_listele();
            DataList1.DataBind();
            if (!IsPostBack)
            {
                BindDropDownList();
                BindDropDownList2();
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

            if (satir > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Güncelleme Başarılı')", true);
                Doktor islem2 = new Doktor();
                DataList1.DataSource = islem.doktor_listele();
                DataList1.DataBind();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Güncelleme hatası: İşlem başarısız.');", true);
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