<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DataList.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DataList Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="ProductDataList" runat="server" 
                OnItemCommand="ProductDataList_ItemCommand" 
                OnItemDataBound="ProductDataList_ItemDataBound" 
                RepeatColumns="1" 
                RepeatDirection="Vertical">
              
                <ItemTemplate>
                    <asp:Label ID="lblID" runat="server" Text='<%# Eval("ID") %>' Visible="false" />
                    <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>' />
                    <asp:Label ID="lblPrice" runat="server" Text='<%# Eval("Price", "{0:C}") %>' />
                    <asp:Button ID="btnEdit" runat="server" CommandName="Edit" Text="Edit" />
                </ItemTemplate>

                
                <EditItemTemplate>
                    <asp:Label ID="lblIDEdit" runat="server" Text='<%# Eval("ID") %>' Visible="false" />
                    <asp:TextBox ID="txtName" runat="server" Text='<%# Eval("Name") %>' />
                    <asp:TextBox ID="txtPrice" runat="server" Text='<%# Eval("Price") %>' />
                    <asp:Button ID="btnUpdate" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="btnCancel" runat="server" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
            </asp:DataList>
            <asp:Label ID="Label1" runat="server" ForeColor="Green" />
        </div>
    </form>
</body>
</html>
