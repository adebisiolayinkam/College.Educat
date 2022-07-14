<%@ Page Title="" Language="C#" MasterPageFile="~/College.Master" AutoEventWireup="true" CodeBehind="AddSubject.aspx.cs" Inherits="College.Educat.admin.AddSubject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageNameContentPlaceHolder" runat="server">
    Add Subject
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
                <div class="col-md-12">
                    <div class="form-label-group">
                        <asp:TextBox ID="SubjectBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="SubjectBox">
                            Subject Name
                  <asp:RequiredFieldValidator
                      ID="r1" Text="Subject is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Subject is required"
                      ControlToValidate="SubjectBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
               </div>
            <br />

            

             <br />
            <div class="col-sm-3">
                <asp:Button ID="btnSubmit" CssClass="btn btn-primary form-control " runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Label ID="lblMessage" runat="server" CssClass="alert-danger"></asp:Label>
            </div>
        </div>
        <div class="card-footer small text-muted">College Management Sysytem</div>
    </div>
</asp:Content>