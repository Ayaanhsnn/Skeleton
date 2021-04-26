<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        clsOrder AOrder = new clsOrder();
        AnOrder = (ClsOrder) Session["AnOrder"];
        Response.Write(AOrder.Address);
        Response.Write(AOrder.ClothesAvailable);
        Response.Write(AOrder.DatePurchased);
        Response.Write(AOrder.DeliveryDate);
        Response.Write(AOrder.OrderNo);
        <div>
        </div>
    </form>
</body>
</html>
