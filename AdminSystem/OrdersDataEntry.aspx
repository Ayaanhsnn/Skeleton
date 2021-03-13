<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the order entry page
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderNo" runat="server" Text="Order Number"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
        <asp:Button ID="Find" runat="server" OnClick="Find_Click" Text="Find" />
        <p>
            <asp:Label ID="lblDatePurchased" runat="server" Text="Date Purchased"></asp:Label>
            <asp:TextBox ID="txtDatePurchased" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDeliveryDate" runat="server" Text="Delivery Date"></asp:Label>
        <asp:TextBox ID="txtDeliveryDate" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkClothesAvailable" runat="server" Text="ClothesAvailble" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
