<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="WebApplication1.profile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Impress Me Profile</title>
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
    <div>
            <%=UserData %>
    </div>
</body>
</html>
