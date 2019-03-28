using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Demo : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!Page.IsPostBack)
        //    {
        //        List<ListItem> country = new List<ListItem>();
        //        country.Add(new ListItem("Select Country", "Select"));
        //        country.Add(new ListItem("India", "India"));
        //        country.Add(new ListItem("USA", "USA"));
        //        country.Add(new ListItem("China", "China"));

        //        //country.Sort(delegate (ListItem item1, ListItem item2) { return item1.Text.CompareTo(item2.Text); });
        //        Country.Items.AddRange(country.ToArray());
        //    }
        //}      

        //protected void Country_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    States.Visible = true;
        //    var item = Country.SelectedValue;
        //    List<ListItem> states = new List<ListItem>();
            
        //    switch (item)
        //    {
        //        case "India":
        //            states.Add(new ListItem("Maharastra","1"));
        //            states.Add(new ListItem("TamilNadu", "2"));
        //            states.Add(new ListItem("Andhrapradesh", "3"));
        //            break;
        //        case "USA":
        //            states.Add(new ListItem("Canada", "1"));
        //            states.Add(new ListItem("California", "2"));
        //            states.Add(new ListItem("Florida", "3"));
        //            break;
        //        case "China":
        //            states.Add(new ListItem("Shandong", "1"));
        //            states.Add(new ListItem("Yunnan", "2"));
        //            states.Add(new ListItem("Fujian", "3"));
        //            break;
        //        default:
        //            states.Add(new ListItem("No Items", "1"));
        //            break;                   
        //    }
        //    States.Items.Clear();
        //    //States.DataSource = states.ToArray();
        //    States.Items.AddRange(states.ToArray());
        //}
    }
}