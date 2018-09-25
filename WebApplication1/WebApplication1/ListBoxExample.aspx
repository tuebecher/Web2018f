<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListBoxExample.aspx.cs" Inherits="WebApplication1.ListBoxExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <h1>Example ListBox</h1>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add to box" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="266px" Width="256px" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        <br />
        <asp:Label ID="LabelSelected" runat="server" Text="Nothing selected"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonDelete" runat="server" Text="Delete Selected" OnClick="ButtonDelete_Click" />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <br />
        <br />
        Gender:<br />
        <asp:RadioButton ID="RadioButtonMale" runat="server" GroupName="gender" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male" />
        <asp:RadioButton ID="RadioButtonFemale" runat="server" GroupName="gender" Text="Female" />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Unknown" />
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>xx</asp:ListItem>
            <asp:ListItem>yy</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:ListBox ID="ListBox2" runat="server" Height="167px" Width="412px"></asp:ListBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    </form>
</body>
</html>
