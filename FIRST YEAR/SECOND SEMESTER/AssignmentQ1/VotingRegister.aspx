<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VotingRegister.aspx.cs" Inherits="AssignmentQ1.VotingRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register</h1>
        <div>
            <asp:TextBox TextMode="Email" ID="tbEmail" runat="server"></asp:TextBox>
            <asp:Label ID="labelError" runat="server" Text="Label"></asp:Label>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
