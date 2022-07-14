<%@ page title="" language="C#" masterpagefile="~/College.Master" autoeventwireup="true" codebehind="Default.aspx.cs" inherits="College.Educat.Reports.Default" %>

<%@ register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageNameContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content5" runat="server" ContentPlaceHolderID="MainContent">
    <div class="card mb-3">
        <div class="card-header">
            Title
        </div>
        <div class="card-body">
            
            <rsweb:reportviewer id="ReportViewer1" runat="server" width="100%" exportcontentdisposition="AlwaysAttachment"></rsweb:reportviewer>
        </div>
        <div class="card-footer small text-muted">Footer</div>
    </div>

</asp:Content>

