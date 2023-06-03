<%@ Page Title="" Language="C#" MasterPageFile="~/College.Master" AutoEventWireup="true" CodeBehind="ReportPreview.aspx.cs" Inherits="College.Educat.admin.ReportPreview" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageNameContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card mb-3">
        <div class="card-header">
            Report Preview
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
                        <asp:DropDownList ID="DropDownListClassId" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="DropDownListClassId_SelectedIndexChanged"></asp:DropDownList>

                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-label-group1">
                        <label>Subject</label>
                        <asp:DropDownList ID="DropDownListStudents" runat="server" CssClass="form-control"></asp:DropDownList>

                    </div>
                </div>
                <div class="col-md-2">
                    <div class="form-label-group1">
                        <br />
                        <asp:Button runat="server" ID="Btnshow" Text="Display" CssClass="btn btn-info" OnClick="Btnshow_Click"></asp:Button>

                    </div>
                </div>

            </div>
            <div class="row">
                <div class="col-md-12">
                    <hr />
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%">
                    </rsweb:ReportViewer>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
