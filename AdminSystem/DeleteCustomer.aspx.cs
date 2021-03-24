using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteCustomer : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted 
    Int32 CustomerId;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address book 
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to delete 
        CustomerBook.ThisCustomer.Find(CustomerId);
        //delete the record
        CustomerBook.Delete();
        //redirect back to the main page
        Response.Redirect("CustomerList.aspx");
       


    }
}