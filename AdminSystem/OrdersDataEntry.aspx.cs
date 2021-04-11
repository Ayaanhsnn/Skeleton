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
        //navigate to the viewer page)
        clsOrder AnOrder = new clsOrder();
        string Address = txtAddress.Text;
        string DatePurchased = txtDatePurchased.Text;
        string DeliveryDate = txtDeliveryDate.Text;
        string Error = "";
        Error = AnOrder.Valid(Address, DatePurchased, DeliveryDate);
        if (Error == "")
        {
            AnOrder.Address = Address;
            AnOrder.DeliveryDate = Convert.ToDateTime(DeliveryDate);
            AnOrder.DatePurchased = Convert.ToDateTime(DatePurchased);
            AnOrder.ClothesAvailable = chkClothesAvailable.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderNo == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderNo);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrdersList.aspx");

        }
        else 
        {
            lblError.Text = Error;


        }

    }

    protected void Find_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderNo;
        Boolean Found = false;
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        Found = AnOrder.Find(OrderNo);
        if (Found == true)
            {
            txtAddress.Text = AnOrder.Address;
            txtDatePurchased.Text = AnOrder.DatePurchased.ToString();
            txtDeliveryDate.Text = AnOrder.DeliveryDate.ToString();
            }

    }
}