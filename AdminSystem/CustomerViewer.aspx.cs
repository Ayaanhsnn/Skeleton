using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        clsCustomer AnCustomer = new clsCustomer();
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the customer Id for this entry
        Response.Write(AnCustomer.CustomerId + "\n\n");
        Response.Write(AnCustomer.Username + "\n\n");
        Response.Write(AnCustomer.Password + "\n\n");
        Response.Write(AnCustomer.Address + "\n\n");
        Response.Write(AnCustomer.DateOfBirth + "\n\n");
        Response.Write(AnCustomer.ReceiveMail + "\n\n");


    }
}