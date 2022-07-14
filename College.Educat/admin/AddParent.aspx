<%@ Page Title="Add Subject" Language="C#" MasterPageFile="~/College.Master" AutoEventWireup="true" CodeBehind="AddParent.aspx.cs" Inherits="College.Educat.admin.AddParent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageNameContentPlaceHolder" runat="server">
    Parent Information
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card mb-3">
        <div class="card-header">
            Parent Information
        </div>
        <div class="card-body">

            <div class="row">
                <div class="col-md-6">
                    <div class="form-label-group">
                        <asp:TextBox ID="ParentBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="ParentBox">
                            Parent Name
                  <asp:RequiredFieldValidator
                      ID="r1" Text="Parent is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Paren is required"
                      ControlToValidate="ParentBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
                <asp:HiddenField ID="ScholIDField" runat="server" />
                <br />

                <div class="col-md-6">
                    <div class="form-label-group">
                        <asp:TextBox ID="ParentPhonenoBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="ParentPhonenoBox">
                            Parent Phone Number
                  <asp:RequiredFieldValidator
                      ID="r2" Text=" Parent Phone Number is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage=" Parent Phone Number is required"
                      ControlToValidate="ParentPhonenoBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>


            </div>
            <br />

            <div class="row">
                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="ParentEmailBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="ParentEmailBox">
                            Parent Email Address
                  <asp:RequiredFieldValidator
                      ID="r3" Text="Parent Email is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Parent Email is required"
                      ControlToValidate="ParentEmailBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
                <br />


               <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="AlternativePhoneNoBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="AlternativePhoneNoBox">
                            Alternative Phone Number
                  <asp:RequiredFieldValidator
                      ID="r4" Text="Phone Number is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Phone Numberis required"
                      ControlToValidate="AlternativePhoneNoBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>

                <br />


                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="CityBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="CityBox">
                            City 
                  <asp:RequiredFieldValidator
                      ID="r5" Text=" City is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage=" City is required"
                      ControlToValidate="CityBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
            </div>
            <br />

            <div class="row">

                <div class="col-md-6">
                    <div class="form-label-group">
                        <asp:DropDownList ID="StateDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>

                    </div>
                </div>
                <br />
                                           
                <div class="col-md-6">
                    <div class="form-label-group">
                        <asp:TextBox ID="ParentHomeAddressBox" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                        <label for="ParentHomeAddressBox">
                            Parent Home Address
                  <asp:RequiredFieldValidator
                      ID="r6" Text="Parent Address is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Parent Address is required"
                      ControlToValidate="ParentHomeAddressBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>                    
            </div>
            <br />

            <div class="col-sm-3">
                <asp:Button ID="btnSubmit" CssClass="btn btn-primary form-control " runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Label ID="lblMessage" runat="server" CssClass="alert-danger"></asp:Label>
            </div>
        </div>
        <div class="card-footer small text-muted">College Management Sysytem</div>
    </div>
</asp:Content>
