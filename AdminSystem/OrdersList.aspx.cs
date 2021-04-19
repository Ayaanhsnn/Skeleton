using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {   
        
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
        
    }
    void DisplayOrders()
    {
        clsOrderCollection Address = new clsOrderCollection();
        lstOrderList.DataSource = Address.OrderList;
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "Address";
        lstOrderList.DataBind();




    }

    protected void Addbtn_Click(object sender, EventArgs e)
    {
        Session["OrderNo"] = -1;
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void Editbtn_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderNo"] = OrderNo;
            //redirect to the edit page
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else //if no record has been selected 
        {
            //display an error
            lblError.Text = " Please select the record to delete from the list";
        }

    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit 
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderNo"] = OrderNo;
            //redirect to the edit page
            Response.Redirect("DeleteOrder.aspx");
        }
        else //if no record has been selected 
        {
            //display an error
            lblError.Text = " Please select the record to delete from the list";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Address = new clsOrderCollection();
        Address.ReportByAddress(txtAddress.Text);
        lstOrderList.DataSource = Address.OrderList;
        //set name of primary key
        lstOrderList.DataValueField = "OrderNo";
        //set the name of field to display
        lstOrderList.DataTextField = "Address";
        //bind data to list
        lstOrderList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Address = new clsOrderCollection();
        Address.ReportByAddress("");
        txtAddress.Text = "";
        lstOrderList.DataSource = Address.OrderList;
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "Address";
        lstOrderList.DataBind();
    }
}
