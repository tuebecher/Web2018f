<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FishFront.aspx.cs" Inherits="SessionFish.FishFront" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBoxTank" runat="server" Height="225px" Width="299px"></asp:ListBox>
        <asp:Button ID="ButtonUpdateTank" runat="server" OnClick="ButtonUpdateTank_Click" Text="Update" />
        <br />
        <br />
        <asp:TextBox ID="TextBoxFishType" runat="server" ToolTip="Type of fish eg. Cod, Herring,.."></asp:TextBox>
        <asp:TextBox ID="TextBoxFishLength" runat="server" ToolTip="Length in cm"></asp:TextBox>
        <asp:TextBox ID="TextBoxFishWeight" runat="server" ToolTip="Weight in gram"></asp:TextBox>
        <asp:Button ID="ButtonAddFish" runat="server" OnClick="ButtonAddFish_Click" Text="Add" />
        <br />
    </form>
</body>
</html>
