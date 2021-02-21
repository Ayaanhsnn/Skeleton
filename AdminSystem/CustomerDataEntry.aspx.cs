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
        //Capture the customer Id
        AnCustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnCustomer.Username = txtUsername.Text;
        AnCustomer.Password = txtPassword.Text;
        AnCustomer.Address = txtAddress.Text;
        AnCustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
        AnCustomer.ReceiveMail = chkReceiveMail.Checked;
        //store the address in the session object
        Session["AnCustomer"] = AnCustomer;
        //Navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
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