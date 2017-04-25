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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["onsubmit"] == null)
            {
                if (Request["submit"] != null)
                {
                    SqlConnection conn = new SqlConnection(HELPER.connstring);
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    //cmd.CommandText = "SELECT username FROM users WHERE username='" + Request["username"] + "';";
                    //if (cmd.ExecuteReader() == null||true)
                    {
                        cmd.CommandText = "INSERT INTO users (username, password, city, age, status) VALUES ('" + Request["username"] + "', '" + Request["password"] + "', '" + Request["city"] + "', '" + int.Parse(Request["age"]) + "', '" + Request["status"] + "');";
                        cmd.ExecuteNonQuery();
                    }
                   // else
                     //   Response.Write("<h1>this username is taken, try again</h1>");
                    conn.Close();

                }
            }
        }
    }
}
/*
    <script type="text/javascript">
        function func() {
            var ps1=signup["password"];
            var ps2=signup["password2"];
            if (ps1==ps2) {
                alert("the passwords do not match");
                return false;
            }
            else
            return true;
        }
    </script>*/