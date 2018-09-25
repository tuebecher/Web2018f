<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="LabelHello" runat="server" Text="Hello World"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update the label" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="45">Cat</asp:ListItem>
            <asp:ListItem>Dog</asp:ListItem>
            <asp:ListItem>Horse</asp:ListItem>
            <asp:ListItem>Elephant</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="ButtonGetFromDropdown" runat="server" OnClick="ButtonGetFromDropdown_Click" Text="Grap from dropdown" />
    </form>
</body>
</html>
