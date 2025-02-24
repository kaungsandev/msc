<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplicationTest.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="C:\Users\kaungsan\Desktop\MSC\asp.net\WebApplicationTest\uploads\profile_image.jpg" />
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Make Enabled" />
        </p>
        <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Make Disabled" />
        <p>
            <asp:CheckBox ID="CheckBox3" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Change Back Color" />
        </p>
        <p>
            <asp:CheckBox ID="CheckBox4" runat="server" OnCheckedChanged="CheckBox4_CheckedChanged" Text="Toggle Visible" />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>ListItem 1</asp:ListItem>
<asp:ListItem>ListItem 2</asp:ListItem>
<asp:ListItem>ListItem 3</asp:ListItem>
            </asp:CheckBoxList>
        </p>
        <p>
            <asp:Button ID="btnDisabled" runat="server" Text="I am the button" Width="146px" OnClick="btnDisabled_Click" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Machine Learning</asp:ListItem>
            <asp:ListItem>Image Processing</asp:ListItem>
            <asp:ListItem>Data Mining</asp:ListItem>
            <asp:ListItem>Artificial Intelligence</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Which one do you like" Width="193px" />
        <p>
            <asp:Label ID="radioLabel" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
