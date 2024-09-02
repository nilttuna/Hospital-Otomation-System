using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class DoktorSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Doktor islem = new Doktor();
            DataList1.DataSource = islem.doktor_listele();
            DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Doktor islemler = new Doktor();
            int kontrol = islemler.doktor_sil(Convert.ToInt32( TextBox1.Text));
            TextBox1.Text = "";
            if (kontrol > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "showalert", "alert('DOktor başarıyla silindi.');", true);
                Doktor islem = new Doktor();
                DataList1.DataSource = islem.doktor_listele();
                DataList1.DataBind();

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "showalert", "alert('Doktor  silinemedi. Aktif randevusu olabilir.');", true);

            }
        }
    }
}