<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationTest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        .container {
            width: 100%;
            height: 100%;
            display: grid;
            grid-template-columns: repeat(2, 1fr);
            gap: 1rem;
        }

        .profile-image {
            width: 64px;
            height: 64px;
            border: solid 1px;
            border-radius: 6px;
        }

        .image-gallery {
            display: grid;
            grid-template-columns: repeat(4, 1fr);
            gap: 2px;
        }

        .show-case-image {
            width: auto;
            height: 200px;
            border: 2px solid gray;
            border-radius: 6px;
        }

        .porfolio-form-field {
            padding: 10px;
            display: grid;
            grid-template-columns: repeat(2, 1fr);
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
        .btn-primary{
            column-span: all;
            padding: 10px;
            width: 100%;
            height: 40px;
        }
    </style>
</head>
<body>

    <script type="text/javascript">
        function previewProfileImage(input) {
            var file = input.files[0];
            if (file) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    var imagePreview = document.getElementById("imgProfilePreview");
                    imagePreview.src = e.target.result;
                    imagePreview.style.display = "block";
                };
                reader.readAsDataURL(file);
            }
        }
    </script>
    <form id="form1" runat="server">
        <div class="container">
            <div class="porfolio">
                <div class="porfolio-form-field">
                    <img class="profile-image" id="imgProfilePreview"
                        src="https://api.dicebear.com/9.x/open-peeps/svg?seed=George"
                        alt="avatar" />
                    <div>
                        <p>Upload Profile Photo</p>
                        <asp:FileUpload ID="FileUploadProfileImage" runat="server"
                            onchange="previewProfileImage(this)"
                            accept="image/*" />

                    </div>


                </div>
                <div class="porfolio-body">
                    <div class="porfolio-form-field">
                        <asp:Label ID="InputLabelName" runat="server" Text="Name"></asp:Label>
                        <asp:TextBox ID="InputTextName" runat="server" CssClass="input-text"></asp:TextBox>
                    </div>
                    <div class="porfolio-form-field">
                        <asp:Label ID="InputLabelGender" runat="server" Text="Select your gender"></asp:Label>
                        <asp:RadioButtonList ID="InputRadioGender" runat="server">
                            <asp:ListItem Value="male" Text="Male"></asp:ListItem>
                            <asp:ListItem Value="female" Text="Female"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="porfolio-form-field">
                        <asp:Label ID="InputLabelCity" runat="server" Text="Where do you live ?"></asp:Label>
                        <asp:DropDownList ID="InputDropDownCity" runat="server">
                            <asp:ListItem Value="0" Selected="True" Text="Select City" />
                            <asp:ListItem Value="Yangon" Text="Yangon" />
                            <asp:ListItem Value="Mandalay" Text="Mandalay" />
                            <asp:ListItem Value="Pathein" Text="Pathein" />
                            <asp:ListItem Value="Taunggyi" Text="Taunggyi" />
                        </asp:DropDownList>
                    </div>
                    <div class="porfolio-form-field">
                        <asp:Label ID="Label1" runat="server" Text="Fill Your bio"></asp:Label>
                        <asp:TextBox ID="InputTextAreaBio" runat="server" TextMode="MultiLine" CssClass="text-area" Rows="20" Columns="100"></asp:TextBox>
                    </div>
                </div>
                <asp:Button ID="btnExport" runat="server" CssClass="btn-primary" Text="Export Data" OnClick="btnExport_Click" />
            </div>
            <div class="image-gallery">
                <img class="show-case-image"
                    src="https://api.dicebear.com/9.x/open-peeps/svg?seed=George"
                    alt="avatar" />
                <img class="show-case-image"
                    src="https://api.dicebear.com/9.x/open-peeps/svg?seed=George"
                    alt="avatar" />
                <img class="show-case-image"
                    src="https://api.dicebear.com/9.x/open-peeps/svg?seed=George"
                    alt="avatar" />
                <img class="show-case-image"
                    src="https://api.dicebear.com/9.x/open-peeps/svg?seed=George"
                    alt="avatar" />
                <img class="show-case-image"
                    src="https://api.dicebear.com/9.x/open-peeps/svg?seed=George"
                    alt="avatar" />
                <img class="show-case-image"
                    src="https://api.dicebear.com/9.x/open-peeps/svg?seed=George"
                    alt="avatar" />
                <img class="show-case-image"
                    src="https://api.dicebear.com/9.x/open-peeps/svg?seed=George"
                    alt="avatar" />
            </div>
        </div>
        
    </form>

</body>
</html>
