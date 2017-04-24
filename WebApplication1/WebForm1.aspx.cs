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
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string connstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"c:\\users\\user1\\documents\\visual studio 2010\\Projects\\WebApplication1\\WebApplication1\\App_Data\\Database1.mdf\";Integrated Security=True;User Instance=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["onsubmit"] == null)
            {
                if (Request["submit"] != null)
                {
                    SqlConnection conn = new SqlConnection(connstring);
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    //cmd.CommandText = "SELECT username FROM users WHERE username='" + Request["username"] + "';";
                    //if (cmd.ExecuteReader() == null||true)
                   /* {
                        cmd.CommandText = "INSERT INTO users (username, password, city, age, status) VALUES ('" + Request["username"] + "', '" + Request["password"] + "', '" + Request["city"] + "', '" + int.Parse(Request["age"]) + "', '" + Request["status"] + "');";
                        cmd.ExecuteNonQuery();
                    }*/
                   // else
                        Response.Write("<h1>this username is taken, try again</h1>");
                    conn.Close();

                }
            }
        }
    }
}