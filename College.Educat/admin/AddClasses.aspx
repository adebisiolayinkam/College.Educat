<%@ Page Title="" Language="C#" MasterPageFile="~/College.Master" AutoEventWireup="true" CodeBehind="AddClasses.aspx.cs" Inherits="College.Educat.admin.AddClasses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageNameContentPlaceHolder" runat="server">
    Add Classes
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
      <div class="card mb-3">
        <div class="card-header">
            Add Classes
        </div>
        <div class="card-body">

            <div class="row">
                <div class="col-md-6">
                    <div class="form-label-group">
                        <asp:TextBox ID="ClassBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="ClassBox">
                            Class Name
                  <asp:RequiredFieldValidator
                      ID="r1" Text="Class is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Class is required"
                      ControlToValidate="ClassBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
                <asp:HiddenField ID="ScholIDField" runat="server" />
                <br />

                <div class="col-md-6">
                    <div class="form-label-group">
                        <asp:TextBox ID="NextClassBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="NextClassBox">
                            Next Class
                  <asp:RequiredFieldValidator
                      ID="r2" Text=" NextClass is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage=" NextClassBox is required"
                      ControlToValidate="NextClassBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>


            </div>
            <br />

            <div class="row">
                <div class="col-md-12">
                    <div class="form-label-group">
                        <asp:TextBox ID="ClasstypeBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="ClasstypeBox">
                           Class Type
                  <asp:RequiredFieldValidator
                      ID="r3" Text="Class type is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Class type is required"
                      ControlToValidate="ClasstypeBox"></asp:RequiredFieldValidator>
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