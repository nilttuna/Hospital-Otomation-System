using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pro_Lab2_Proje3
{
    public partial class HastaListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Hasta islem = new Hasta();
            DataList1.DataSource = islem.hasta_listele();
            DataList1.DataBind();
        }
    }
}