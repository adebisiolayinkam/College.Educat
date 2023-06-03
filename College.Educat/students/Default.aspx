<%@ Page Title="" Language="C#" MasterPageFile="~/College.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="College.Educat.students.Default" %>
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
                             Term
                  
                        </label>
                         <asp:DropDownList ID="DropDownListTerm" runat="server" CssClass="form-control">
                             <asp:ListItem Text="1" Value="1" ></asp:ListItem>
                             <asp:ListItem Text="2" Value="2" ></asp:ListItem>
                             <asp:ListItem Text="3" Value="3"></asp:ListItem>

                         </asp:DropDownList> 

                    </div>
                </div>
                <div class="col-md-4">
                    <div class="form-label-group1">
                        <label>Class</label>
                        <asp:DropDownList ID="DropDownListClass" runat="server" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
                                                                                                                                                    
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-label-group1">
                        <br />
                        <asp:Button runat="server" ID="Btncheck" Text="Check " CssClass="btn btn-info"></asp:Button>
                    </div>
                </div>

            </div>

            <br />

             <div class="row">
                <div class="col-md-12">
                    <div class="form-label-group1">
                        <br />
                         <asp:Button runat="server" ID="Btnshow" Text="Display All Report" CssClass="btn btn-info"  OnClick="Btnshow_Click" ></asp:Button>
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
