<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentData.aspx.cs" Inherits="AssignmentQ1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Label ID="ErrorLabel" runat="server" ></asp:Label>
    <table style="width: 100%;">
        <tr>
            <td>Student Name</td>
            <td><asp:Label ID="lblStudentName" runat="server" ></asp:Label></td>
            
        </tr>
        <tr>
            <td>Student ID</td>
            <td><asp:Label ID="lblStudentId" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td>Phone Number</td>
            <td><asp:Label ID="lblPhoneNumber" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td>Courses</td>
            <td><asp:Label ID="lblCourses" runat="server" ></asp:Label></td>
        </tr>
    </table>
    
</body>
</html>
