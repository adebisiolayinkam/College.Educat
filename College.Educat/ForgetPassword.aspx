<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="College.Educat.ForgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="utf-8" />
    <title>Forget Password - College Student Records Management Systems</title>
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
            <div class="card-header"><strong>School Management Portal</strong> - Reset Password</div>
            <div class="card-body">
                <div class="text-center mb-4">
                    <h4>Forgot your password?</h4>
                    <p>Enter your email address and we will send you instructions on how to reset your password.</p>
                </div>
                <form id="form1" runat="server">
                    <div class="form-group">
                        <div class="form-label-group"><asp:TextBox ID="EmailBox"
                                runat="server"
                                CssClass="form-control"></asp:TextBox>
                            <label for="EmailBox">
                                User Name
                                <asp:RequiredFieldValidator
                                    ID="r2" Text="Email required"
                                    ForeColor="Red"
                                    runat="server"
                                    ErrorMessage="Enter an Email address"
                                    ControlToValidate="EmailBox" />
                                <asp:RegularExpressionValidator
                                    ID="r1" 
                                    runat="server"
                                    ErrorMessage="Invalid Email Address"
                                    ControlToValidate="EmailBox" 
                                    ForeColor="Red" 
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                            </label>
                        </div>
                    </div>
                    <asp:Button ID="ButtonForget" CssClass="btn btn-primary btn-block" runat="server" Text="Reset Password" OnClick="ButtonForget_Click" />
                </form>
                <div class="text-center">
                    <a class="d-block small" href="SignIn">Login Page</a>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
