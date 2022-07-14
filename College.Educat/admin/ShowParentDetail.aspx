<%@ Page Title="" Language="C#" MasterPageFile="~/College.Master" AutoEventWireup="true" CodeBehind="ShowParentDetail.aspx.cs" Inherits="College.Educat.admin.ShowParentDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageNameContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="box-body">
        <div class="col-sm-4 form-group">
            <asp:TextBox ID="ParentPhoneBox" runat="server" CssClass="form-control" placeholder="Search Record"></asp:TextBox>
            <br />
            <span class="form-group">
                <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-info"/>
                
            </span>
        </div>
        &nbsp;
        <asp:GridView ID="GridView2" runat="server" CssClass="table table-hover table-bordered" EmptyDataText="No data yet" ShowHeaderWhenEmpty="True">
            <Columns>
                <asp:BoundField DataField="Edit" HeaderText="Edit">
                <ControlStyle CssClass="btn btn-info" />
                <ItemStyle CssClass="10px" />
                </asp:BoundField>
                <asp:BoundField DataField="Delete" HeaderText="Delete">
                <ControlStyle BackColor="Red" BorderColor="#CC6699" CssClass="btn btn-danger" />
                <ItemStyle Width="20px" />
                </asp:BoundField>
            </Columns>

        </asp:GridView>
        <div>
            <br />
            <asp:Button ID="btnNewStudent" runat="server" Text="New Student" CssClass="btn btn-primary" Height="30px" Width="156px" />
            <br />
        </div>
    </div>
</asp:Content>