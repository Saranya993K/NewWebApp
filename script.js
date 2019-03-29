
    function myFunction() {
        debugger;
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

        for (i = 0; i < listoption.length; i++)
        {
            var option = document.createElement("option");
            option.innerHTML = listoption[i].Value; //Display text of combo
            option.value = listoption[i].ID; //ID part of combo
            //x.appendChild(option);  below the "x.add(option,i)" is also same
            x.add(option, i);
        }
    }

    function populateStates(element) {
        debugger;
        //var element;     // Hoisiting concept, we shall directly use the variable without declarations.
        var states = document.getElementById("States");
        document.getElementById("DivState").style.visibility = "visible";
        document.getElementById("display").innerHTML = "";   //selected country and state value is assigned to null when a change in country selection.
		var listoption;
        switch (element.innerHTML)
        {
            case "India":
                listoption = [
                    { ID: 0, Value: "Maharastra" },
                    { ID: 1, Value: "TamilNadu" },
                    { ID: 2, Value: "Andhrapradesh" }
                ];            
                break;

            case "USA":
                listoption = [
                    { ID: 0, Value: "Canada" },
                    { ID: 1, Value: "California" },
                    { ID: 2, Value: "Florida" }
                ]; 
                break;

            case "China":
                listoption = [
                    { ID: 0, Value: "Shandong" },
                    { ID: 1, Value: "Yunnan" },
                    { ID: 2, Value: "Fujian" }
                ]; 
                break;

            default:
                listoption = [{ ID: 0, Value: "No Items" }];
                break;
        }
        states.innerText = "";    //To clear the elements which are already inserted.
        for (i = 0; i < listoption.length; i++)
        {
            var option = document.createElement("option");
            option.innerHTML = listoption[i].Value; //Display text of combo
            option.value = listoption[i].ID; //ID part of combo
            //states.appendChild(option);  below the "states.add(option,i)" is also same
            states.add(option, i);
        }		
    }
    function selectedOption() {
        debugger;
        var countrySelected = "";
        var stateSelected = "";
        document.getElementById("display").innerHTML = "";
         countrySelected = document.getElementById("Country");
         stateSelected = document.getElementById("States");
        var cntry = countrySelected.options[countrySelected.selectedIndex];
        var state = stateSelected.options[stateSelected.selectedIndex];
        document.getElementById("display").innerHTML="<h2>Your country is  "+ cntry.innerHTML+"  "+ "State is "+state.innerHTML+"</h2>";
        //document.writeln("<h2>Your country is  "+ cntry.innerHTML+"  "+ "State is "+state.innerHTML+"</h2>")
    }

