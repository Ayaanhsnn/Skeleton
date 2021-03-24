<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute; height: 437px; width: 516px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 14px; top: 503px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 87px; top: 501px; position: absolute" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 568px; position: absolute"></asp:Label>
    </form>
</body>
</html>
