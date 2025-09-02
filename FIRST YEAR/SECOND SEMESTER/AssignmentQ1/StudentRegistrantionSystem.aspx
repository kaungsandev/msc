<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistrantionSystem.aspx.cs" Inherits="AssignmentQ1.StudentRegistrantionSystem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
        <div>
            
            <label for="CourseList">Please choose Course</label>
            <br />
            <br />
            <asp:DropDownList ID="CourseList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CourseList_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <label>Student Name</label>
            <br />
            <asp:TextBox ID="TBName"  runat="server"></asp:TextBox>
            <br />
            <label>Student ID</label>
            <br />
            <asp:TextBox ID="TBStudenId"  runat="server"></asp:TextBox>
            <br />
            <label>Phone Number</label>
            <br />
            <asp:TextBox ID="TBPhoneNumber"  runat="server"></asp:TextBox>
            <br />
        </div>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit Registration" />
    </form>
</body>
</html>
