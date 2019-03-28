<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="WebApp.Demo" %>

<!DOCTYPE html>

<%-- Section which includes the logic from backend page(Demo.aspx.cs)CodeBehind --%>
<%--<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <asp:DropDownList ID="Country" runat="server" OnSelectedIndexChanged="Country_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <asp:DropDownList ID="States" runat="server" Visible="false" ></asp:DropDownList>
        </div>
    </form>
</body>
</html>--%>


<%-- Section which includes only javascript --%>

<html xmlns="http://www.w3.org/1999/xhtml">
<body onload="myFunction();" style="text-align:center;">
    <h2>Simple Combo Selections </h2>
<form>  
    <div>
    <label for="Country" style="font:12px;"><b>Select Country:</b></label>  <%-- 'for' attribute describes for which 
        control(e.g, here its for country, the name inside 'for' attribute is same as the control's id value --%>
     <select id="Country"  style="width:50%; margin-left: 14px;" onchange="populateStates(this.options[this.selectedIndex])">  </select>
        </div>
    <br /><div id="DivState" style="text-align:left; ">
    <label for="States" style="font:12px; margin-left:194px;"><b>Select States:</b></label>
    <select id="States" style="width:50%; margin-left:29px;" onchange="selectedOption();"></select>
        </div>

    <p id="display"></p>
</form>

<script>
    function myFunction() {
       // debugger;
        document.getElementById("DivState").style.visibility = "hidden";
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

        for (i = 0; i < listoption.length; i++) {
            var option = document.createElement("option");
            option.innerHTML = listoption[i].Value; //Display text of combo
            option.value = listoption[i].ID; //ID part of combo
            //x.appendChild(option);  below the "x.add(option,i)" is also same
            x.add(option, i);
        }
    }

    function populateStates(element) {
       // debugger;
        //var element;     // Hoisiting concept, we shall directly use the variable without declarations.
        var states = document.getElementById("States");
        document.getElementById("DivState").style.visibility = "visible";
        document.getElementById("display").innerHTML = "";   //selected country and state value is assigned to null when a change in country selection.
        switch (element.innerHTML) {
            case "India":
                var listoption = [
                    { ID: 0, Value: "Maharastra" },
                    { ID: 1, Value: "TamilNadu" },
                    { ID: 2, Value: "Andhrapradesh" }
                ];
                break;

            case "USA":
                var listoption = [
                    { ID: 0, Value: "Canada" },
                    { ID: 1, Value: "California" },
                    { ID: 2, Value: "Florida" }
                ];
                break;

            case "China":
                var listoption = [
                    { ID: 0, Value: "Shandong" },
                    { ID: 1, Value: "Yunnan" },
                    { ID: 2, Value: "Fujian" }
                ];
                break;

            default:
                var listoption = [{ ID: 0, Value: "No Items" }];
                break;
        }
        states.innerText = "";    //To clear the elements which are already inserted.
        for (i = 0; i < listoption.length; i++) {
            var option = document.createElement("option");
            option.innerHTML = listoption[i].Value; //Display text of combo
            option.value = listoption[i].ID; //ID part of combo
            //states.appendChild(option);  below the "states.add(option,i)" is also same
            states.add(option, i);
        }
    }

    function selectedOption() {
        //debugger;
        var countrySelected = "";
        var stateSelected = "";
        document.getElementById("display").innerHTML = "";
        countrySelected = document.getElementById("Country");
        stateSelected = document.getElementById("States");
        var cntry = countrySelected.options[countrySelected.selectedIndex];
        var state = stateSelected.options[stateSelected.selectedIndex];
        document.getElementById("display").innerHTML = "<h2>Your country is  " + cntry.innerHTML + "  " + "State is " + state.innerHTML + "</h2>";
        //document.writeln("<h2>Your country is  "+ cntry.innerHTML+"  "+ "State is "+state.innerHTML+"</h2>")
    }
</script>

</body>
</html>