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
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.Address + "\t");
        Response.Write(AnOrder.ClothesAvailable + "\t");
        Response.Write(AnOrder.DatePurchased + "\t");
        Response.Write(AnOrder.DeliveryDate + "\t");
        Response.Write(AnOrder.OrderNo + "\t");
      
       
    }
}