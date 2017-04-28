<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Impress Me Login</title>
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
    <form id="form1" runat="server">
    <div>
            <%=message %>
         <p>
            username <input type="text" name="username" />
        </p>
        <p>
            password <input type="text" name="password" />
        </p>
        <p>
           <input type="submit"" name="submit" value="login" /> 
        </p>
    </div>
    </form>
</body>
</html>
