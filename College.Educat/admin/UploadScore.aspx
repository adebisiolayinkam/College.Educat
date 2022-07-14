<%@ Page Title="" Language="C#" MasterPageFile="~/College.Master" AutoEventWireup="true" CodeBehind="UploadScore.aspx.cs" Inherits="College.Educat.admin.UploadScore" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageNameContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card mb-3">
        <div class="card-header">
           Upload File
        </div>
        <div class="card-body">

            <div class="row">
                <div class="col-md-2">
                    <div class="form-label-group1">
                        <label>
                            Current Session
                  
                        </label>
                        <asp:Label ID="CurrentSessionLabel" runat="server" CssClass="form-control" />

                    </div>
                </div>

                <br />

                <div class="col-md-2">
                    <div class="form-label-group1">
                        <label>
                            Current Term
                  
                        </label>
                        <asp:Label ID="CurrentTermLabel" runat="server" CssClass="form-control" />

                    </div>
                </div>

                <div class="col-md-2">
                    <div class="form-label-group1">
                        <label>Current Class</label>
                        <asp:DropDownList ID="DropDownListClassId" runat="server" CssClass="form-control"></asp:DropDownList>

                    </div>
                </div>
                <div class="col-md-2">
                    <div class="form-label-group1">
                        <label>Class Arm</label>
                        <asp:DropDownList ID="DropDownListArm" runat="server" CssClass="form-control"></asp:DropDownList>

                    </div>
                </div>
                <div class="col-md-4">
                    <div class="form-label-group1">
                        <label>Subject</label>
                        <asp:DropDownList ID="DropDownListSubject" runat="server" CssClass="form-control"></asp:DropDownList>

                    </div>
                </div>
            </div>
           

            <div class="row">

                <hr />



            </div>
           


            <div class="row">

                <div class="col-md-4">
                    <div class="form-label-group1">
                        <asp:FileUpload ID="fUpload" runat="server" />
                    </div>
                </div>
                <br />

                <div class="col-md-4">
                    <div class="form-label-group1">
                        <asp:Button ID="btnDisplay" CssClass="btn btn-primary" runat="server" Text="Display" OnClick="btnDisplay_Click" />

                    </div>
                </div>

                <br />

                <div class="col-md-4">
                    <div class="form-label-group1">
                        <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" OnClientClick="return confirm('Are you sure you want to save these score for the selected subject')" />
                    </div>
                </div>
            </div>
            <br />

            <asp:GridView ID="tbScore" runat="server" CssClass="table table-hover table-bordered"></asp:GridView>

            <div class="col-sm-3">
                <asp:Button ID="btnReport" CssClass="btn btn-primary form-control " runat="server" Text="Reports" />
                <asp:Label ID="lblMessage" runat="server" CssClass="alert-danger"></asp:Label>
            </div>
        </div>
        <div class="card-footer small text-muted">College Management Sysytem</div>
    </div>
</asp:Content>

