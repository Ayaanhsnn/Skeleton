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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        ClsOrder AnOrder = new ClsOrder();
        AnOrder.Address = txtAddress.Text;
        AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
        AnOrder.DeliveryDate = Convert.ToDateTime(txtDeliveryDate.Text);
        AnOrder.DatePurchased = Convert.ToDateTime(txtDatePurchased.Text);
        AnOrder.ClothesAvailable = chkClothesAvailable.Checked;
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");

    }
  
}