<%@ Page Title="" Language="C#" MasterPageFile="~/College.Master" AutoEventWireup="true" CodeBehind="ResultPreview.aspx.cs" Inherits="College.Educat.admin.ResultPreview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageNameContentPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
 
     <div class="card mb-3">
        <div class="card-header">
         Result Preview
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
                
                <div class="col-md-4">
                    <div class="form-label-group1">
                        <label>Subject</label>
                        <asp:DropDownList ID="DropDownListSubject" runat="server" CssClass="form-control"></asp:DropDownList>

                    </div>
                </div>
                <div class="col-md-2">
                    <div class="form-label-group1">
                        <br />
                        <asp:button runat="server" ID="btnshow" Text="Display" CssClass="btn btn-info"></asp:button>
                        <asp:DropDownList ID="DropDownListArm" Visible="false" runat="server" CssClass="form-control"></asp:DropDownList>

                    </div>
                </div>
            </div>
           

            <div class="row">

                <hr />



            </div>
           


            
            <div class="row">
                <div class="col-md-12">
                                <asp:GridView ID="tbScore" runat="server" CssClass="table table-hover table-bordered"></asp:GridView>

                </div>
            </div>

            <div class="row">
                <div class="col-md-12">
                    <hr />
                </div>
                </div>
            <div class="row">
                <div class="col-md-12">
                    <hr />
                </div>
                </div>

        </div>
        <div class="card-footer small text-muted">College Management Sysytem</div>
    </div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
