<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="AirlineSimpleForm.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>

        <div>
            <asp:Label ID="Label4" runat="server" Text="Trip Type"></asp:Label>
            <br />
            <asp:RadioButtonList AutoPostBack="true" ID="radioTripType" runat="server" OnSelectedIndexChanged="radioTripType_SelectedIndexChanged">
                <asp:ListItem Value="singletrip">Single Trip</asp:ListItem>
                <asp:ListItem Value="roundtrip">RoundTrip</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="errorTripType" runat="server" Text=""></asp:Label>
        </div>
        <br />

        <div>
            <asp:Label ID="labelDestination" runat="server" Text="Select Destination" Visible="False"></asp:Label>
            <br />
            <asp:DropDownList ID="dropdownSingle" runat="server" Visible="False">
                <asp:ListItem Value="bangkok">Bangkok</asp:ListItem>
                <asp:ListItem Value="singapore">Singapore</asp:ListItem>
                <asp:ListItem Value="seoul">Seoul</asp:ListItem>
                <asp:ListItem Value="london">London</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="dropdownRound" runat="server" Visible="False">
                <asp:ListItem Value="yangon - bangkok">Yangon - Bangkok</asp:ListItem>
                <asp:ListItem Value="yangon - singapore">Yangon - Singapore</asp:ListItem>
                <asp:ListItem Value="yangon - seoul">Yangon - Seoul</asp:ListItem>
                <asp:ListItem Value="yangon - london">Yangon - London</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="errorDestination" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:Label ID="Label6" runat="server" Text="Departure Time"></asp:Label>
            <br />
            <asp:RadioButtonList ID="radioDepartureTime" runat="server">
                <asp:ListItem>5 AM</asp:ListItem>
                <asp:ListItem>9 AM</asp:ListItem>
                <asp:ListItem>6 PM</asp:ListItem>
                <asp:ListItem>10 PM</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="errorDepartureTime" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Passport Number"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassport" runat="server"></asp:TextBox>
            <asp:Label ID="errorPassport" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <asp:Label ID="totalPrice" runat="server" Text="Total Price"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Calculate Price" Width="169px" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Buy Ticket" Width="169px" OnClick="Button2_Click" Visible="false" />
    </form>
</body>
</html>
