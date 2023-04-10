<%@ Page Title="" Language="C#" MasterPageFile="~/College.Master" AutoEventWireup="true" CodeBehind="ShowStudentDetails.aspx.cs" Inherits="College.Educat.admin.ShowStudentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageNameContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="box-body">
                <div class="row">
                    <div class="col-md-3 form-group">
                        <asp:TextBox ID="IdNumberBox" runat="server" CssClass="form-control" placeholder="Search Identity Number"></asp:TextBox>
                        </div>

                        <div class="col-md-2 form-group">
                        <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-info" OnClick="btnSearch_Click" /> 
                        </div>

                            <div class="col-md-3 form-group">
                              <asp:DropDownList ID="DropDownListClassID" runat="server" CssClass="form-control"></asp:DropDownList>
                            </div>
                         <div class="col-md-2 form-group">
                        <asp:Button ID="btnClassSearch" runat="server" Text="Search Class" CssClass="btn btn-info" OnClick="btnClassSearch_Click" /> 
                        </div>
                      
                    <div class="col-md-2 form-group">
                        <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0">
                            <ProgressTemplate>
                                Please wait...
                            </ProgressTemplate>
                        </asp:UpdateProgress>
                    </div>
                </div>

                <div class="row">
                    <div class="col-12">
                        <asp:GridView ID="GridView2" runat="server" CssClass="table table-hover table-bordered" EmptyDataText="No data yet" ShowHeaderWhenEmpty="True" OnRowCommand="GridView2_RowCommand" AutoGenerateColumns="False" OnRowDeleting="GridView2_RowDeleting">
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Student ID" />
                                <asp:BoundField DataField="LastName" HeaderText="Surname" />
                                <asp:BoundField DataField="firstname" HeaderText="First Name" />
                                <asp:BoundField DataField="othername" HeaderText="Other Names" />
                                <asp:BoundField DataField="gender" HeaderText="Gender" />
                                <asp:BoundField DataField="currentlevel" HeaderText="Current Class" />
                                <asp:BoundField DataField="Arm" HeaderText="Arm" />
                                <asp:BoundField DataField="stateoforigin" HeaderText="State" />
                                <asp:BoundField DataField="dob" DataFormatString="{0:dd-MM-yyyy}" HeaderText="Date of Birth" />

                                <asp:ButtonField ButtonType="Button" CommandName="delete" ShowHeader="True" Text="Delete">
                                    <ControlStyle BackColor="Red" BorderColor="#CC6699" CssClass="btn btn-danger" />
                                    <ItemStyle Width="20px" />
                                </asp:ButtonField>
                                <asp:ButtonField ButtonType="Button" CommandName="edit" ShowHeader="True" Text="Edit">
                                    <ControlStyle CssClass="btn btn-info" />
                                    <ItemStyle Width="10px" />
                                </asp:ButtonField>

                            </Columns>

                        </asp:GridView>
                    </div>
                </div>

                <div class="row">
                    <hr />
                    <div class="col-12">
                        <asp:Button ID="btnNewStudent" runat="server" Text="New Student" CssClass="btn btn-primary" Height="30px" Width="156px" OnClick="btnNewStudent_Click" />
                    </div>
                    <br />
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
