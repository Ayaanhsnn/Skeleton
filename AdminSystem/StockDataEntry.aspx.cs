﻿using System;
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
        AStock.StockNo = Convert.ToInt32(txtStockNo.Text);
        AStock.OrderNo = Convert.ToInt32(txtOrderNo.Text);
        AStock.StockDescription = txtStockDesc.Text;
        AStock.DatePurchased = Convert.ToDateTime(txtDatePurch.Text);
        AStock.Availability = chkAvailability.Checked;
        AStock.Quantity = Convert.ToInt32(txtQuantity.Text);
        Session["AStock"] = AStock;
        Response.Redirect("StockViewer.aspx");

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