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

    protected void txtStockDesc_TextChanged(object sender, EventArgs e)
    {

    }

    protected void chkAvailability_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        string OrderNo = txtOrderNo.Text;
        string StockDescription = txtStockDesc.Text;
        string DatePurchased = txtDatePurch.Text;
        string Quantity = txtQuantity.Text;
        string Error = "";
        Error = AStock.Valid(OrderNo, StockDescription, DatePurchased, Quantity);
        if (Error == "")
        {
            AStock.OrderNo = Convert.ToInt32(OrderNo);
            AStock.StockDescription = StockDescription;
            AStock.DatePurchased = Convert.ToDateTime(DatePurchased);
            AStock.Quantity = Convert.ToInt32(Quantity);
            AStock.Availability = chkAvailability.Checked;
        }
        else
        {
            lblError.Text = Error;
        }
        
        

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        Int32 StockNo;
        Boolean Found = false;
        StockNo = Convert.ToInt32(txtStockNo.Text);
        Found = AStock.Find(StockNo);
        if (Found == true)
        {
            txtStockNo.Text = AStock.StockNo.ToString();
            txtOrderNo.Text = AStock.OrderNo.ToString();
            txtStockDesc.Text = AStock.StockDescription;
            txtDatePurch.Text = AStock.DatePurchased.ToString();
            txtQuantity.Text = AStock.Quantity.ToString();

        }
    }

    }
