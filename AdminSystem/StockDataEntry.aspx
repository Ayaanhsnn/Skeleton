<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStockNo" runat="server" Text="Stock Number"></asp:Label>
            <asp:TextBox ID="txtStockNo" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblOrderNo" runat="server" Text="Order Number" width="90px"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStockDesc" runat="server" Text="Stock Description" width="90px"></asp:Label>
        <asp:TextBox ID="txtStockDesc" runat="server" Height="16px" OnTextChanged="txtStockDesc_TextChanged" Width="143px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDatePurch" runat="server" Text="Date Purchased" width="90px"></asp:Label>
        <asp:TextBox ID="txtDatePurch" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAvailability" runat="server" Text="Availability" width="90px"></asp:Label>
        <asp:TextBox ID="txtAvailability" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="90px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkAvailability" runat="server" OnCheckedChanged="chkAvailability_CheckedChanged" Text="Availability" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
