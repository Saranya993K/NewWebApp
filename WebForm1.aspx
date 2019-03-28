<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function myFunction() {
            debugger;
            
           var k = document.getElementById("uname").value;
           var j = document.getElementById("pwd").value;
            if (k == j) {
                alert("Login successful!");
                //Response.redirect("Demo.aspx");
                window.location.href = "Demo.aspx";
            }

            else
                alert("Please provide Same username and Password to Proceed");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" >
        <table border="2" align="center"><br /><br />
            <tr><center>Login Form</center></tr>
            <tr>
                <td><label for ="uname">User Name:</label></td>
                <td><input type="text" id="uname" name="uname" placeholder="Enter Username"></td>
            </tr>
            <tr>
                <td><label for="pwd">Password:</label></td>
                <td><input type="password" id="pwd" name="pwd" placeholder="Enter Password"></td>
            </tr>
       <tr align="center"><td colspan="2" >
                <input type="button" value="Submit" onclick="myFunction()">
           </td>
        </tr>
         </table>
    </form>
</body>
</html>



