<%@ Page Title="Add Student Data" Async="true" Language="C#" MasterPageFile="~/College.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="College.Educat.admin.AddStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageNameContentPlaceHolder" runat="server">
    Personal Information
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
    <script>
        //FileUpload1
        function image_preview(e) {
            var reader = new FileReader();
            reader.onload = function () {
                var output = document.getElementById('<%: Image1.ClientID%>');
                output.src = reader.result;
            }
            reader.readAsDataURL(e.target.files[0]);
        }
    </script>
</asp:Content>
<asp:Content ID="Content5" runat="server" ContentPlaceHolderID="MainContent">
    <div class="card mb-3">
        <div class="card-header">
            Personal Information
        </div>
        <div class="card-body">

            <div class="row">
                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="SurnameBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="SurnameBox">
                            Surname
                  <asp:RequiredFieldValidator
                      ID="r1" Text="Surname required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Surname required"
                      ControlToValidate="SurnameBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>

                <asp:HiddenField ID="ParentField" runat="server" />

                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="FirstNameBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="FirstNameBox">
                            FirstName
                  <asp:RequiredFieldValidator
                      ID="r2" Text="FirstName required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="FirstName required"
                      ControlToValidate="FirstNameBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:FileUpload ID="FileUpload1" Text="Upload" runat="server" onchange="image_preview(event)" />
                        <asp:Image ID="Image1" runat="server" BorderColor="Black" Width="120" Height="80" />
                        <label for="UploadButton">
                            Upload Passport                
                        </label>
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="OtherNameBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="OtherNameBox">
                            OtherName
                  <asp:RequiredFieldValidator
                      ID="r3" Text="OtherName required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="OtherName required"
                      ControlToValidate="OtherNameBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>

                <br />


                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:DropDownList ID="GenderDropDownList" runat="server" CssClass="form-control">
                            <asp:ListItem>--Select Your Gender--</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <br />


                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="DobTextBox" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                        <label for="DobTextBox">
                            Date of Birth
                  <asp:RequiredFieldValidator
                      ID="r4" Text=" Date of Birth required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage=" Date of Birth required"
                      ControlToValidate="DobTextBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
            </div>

            <br />



            <div class="row">
                <div class="col-md-3">
                    <div class="form-label-group">
                        <asp:TextBox ID="CurrentSessionBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="CurrentSessionBox">
                            Current Session
                  <asp:RequiredFieldValidator
                      ID="r6" Text="CurrentSession required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="CurrentSession required"
                      ControlToValidate="CurrentSessionBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>              

                <br />


                <div class="col-md-3">
                      <div class="form-label-group">
                        <asp:DropDownList ID="DropDownListClassID" runat="server" CssClass="form-control"></asp:DropDownList>

                    </div>                   
                </div>

                <br />


                <div class="col-md-3">
                    <asp:DropDownList runat="server" ID="DropDownListCurrentTerm" CssClass="form-control">
                        <asp:ListItem Value="0">Current Term</asp:ListItem>
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                    </asp:DropDownList>
                </div>


                <br />

                <div class="col-md-3">
                    <div class="form-label-group">
                        <asp:DropDownList ID="DropDownListArmId" runat="server" CssClass="form-control"></asp:DropDownList>

                    </div>
                </div>
            </div>
            <br />

            <div class="row">
                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="GuardianNameBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="GuardianNameBox">
                            Guardian Name
                  <asp:RequiredFieldValidator
                      ID="r9" Text="GuardianName required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="GuardianName required"
                      ControlToValidate="GuardianNameBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
                <br />



                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="GuardianPhoneNoBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="GuardianPhoneNoBox">
                            Guardian PhoneNo
                  <asp:RequiredFieldValidator
                      ID="r10" Text="GuardianPhoneNo required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="GuardianPhoneNo required"
                      ControlToValidate="GuardianPhoneNoBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
                <br />

                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="GuardianEmailBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="GuardianEmailBox">
                            Guardian Email
                  <asp:RequiredFieldValidator
                      ID="r11" Text="GuardianEmail required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="GuardianEmail required"
                      ControlToValidate="GuardianEmailBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
            </div>
            <br />

            <div class="row">
                <div class="col-md-6">
                    <div class="form-label-group">
                        <asp:TextBox ID="CityBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="CityBox">
                            City
                  <asp:RequiredFieldValidator
                      ID="r13" Text="City required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="City required"
                      ControlToValidate="CityBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
                <br />

                <div class="col-md-6">
                    <div class="form-label-group">
                        <asp:DropDownList ID="StateDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>

                    </div>
                </div>
            </div>
            <br />

            <div class="row">
                <div class="col-md-3">
                    
                     <div class="form-label-group">
                        <asp:DropDownList ID="DropDownListYEntry" runat="server" CssClass="form-control"></asp:DropDownList>

                    </div>  
                </div>
                <br />

                <div class="col-md-9">
                    <div class="form-label-group">
                        <asp:TextBox ID="HomeAddressBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="HomeAddressBox">
                            Home Address
                  <asp:RequiredFieldValidator
                      ID="r12" Text="HomeAddress required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="HomeAddress required"
                      ControlToValidate="HomeAddressBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
            </div>
            <br />

            <div class="row">
                <asp:Button ID="btnSubmit" CssClass="btn btn-primary form-control " runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Label ID="lblMessage" runat="server" CssClass="alert-danger"></asp:Label>
            </div>
        </div>
        <div class="card-footer small text-muted">College Management Sysytem</div>
    </div>
</asp:Content>

