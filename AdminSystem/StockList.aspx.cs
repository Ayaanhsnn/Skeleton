using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StockList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();
        }

    }

    void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "StockNo";
        lstStockList.DataTextField = "StockDescription";
        lstStockList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StockNo"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store primary key value of record to be deleted
        Int32 StockNo;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of record to delete
            StockNo = Convert.ToInt32(lstStockList.SelectedValue);
            //store data in session object
            Session[" StockNo"] = StockNo;
            //redirect to the delete page
            Response.Redirect("DeleteStock.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store primary key value of record to edit
        Int32 StockNo;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockNo = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["StockNo"] = StockNo;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of stock collection
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByStockDescription(txtstockdescription.Text);
        lstStockList.DataSource = Stock.StockList;
        //set name of primary key
        lstStockList.DataValueField = "StockNo";
        //set the name of field to display
        lstStockList.DataTextField = "StockDescription";
        //bind data to list
        lstStockList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByStockDescription("");
        txtstockdescription.Text = "";
        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "StockNo";
        lstStockList.DataTextField = "StockDescription";
        lstStockList.DataBind();
    }
}
