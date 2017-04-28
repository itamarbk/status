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
                    bool user_empty = Request["username"].Length == 0;
                    bool pswrd_empty = Request["password"].Length == 0;
                    bool age_empty = Request["age"].Length == 0;
                    bool city_empty = Request["city"].Length == 0;
                    bool stts_empty = Request["status"].Length == 0;
                SqlConnection conn = new SqlConnection(HELPER.connstring);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM users WHERE username='" + Request["username"] + "';";
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    message += "<p><font size=\"4\" ><b>this username is taken, try again</b></font></p>";
                    Response.Write("");
                }
                else if (Request["username"].Contains(" ") || Request["password"].Contains(" "))
                {
                    message += "<p><font size=\"4\" ><b>username and password must not contain spaces</b></font></p>";
                    Response.Write("");
                }
                else if (user_empty||pswrd_empty||age_empty||city_empty||stts_empty)
                {
                    message += "<p><font size=\"4\" ><b>please do not leave any of the fields empty</b></font></p>";
                    Response.Write("");
                }
                else
                {
                    conn.Close(); conn.Open();
                    cmd.CommandText = "INSERT INTO users (username, password, city, age, status) VALUES ('"
                        + Request["username"] + "', '"
                        + Request["password"] + "', '"
                        + Request["city"] + "', '"
                        + int.Parse(Request["age"]) + "', '"
                        + Request["status"] + "');";
                    cmd.ExecuteNonQuery();
                    Session["current user"] = Request["username"];
                    if(Application["user count"]==null)
                        Application["user count"]=0;
                    else
                        Application["user count"]=int.Parse(Application["user count"].ToString())+1;
                    conn.Close();
                    Response.Redirect("home page.aspx");
                }
                conn.Close();
            }
        }
    }
}
