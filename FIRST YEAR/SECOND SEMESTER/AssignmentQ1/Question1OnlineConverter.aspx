<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question1OnlineConverter.aspx.cs" Inherits="AssignmentQ1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="RadioButtonList1">Choose One Option</label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="100%" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Value="FTM">Feet to Meter</asp:ListItem>
                <asp:ListItem Value="CTF">Celsius To Fahrenheit</asp:ListItem>
                <asp:ListItem Value="PTK">Pound to Kilo</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" AutoPostBack="true"></asp:TextBox>
        </div>
    </form>
</body>
</html>
