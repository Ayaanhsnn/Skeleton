using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        
        //capture the username
        string Username = txtUsername.Text;
        //capture the password
        string Password = txtPassword.Text;
        //capture the address
        string Address = txtAddress.Text;
        //capture the dateofbirth
        string DateOfBirth = txtDateOfBirth.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(Username, Password, Address, DateOfBirth);
        if (Error == "")
        {
            //capture the username
            AnCustomer.Username = Username;
            //capture the password
            AnCustomer.Password = Password;
            //capture the address
            AnCustomer.Address = Address;
            //capture the dateofbirth
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //create a new instance of the customer collection 
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //set the ThisCustomer property
            CustomerList.ThisCustomer = AnCustomer;
            //add the new record
            CustomerList.Add();
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");

            
            
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 CustomerId;
        Boolean Found = false;
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        Found = AnCustomer.Find(CustomerId);
        if (Found == true)
        {
            txtUsername.Text = AnCustomer.Username;
            txtPassword.Text = AnCustomer.Password;
            txtAddress.Text = AnCustomer.Address;
            txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
        }
    }
}