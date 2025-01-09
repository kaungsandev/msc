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
            display: grid;
            grid-template-columns: repeat(2, 1fr);
        }

        .text-area {
            width: 100%;
            height: 200px;
        }

        .input-text {
            width: 100%;
            height: 36px;
            border: solid 1px grey;
            border-radius: 6px;
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
                        <input id="File1" type="file" accept="image/*" onchange="previewProfileImage(this)" />
                    </div>


                </div>
                <div class="porfolio-body">
                    <p>Biography</p>
                    <div class="porfolio-form-field">
                        <p>Name</p>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
                    <textarea class="text-area" placeholder="Write your bio" id="TextArea1" cols="20" name="S1" rows="2"></textarea>
                </div>
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

            <asp:Button ID="btnExport" runat="server" Text="Export Data" OnClick="btnExport_Click" />
        </div>
    </form>

</body>
</html>
