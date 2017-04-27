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
        public string StatusInput = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["current user"] != null)
            {
                SqlConnection conn = new SqlConnection(HELPER.connstring);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM users WHERE username='" + Session["current user"] + "';";
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    UserData += "<font size=\"4\" ><b>" + rdr["username"].ToString() + "</b></font>";
                    UserData += "<br/>age:" + rdr["age"];
                    UserData += "<br/>city:" + rdr["city"];
                    StatusInput += "status <input type=\"text\" name=\"status\" value=\"" + rdr["status"] + "\" />";
                }
                conn.Close();
                //if (Requset.StatusUpdate["submit"] != null)
                {

                }
            }
            else
            {
                UserData += "<p><font size=\"4\" ><b>please <a href=\"login.aspx\">login</a> or <a href=\"WebForm1.aspx\">signup</a> in order to view your profile</b></font></p>";
            }
        }
    }
}