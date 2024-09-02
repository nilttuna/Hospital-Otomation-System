using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class HastaSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Hasta islem = new Hasta();
            DataList1.DataSource = islem.hasta_listele();
            DataList1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Hasta islemler = new Hasta();
            int kontrol=islemler.hasta_sil(TextBox1.Text);
            TextBox1.Text = "";
            if(kontrol>0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "showalert", "alert('Hasta başarıyla silindi.');", true);
                Hasta islem = new Hasta();
                DataList1.DataSource = islem.hasta_listele();
                DataList1.DataBind();

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "showalert", "alert('Hasta  silinemedi.');", true);

            }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
