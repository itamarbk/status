using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        public string message = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            bool user_exists = false;
            if (Request["submit"] != null)
            {
                SqlConnection conn = new SqlConnection(HELPER.connstring);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM users WHERE username='" + Request["username"] + "';";
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    user_exists = true;
                    Debug.WriteLine("'"+rdr["password"].ToString() + "'" + Request["password"]+"'");
                    if (rdr["password"].ToString().TrimEnd(' ') == Request["password"])
                    {
                        Session["current user"] = Request["username"];
                        conn.Close();
                        Response.Redirect("home page.aspx");
                    }
                    else if (rdr["password"].ToString().Length!=0)
                    {
                        message += "<p>incorrect password, either try again or stop trying to hack " + Request["username"] + "'s user because this website does not have the resources to deal with hackers</p>";
                        Response.Write("");
                    }
                }
                conn.Close();
                if(!user_exists)
                {
                    message += "<p>incorrect username, please try again or <a href=\"WebForm1.aspx\">signup</a> if you do not have a user</p>";
                    Response.Write("");
                }
            }
        }
    }
}