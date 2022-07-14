<%@ Page Title="" Language="C#" MasterPageFile="~/College.Master" AutoEventWireup="true" CodeBehind="AddSchoolInfo.aspx.cs" Inherits="College.Educat.admin.AddSchoolInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageNameContentPlaceHolder" runat="server">
    School Information
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
     <script>
//FileUpload1
function image_preview(e) {
            var reader = new FileReader();
            reader.onload = function () {
                var output = document.getElementById('<%: Image1.ClientID%>');
                output.src = reader.result;
            }
            reader.readAsDataURL(e.target.files[0]);
        }
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
      <div class="card mb-3">
        <div class="card-header">
            School Information
        </div>
        <div class="card-body">

            <div class="row">
                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="SchoolBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="SchoolBox">
                            School Name
                  <asp:RequiredFieldValidator
                      ID="r1" Text="School is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Surname is required"
                      ControlToValidate="SchoolBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>


                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="LocationBox" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
                        <label for="LocationBox">
                            Location Address
                  <asp:RequiredFieldValidator
                      ID="r2" Text="Location is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Location is required"
                      ControlToValidate="LocationBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:FileUpload ID="FileUpload1" Text="Upload" runat="server" onchange="image_preview(event)" />
                        <asp:Image ID="Image1" runat="server" BorderColor="Black" Width="120" Height="80" />
                        <label for="UploadButton">
                            School Logo                
                        </label>
                    </div>
                </div>
            </div>
            <div class="row">
                <hr />
            </div>

            <div class="row">
                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="EmailBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="EmailBox">
                            Email Address
                  <asp:RequiredFieldValidator
                      ID="r3" Text="Email is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Email is required"
                      ControlToValidate="EmailBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>

                <br />


                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="PhoneBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="PhoneBox">
                            Phone Number
                  <asp:RequiredFieldValidator
                      ID="r4" Text="Phone number is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Phone number is required"
                      ControlToValidate="PhoneBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>

                <br />


                <div class="col-md-4">
                    <div class="form-label-group">
                        <asp:TextBox ID="CurrentSessionBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="CurrentSessionBox">
                            Current Session 
                  <asp:RequiredFieldValidator
                      ID="r5" Text=" Current Session is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage=" Current Session is required"
                      ControlToValidate="CurrentSessionBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
            </div>

            <div class="row">
                <hr />
            </div>



            <div class="row">

                <div class="col-md-3">
                    <%--<div class="form-label-group">
                    <label>Current Term</label>--%>
                    <asp:DropDownList runat="server" ID="DropDownListCurrentTerm" CssClass="form-control">
                        <asp:ListItem value="0">Current Term</asp:ListItem>
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                    </asp:DropDownList>
                    <%-- </div>--%>
                </div>

                <div class="col-md-3">
                    <div class="form-label-group">
                        <asp:TextBox ID="SchoolshortnameBox" runat="server" CssClass="form-control"></asp:TextBox>
                        <label for="SchoolshortnameBox">
                            School Short Name
                  <asp:RequiredFieldValidator
                      ID="r7" Text="School shortname is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="School shortname is required"
                      ControlToValidate="SchoolshortnameBox"></asp:RequiredFieldValidator>
                        </label>

                    </div>
                </div>




                <div class="col-md-3">
                    <div class="form-label-group">
                        <asp:TextBox ID="CascoreBox" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <label for="CascoreBox">
                            CA Score
                  <asp:RequiredFieldValidator
                      ID="r8" Text="CA Score is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="CA Score is required"
                      ControlToValidate="CascoreBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>

                 <div class="col-md-3">
                    <div class="form-label-group">
                        <asp:TextBox ID="ExamBox" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <label for="ExamBox">
                            Exam Score
                  <asp:RequiredFieldValidator
                      ID="r9" Text="Exam Score is required"
                      ForeColor="Red"
                      runat="server"
                      ErrorMessage="Exam Score is required"
                      ControlToValidate="ExamBox"></asp:RequiredFieldValidator>
                        </label>
                    </div>
                </div>
            </div>
            <div class="row">
                <hr />
            </div>

            <div class="row">
                <asp:Button ID="btnSubmit" CssClass="btn btn-primary form-control " runat="server" Text="Submit" OnClick="btnSubmit_Click1" />
                <asp:Label ID="lblMessage" runat="server" CssClass="alert-danger"></asp:Label>
            </div>
        </div>
        <div class="card-footer small text-muted">College Management Sysytem</div>
    </div>

</asp:Content>
