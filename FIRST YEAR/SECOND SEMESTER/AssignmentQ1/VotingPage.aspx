<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VotingPage.aspx.cs" Inherits="AssignmentQ1.VotingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="rblActress" runat="server">
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Vote" OnClick="Button1_Click" />
        </div>
    </form>
    <a id="Logout" href="VotingLogin.aspx">Logout</a>
</body>
</html>
