using System;
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
        ClsOrder AnOrder = new ClsOrder();
        AnOrder = (ClsOrder)Session["AnOrder"];
        Response.Write(AnOrder.Address);
        Response.Write(AnOrder.ClothesAvailable);
        Response.Write(AnOrder.DatePurchased);
        Response.Write(AnOrder.DeliveryDate);
        Response.Write(AnOrder.OrderNo);
      
       
    }
}