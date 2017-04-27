using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WebApplication1
{
    public partial class profile : System.Web.UI.Page
    {
        public string UserData = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            UserData = "";
            if (Session["current user"] != null)
            {
                SqlConnection conn = new SqlConnection(HELPER.connstring);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM users WHERE username='" + Session["current user"] + "';";
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    UserData += "<form id=\"StatusUpdate\" runat=\"server\"><p>";
                    UserData += "<font size=\"4\" ><b>" + rdr["username"].ToString() + "</b></font>";
                    UserData += "<br/>age:" + rdr["age"];
                    UserData += "<br/>city:" + rdr["city"];
                    UserData += "<br/>status <input type=\"text\" name=\"status\" value=\"" + rdr["status"] + "\" />";
                    UserData += "<input type=\"submit\" name =\"submit\" value=\"update\" /></p></form>";
                }
                conn.Close();
                if (Request["submit"] != null)
                {
                    SqlConnection conn2 = new SqlConnection(HELPER.connstring);
                    conn.Open();
                    SqlCommand cmd2 = conn.CreateCommand();
                    cmd.CommandText = "UPDATE password FROM users WHERE username='" + Session["current user"] + "' TO '"+Request["status"]+"';";
                }
            }
            else
            {
                UserData += "<p><font size=\"4\" ><b>please <a href=\"login.aspx\">login</a> or <a href=\"WebForm1.aspx\">signup</a> in order to view your profile</b></font></p>";
            }
        }
    }
}