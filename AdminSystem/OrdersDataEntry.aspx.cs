using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderNo != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }

    }
    void DisplayOrder()
    {
        //create an instance of the stock book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(OrderNo);
        txtOrderNo.Text = OrderBook.ThisOrder.OrderNo.ToString();
        txtAddress.Text = OrderBook.ThisOrder.Address.ToString();
        txtDatePurchased.Text = OrderBook.ThisOrder.DatePurchased.ToString();
        txtDeliveryDate.Text = OrderBook.ThisOrder.DeliveryDate.ToString();
        chkClothesAvailable.Checked = OrderBook.ThisOrder.ClothesAvailable;
    }
        protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        //navigate to the viewer page)
        clsOrder AOrder = new clsOrder();
        string Address = txtAddress.Text;
        string DatePurchased = txtDatePurchased.Text;
        string DeliveryDate = txtDeliveryDate.Text;
        string Error = "";
        Error = AOrder.Valid(Address, DatePurchased, DeliveryDate);
        if (Error == "")
        {
            AOrder.Address = Address;
            AOrder.DeliveryDate = Convert.ToDateTime(DeliveryDate);
            AOrder.DatePurchased = Convert.ToDateTime(DatePurchased);
            AOrder.ClothesAvailable = chkClothesAvailable.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderNo == -1)
            {
                OrderList.ThisOrder = AOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderNo);
                OrderList.ThisOrder = AOrder;
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
        clsOrder AOrder = new clsOrder();
        Int32 OrderNo;
        Boolean Found = false;
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        Found = AOrder.Find(OrderNo);
        if (Found == true)
            {
            txtOrderNo.Text = AOrder.OrderNo.ToString();

            txtAddress.Text = AOrder.Address;
            txtDatePurchased.Text = AOrder.DatePurchased.ToString();
            txtDeliveryDate.Text = AOrder.DeliveryDate.ToString();
            }

    }
}