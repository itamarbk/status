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
    public class HELPER
    {
        public static string connstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\tbaic\\Documents\\GitHub\\status\\WebApplication1\\App_Data\\Database2.mdf;Integrated Security=True;User Instance=True";
    }
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string message = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["submit"] != null)
            {
                SqlConnection conn = new SqlConnection(HELPER.connstring);
                conn.Open();
                try 
                {
                    SqlCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandText = "SELECT * FROM users WHERE username='" + Request["username"] + "';";
                    SqlDataReader rdr=cmd1.ExecuteReader();
                    string s=rdr["username"].ToString();
                    if (s == "" || s == null)
                    {
                        rdr.Close();
                        throw new Exception();
                    }
                    message+="<h1>this username is taken, try again</h1>";
                }
                catch(Exception exp)
                {
                    conn.Close(); conn.Open();
                    SqlCommand cmd2 = conn.CreateCommand();
                    cmd2.CommandText = "INSERT INTO users (username, password, city, age, status) VALUES ('"
                        + Request["username"] + "', '"
                        + Request["password"] + "', '"
                        + Request["city"] + "', '"
                        + int.Parse(Request["age"]) + "', '"
                        + Request["status"] + "');";
                    
                    cmd2.ExecuteNonQuery();
                }
                conn.Close();
                Session["current user"] = Request["username"];
                Response.Redirect("home page.aspx");
            }
        }
    }
}
