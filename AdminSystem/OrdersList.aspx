<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="686px" Width="914px"></asp:ListBox>
        <p>
            <asp:Button ID="Addbtn" runat="server" OnClick="Addbtn_Click" Text="Add" />
            <asp:Button ID="Editbtn" runat="server" OnClick="Editbtn_Click" Text="Edit" />
            <asp:Button ID="btndelete" runat="server" OnClick="btndelete_Click" Text="Delete" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
