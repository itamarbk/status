using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class home_page : System.Web.UI.Page
    {
        public string MyList = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(HELPER.connstring);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM users;";
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                MyList += "<p><font size=\"4\" ><b>" + rdr["username"].ToString() + "</b></font>";
                MyList += "<br/>age:" + rdr["age"];
                MyList += "<br/>city:" + rdr["city"];
                MyList += "<br/><font size=\"5\" ><b>" + rdr["status"] + "</b></font></p>";
            }
            conn.Close();
        }
    }
}