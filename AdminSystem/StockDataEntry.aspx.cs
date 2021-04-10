using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store primary key with page level scope
    Int32 StockNo;


    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of address to be processed
        StockNo = Convert.ToInt32(Session["StockNo"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StockNo != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }

    void DisplayStock()
    {
        //create an instance of the stock book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update
        StockBook.ThisStock.Find(StockNo);
        //display the data for this record
        txtStockNo.Text = StockBook.ThisStock.StockNo.ToString();
        txtOrderNo.Text = StockBook.ThisStock.OrderNo.ToString();
        txtStockDesc.Text = StockBook.ThisStock.StockDescription;
        txtDatePurch.Text = StockBook.ThisStock.DatePurchased.ToString();
        txtQuantity.Text = StockBook.ThisStock.Quantity.ToString();
        chkAvailability.Checked = StockBook.ThisStock.Availability;

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
            AStock.StockNo = StockNo;
            AStock.OrderNo = Convert.ToInt32(OrderNo);
            AStock.StockDescription = StockDescription;
            AStock.DatePurchased = Convert.ToDateTime(DatePurchased);
            AStock.Quantity = Convert.ToInt32(Quantity);
            AStock.Availability = chkAvailability.Checked;
            //create a new instance of stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record - e.g. StockNo = -1 then add data
            if (StockNo == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //add new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(StockNo);
                StockList.ThisStock = AStock;
                StockList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
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
