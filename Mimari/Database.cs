using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Mimari
{
    class Database
    {
        SqlConnection conn;
        SqlCommand cmd;
        public void Baglan()
        {
            conn = new SqlConnection("Data Source=DESKTOP-4KG79CQ\\SQLEXPRESS;Initial Catalog=SigmaSinav;Integrated Security=True");
        }
    }
}
