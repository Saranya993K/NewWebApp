<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html>

<%--<html xmlns="http://www.w3.org/1999/xhtml">
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
                alert("please provide correct details")
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" >
        <table border="2" align="center"><br /><br />
            <tr><center>Login Form</center></tr>
            <tr>
                <td><label for ="username">User Name:</label></td>
                <td><input type="text" id="uname" name="uname" placeholder="Enter Username"></td>
            </tr>
            <tr>
                <td><label for="password">Password:</label></td>
                <td><input type="password" id="pwd" name="pwd" placeholder="Enter Password"></td>
            </tr>
       <tr align="center"><td colspan="2" >
                <input type="button" value="Submit" onclick="myFunction()">
           </td>
        </tr>
         </table>
    </form>
</body>
</html>--%>

<html>
<body>

<form>
  <%--<select id="Country" size="8" onload="myFunction()" onchange="populateStates(this)">--%>
     <select id="Country" size="8" onload="myFunction()" onchange="populateStates(this.options[this.selectedIndex].value)">
  </select>
    <select id="States" size="9" ></select>
</form>
<br>

<p>Click the button to add a "Kiwi" option at the end of the dropdown list.</p>

<button type="button" onclick="myFunction()">Insert option</button>

<script>
    function myFunction() {
        debugger;
        document.getElementById("States").style.visibility = "hidden";
        var x = document.getElementById("Country");   //Javascript object(x).
        //var listoption = ["India", "USA" ,"China"]; //Normal array representation of below format.
        var listoption = [
            {
                ID: 0,
                Value: "India"
            },
            {
                ID: 1,
                Value: "USA"
            },
            {
                ID: 2,
                Value: "China"
            }];

        for (i = 0; i < listoption.length; i++)
        {
            var option = document.createElement("option");
            option.innerHTML = listoption[i].Value; //Display text of combo
            option.value = listoption[i].ID; //ID part of combo
            //x.appendChild(option);  below the "x.add(option,i)" is also same
            x.add(option, i);
        }
    }

    function populateStates(element)
    {
        debugger;
        var element;
        var x = document.getElementById("States");
         switch (element)
            {
             case "India":
                 var listoption = [
                     { ID: 0, Value: "Maharastra" },
                     { ID: 1, Value: "TamilNadu" },
                     { ID: 2, Value: "Andhrapradesh" }
                 ];                    
                    break;
                case "USA":
                    states.Add(new ListItem("Canada", "1"));
                    states.Add(new ListItem("California", "2"));
                    states.Add(new ListItem("Florida", "3"));
                    break;
                case "China":
                    states.Add(new ListItem("Shandong", "1"));
                    states.Add(new ListItem("Yunnan", "2"));
                    states.Add(new ListItem("Fujian", "3"));
                    break;
                default:
                    states.Add(new ListItem("No Items", "1"));
                    break;                   
            }

        document.getElementById("States").style.visibility = "visible";

    }
</script>

</body>
</html>

