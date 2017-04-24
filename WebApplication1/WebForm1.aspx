<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
    </title>
    <script>
        function func() {
            if (signup["password"] != signup["password2"]) {
                alert("the passwords do not match");
                return false;
            }
            else
            return true;
        }
    </script>
</head>
<body>
    <form id="signup" runat="server" onsubmit="func();">
    <div>
        username <input type="text" name="username" /><br />
        password <input type="text" name="password" /><br />
        re-type password <input type="text" name="password2" /><br />
        city <input type="text" name="city" /><br />
        age <input type="number" name="age" /><br />
        status <input type="text" name="status" /><br />
        <input type="submit" name ="submit" /><br />
    </div>
    </form>
</body>
</html>
