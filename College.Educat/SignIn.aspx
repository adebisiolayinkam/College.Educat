<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="College.Educat.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Sign In - College Student Records Management Systems</title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="~/Content/vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link href="~/Content/css/sb-admin.css" rel="stylesheet">
    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
</head>
<body class="bg-dark">
    <div class="container">
        <div class="card card-login mx-auto mt-5">
            <div class="card-header"><strong>School Management Portal</strong> - Login</div>
            <div class="card-body">
                <form id="form1" runat="server">

                    <div class="form-group">
                        <div class="form-label-group">
                            <asp:TextBox ID="UserNameBox"
                                runat="server"
                                CssClass="form-control"></asp:TextBox>
                            <label for="UserNameBox">
                                User Name
                                <asp:RequiredFieldValidator
                                    ID="r2" Text="User name required"
                                    ForeColor="Red"
                                    runat="server"
                                    ErrorMessage="User name required"
                                    ControlToValidate="UserNameBox"></asp:RequiredFieldValidator>
                            </label>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="form-label-group">
                            <asp:TextBox ID="PasswordBox"
                                runat="server"
                                TextMode="Password"
                                CssClass="form-control"></asp:TextBox>

                            <label for="PasswordBox">
                                Password
                                <asp:RequiredFieldValidator
                                    Text="Password required"
                                    ID="r1"
                                    ForeColor="Red"
                                    runat="server"
                                    ErrorMessage="Password required"
                                    ControlToValidate="PasswordBox"></asp:RequiredFieldValidator></label>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="checkbox">
                            <label>
                                <input id="RememberMeBox" name="RememberMeBox" runat="server" type="checkbox" value="true" />
                                Remember me 
                            </label>
                        </div>
                    </div>
                    <asp:Button ID="SubmitButton" runat="server" Text="Sign In" CssClass="btn btn-primary btn-block" OnClick="SubmitButton_Click" />
                    <hr />
                    <asp:Label ID="SpanError" runat="server" ForeColor="red" Style="font-size: 12px"></asp:Label>
                </form>
                <div class="text-center">
                    <a class="d-block small" href="ForgetPassword">Forgot Password?</a>
                </div>
            </div>
        </div>
    </div>

    <script src="/Content/vendor/jquery/jquery.min.js"></script>
    <script src="/Content/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="/Content/vendor/jquery-easing/jquery.easing.min.js"></script>
</body>
</html>
