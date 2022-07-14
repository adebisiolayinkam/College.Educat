<%@ Page Title="" Language="C#" MasterPageFile="~/College.Master" AutoEventWireup="true" CodeBehind="ShowSubject.aspx.cs" Inherits="College.Educat.admin.ShowSubject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageNameContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <div class="box-body">
        <div class="col-sm-4 form-group">
            <asp:TextBox ID="SubjectBox" runat="server" CssClass="form-control" placeholder="Search Subject"></asp:TextBox>
            <br />
            <span class="form-group">
                <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-info" OnClick="btnSearch_Click"  />

            </span>
        </div>
        &nbsp;
        <asp:GridView ID="GridView2" runat="server" CssClass="table table-hover table-bordered" EmptyDataText="No data yet" ShowHeaderWhenEmpty="True"  OnRowCommand="GridView2_RowCommand" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="subjectname" HeaderText="Subject" />
                
                <asp:ButtonField ButtonType="Button" CommandName="edit" ShowHeader="True" Text="Edit">
                    <ControlStyle CssClass="btn btn-info" />
                    <ItemStyle Width="10px" />
                </asp:ButtonField>
                <asp:ButtonField ButtonType="Button" CommandName="delete" ShowHeader="True" Text="Delete">
                    <ControlStyle BackColor="Red" BorderColor="#CC6699" CssClass="btn btn-danger" />
                    <ItemStyle Width="20px" />
                </asp:ButtonField>
                
            </Columns>

        </asp:GridView>
        <div>
            <br />
            <asp:Button ID="btnSubject" runat="server" Text="Add Subject" CssClass="btn btn-primary" Height="30px" Width="156px" OnClick="btnSubject_Click" />
            <br />
        </div>
    </div>
</asp:Content>

