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
    public partial class login : System.Web.UI.Page
    {
        public string message = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["submit"] != null)
            {
                SqlConnection conn = new SqlConnection(HELPER.connstring);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM users WHERE username=" + Request["username"] + ";";
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr["password"].ToString() == Request["password"].ToString())
                    {
                        Session["current user"] = Request["username"];
                        Response.Redirect("home page.aspx");
                    }
                    else
                    {
                        message += "incorrect password, either try again or stop trying to hack " + Request["username"] + "'s user because this website does not have the resources to deal with hackers";
                        Response.Write("");
                    }
                }
                conn.Close();
            }
        }
    }
}