using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class KayıtSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Hasta hastaTCbilgisi = new Hasta();
            TextBox1.Text = hastaTCbilgisi.HastaTC;
        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            Hasta hasta=new Hasta();
            
            int etkilenen_satir_sayisi = hasta.kayıt_sil(TextBox1.Text, TextBox2.Text);

            if (etkilenen_satir_sayisi > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "showalert", "alert('Kayıt başarıyla silindi.');window.location = 'AnaSayfa.aspx';", true);
             
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "showalert", "alert('Kayıt  silinemedi.');", true);

            }
        }
    }
}