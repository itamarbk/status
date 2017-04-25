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
            SqlDataReader rdr2 = cmd.ExecuteReader();
            while (rdr2.Read())
            {
                {
                    SqlCommand cmd2 = conn.CreateCommand();
                        cmd2.CommandText = "Select * From users WHERE username='" + rdr2["username"] + "';";
                    //SqlDataReader rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        MyList += "<p><font size=\"4\" ><b>" + rdr2["username"].ToString() + "</b></font>";
                        MyList += "<br/>age:" + rdr2["age"];
                        MyList += "<br/>city:" + rdr2["city"];
                        MyList += "<br/><font size=\"4\" ><b>" + rdr2["status"] + "</b></font></p>";
                    }
                }
            }
            conn.Close();
        }
    }
}