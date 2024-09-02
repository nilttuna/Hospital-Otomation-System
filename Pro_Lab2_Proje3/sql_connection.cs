using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Pro_Lab2_Proje3
{
    public class sql_connection
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=Nil\\SQLEXPRESS;Initial Catalog=Proje3_Hastane_Yönetim_Sistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }

}

