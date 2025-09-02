<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VotingLogin.aspx.cs" Inherits="AssignmentQ1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Log In</h1>
            <br />
            <label>Email</label>
            <br />
            <asp:TextBox TextMode="Email" ID="TBEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblError" runat="server" Text="Label" ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
