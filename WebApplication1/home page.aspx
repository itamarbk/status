<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home page.aspx.cs" Inherits="WebApplication1.home_page" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Impress Me Home Page</title>
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
        <td><a href="logout.aspx">logout</a></td>
    </tr>
    </table>
    </div>
        <p>
            Hello <%=user %>, hope you will be impressed from the <%=Application["user count"] %> users
        </p>
    <div>
                <%=MyList %>
    </div>
</body>
</html>
