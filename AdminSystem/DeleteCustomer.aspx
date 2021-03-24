<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 15px; top: 74px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 90px; top: 76px; position: absolute" Text="No" />
    </form>
</body>
</html>
