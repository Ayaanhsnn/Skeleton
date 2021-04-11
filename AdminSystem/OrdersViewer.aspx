<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        clsOrder AnOrder = new clsOrder();
        AnOrder = (ClsOrder) Session["AnOrder"];
        Response.Write(AnOrder.Address);
        Response.Write(AnOrder.ClothesAvailable);
        Response.Write(AnOrder.DatePurchased);
        Response.Write(AnOrder.DeliveryDate);
        Response.Write(AnOrder.OrderNo);
        <div>
        </div>
    </form>
</body>
</html>
