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
        <asp:Label ID="lblUsernameFilter" runat="server" style="z-index: 1; left: 18px; top: 521px; position: absolute; height: 37px; width: 178px" Text="Enter a username"></asp:Label>
        <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute; height: 394px; width: 556px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 17px; top: 452px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 166px; top: 454px; position: absolute" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 645px; position: absolute"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 94px; top: 451px; position: absolute" Text="Edit" />
        <asp:TextBox ID="txtUsernameFilter" runat="server" style="z-index: 1; left: 209px; top: 514px; position: absolute; height: 32px; width: 249px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 24px; top: 573px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; top: 574px; position: absolute; height: 32px; width: 79px; left: 117px; right: 1178px" Text="Clear" />
    </form>
</body>
</html>
