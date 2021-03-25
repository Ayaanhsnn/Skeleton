using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }



    }

    void DisplayCustomers()
    {
        //create an instance of the CustomerBook
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update 
        CustomerBook.ThisCustomer.Find(CustomerId);
        //display the data  for this record
        txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
        txtUsername.Text = CustomerBook.ThisCustomer.Username;
        txtPassword.Text = CustomerBook.ThisCustomer.Password;
        txtAddress.Text = CustomerBook.ThisCustomer.Address;
        txtDateOfBirth.Text = CustomerBook.ThisCustomer.DateOfBirth.ToString();
        chkReceiveMail.Checked = CustomerBook.ThisCustomer.ReceiveMail;
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
            //capture the CustomerId
            AnCustomer.CustomerId = CustomerId;
            //capture the username
            AnCustomer.Username = Username;
            //capture the password
            AnCustomer.Password = Password;
            //capture the address
            AnCustomer.Address = Address;
            //capture the dateofbirth
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //capture receiveMail
            AnCustomer.ReceiveMail = chkReceiveMail.Checked;
            //create a new instance of the customer collection 
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e CustomerId = -1 then add the data
            if (CustomerId == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();

            }
            //otherwise it must be an update 
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property 
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();

            }
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}