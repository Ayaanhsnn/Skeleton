<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 10px; top: 42px; position: absolute" Text="Customer Id"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 171px; top: 42px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 17px; top: 91px; position: absolute" Text="Username" width="119px"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 170px; top: 97px; position: absolute" width="188px"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 20px; top: 158px; position: absolute; height: 24px; width: 119px" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 166px; top: 157px; position: absolute" width="188px"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 21px; top: 212px; position: absolute" Text="Address" width="119px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 166px; top: 208px; position: absolute; height: 27px" width="188px"></asp:TextBox>
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 23px; top: 269px; position: absolute" Text="Date Of Birth" width="119px"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 165px; top: 265px; position: absolute" width="188px"></asp:TextBox>
        <asp:CheckBox ID="chkReceiveMail" runat="server" style="z-index: 1; left: 15px; top: 341px; position: absolute" Text="ReceiveMail" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 394px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 22px; top: 458px; position: absolute; height: 48px;" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 80px; top: 456px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 385px; top: 42px; position: absolute" Text="Find" />
    </form>
</body>
</html>
