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
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrders.DataSource = Orders.OrderList;

        


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
}
