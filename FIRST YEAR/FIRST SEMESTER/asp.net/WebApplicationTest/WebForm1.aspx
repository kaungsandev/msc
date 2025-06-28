<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationTest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>


        .container {
            width: 100%; max-width: 80rem; /* Matches Tailwind's max-w-7xl */
  margin-left: auto;
  margin-right: auto;
  padding:2rem;
  
            
        }

        .profile-image {
            width: 64px;
            height: 64px;
            border: solid 1px;
            border-radius: 6px;
        }
        .text-area {
            border: solid 1px grey;
            border-radius: 6px;
            padding: 10px;
        }

        .input-text {
            width: 100%;
            height: 36px;
            border: solid 1px grey;
            border-radius: 6px;
            padding-left: 10px;
        }

        .btn-primary {
            column-span: all;
            padding: 10px;
            width: 100%;
            height: 40px;
        }
        .dropdown{
            width: 100%;
            height:50px;
            max-width: 20rem;
            padding-left: 10px;
            padding-right: 5px;
            padding-top: 5px;
            padding-bottom: 5px;
        }
    </style>
</head>
<body>

    <script type="text/javascript">
        function previewProfileImage(input, previewElementID) {
            var file = input.files[0];
            if (file) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    var imagePreview = document.getElementById(previewElementID);
                    imagePreview.src = e.target.result;
                    imagePreview.style.display = "block";
                };
                reader.readAsDataURL(file);
            }
        }
    </script>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div class="container">
            <div class="porfolio">
                <table style="width: 100%;">
                    <tr>
                        <td>
                            <img class="profile-image" id="imgProfilePreview"
                                src="https://api.dicebear.com/9.x/open-peeps/svg?seed=George"
                                alt="avatar" /></td>
                        <td>Upload Profile Photo<br />
                            <asp:FileUpload ID="FileUploadProfileImage" runat="server"
                                onchange="previewProfileImage(this, 'imgProfilePreview')"
                                accept="image/*" />

                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="InputLabelName" runat="server" Text="Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="InputTextName" runat="server" CssClass="input-text"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="InputLabelGender" runat="server" Text="Select your gender"></asp:Label>
                        </td>
                        <td>
                            <asp:RadioButtonList ID="InputRadioGender" runat="server">
                                <asp:ListItem Value="male" Text="Male"></asp:ListItem>
                                <asp:ListItem Value="female" Text="Female"></asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="InputLabelCity" runat="server" Text="Where do you live ?"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="InputDropDownCity" runat="server" class="dropdown">
                                <asp:ListItem Value="0" Selected="True" Text="Select City" />
                                <asp:ListItem Value="Yangon" Text="Yangon" />
                                <asp:ListItem Value="Mandalay" Text="Mandalay" />
                                <asp:ListItem Value="Pathein" Text="Pathein" />
                                <asp:ListItem Value="Taunggyi" Text="Taunggyi" />
                            </asp:DropDownList>
                        </td>
                        <td></td>
                        
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Fill Your bio"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="InputTextAreaBio" runat="server" TextMode="MultiLine" CssClass="text-area" Rows="20" Columns="100"></asp:TextBox>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <img class="profile-image" id="img1"
                                src="https://api.dicebear.com/9.x/open-peeps/svg?seed=George"
                                alt="avatar" /></td>
                        <td>Showcase Image 1<br />
                            <asp:FileUpload ID="showCaseImage1" runat="server"
                                onchange="previewProfileImage(this, 'img1')"
                                accept="image/*" />

                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <img class="profile-image" id="img2"
                                src="https://api.dicebear.com/9.x/open-peeps/svg?seed=George"
                                alt="avatar" /></td>
                        <td>Showcase Image 2<br />
                            <asp:FileUpload ID="showCaseImage2" runat="server"
                                onchange="previewProfileImage(this, 'img2')"
                                accept="image/*" />

                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <img class="profile-image" id="img3"
                                src="https://api.dicebear.com/9.x/open-peeps/svg?seed=George"
                                alt="avatar" /></td>
                        <td>Showcase Image 3<br />
                            <asp:FileUpload ID="showCaseImage3" runat="server"
                                onchange="previewProfileImage(this, 'img3')"
                                accept="image/*" />

                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnExport" runat="server" CssClass="btn-primary" Text="Export Data" OnClick="btnExport_Click" /></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                    </tr>
                </table>
                
                
            </div>
        </div>

    </form>

</body>
</html>
