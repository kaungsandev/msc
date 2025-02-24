<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AirlineSimpleForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        Login
    </div>
    <form id="form1" runat="server">


        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <asp:Label ID="errorUsername" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="errorPassword" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" Width="169px" OnClick="Button1_Click" />
    </form>
</body>
</html>
