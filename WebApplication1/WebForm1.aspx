<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Impress Me Signup
    </title>
    <script type="text/javascript">
        function func() {
            var ps1 = document.getElementById("password").value;
            var ps2 = document.getElementById("password2").value;
            if (ps1 != ps2) {
                alert("the passwords do not match");
                return false;
            }
            else
                return true;
        }
    </script>
    <link rel="Stylesheet" href="StyleSheet1.css" type="text/css" />
</head>
<body class="StyleSheet1.css">
    <div>
    <h1>Impress Me</h1>
    <table width="100%" align="center">
    <tr>
        <td><a href="WebForm1.aspx">signup</a></td>
        <td><a href="login.aspx">login</a></td>
        <td><a href="home page.aspx">home page</a></td>
        <td><a href="profile.aspx">profile</a></td>
    </tr>
    </table>
    </div>
    <form id="signup" runat="server" onsubmit="return func();">
    <div>
    <p><%=message %></p>
        <p>
            username <input type="text" name="username" />
        </p>
        <p>
            password <input type="text" name="password" id="password" />
        </p>
        <p>
            re-type password <input type="text" name="password2" id="password2" />
        </p>
        <p>
            city <input type="text" name="city" />
        </p>
        <p>
            age <input type="number" name="age" />
        </p>
        <p>
            status <input type="text" name="status" />
        </p>
        <p>
            <input type="submit" name ="submit" />
        </p>
    </div>
    </form>
</body>
</html>
