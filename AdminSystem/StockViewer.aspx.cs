﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        AStock = (clsStock)Session["AStock"];
        Response.Write(AStock.StockNo + "\t");
        Response.Write(AStock.OrderNo + "\t");
        Response.Write(AStock.StockDesc + "\t");
        Response.Write(AStock.DatePurch + "\t");
        Response.Write(AStock.Availability + "\t");
        Response.Write(AStock.Quantity + "\t");
    }
}