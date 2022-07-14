<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDetails.aspx.cs" Inherits="College.Educat.StudentDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bio-Data</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
           <fieldset class="fiel1">
            <legend class="leg1">Personal Information</legend>

        <div class="row">
            <div class="col-md-4">
                <asp:Label ID="Label1" runat="server" Text="Surname:"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server">Surname</asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server">First Name</asp:TextBox>
            </div>
            <div class="col-md-4">
             <%--   <img class="img-circle" height="100" width="100" />--%>
                <asp:Image ID="Image1" CssClass="img-circle" runat="server" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-4">
                 <asp:Label ID="Label4" runat="server" Text="Other Name:"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server">Other Name</asp:TextBox>
                </div>

               <div class="col-md-4">
                <asp:Label ID="Label3" runat="server" Text="Gender:"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server">Gender</asp:TextBox>
            </div>  
            
            <div class="col-md-4">
                  <asp:Label ID="Label5" runat="server" Text="Current ClassID:"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server">Current ClassID</asp:TextBox>
            </div>
            </div>
        
           <div class="row">
            <div class="col-md-4">
                  <asp:Label ID="Label6" runat="server" Text="Current Session:"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server">Current Session</asp:TextBox>
            </div>
            
            <div class="col-md-4">
                  <asp:Label ID="Label7" runat="server" Text="Current Term:"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server">Current Term</asp:TextBox>
            </div>
           
            <div class="col-md-4">
                 <asp:Label ID="Label8" runat="server" Text="ArmID:"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server">ArmID</asp:TextBox>
            </div> 
            </div>

        <div class="row">
            <div class="col-md-4">
                  <asp:Label ID="Label9" runat="server" Text="Guardian Names:"></asp:Label>
                <asp:TextBox ID="TextBox9" runat="server">Guardian Names</asp:TextBox>
            </div>
            
            <div class="col-md-4">
                  <asp:Label ID="Label10" runat="server" Text="Guardian PhoneNo:"></asp:Label>
                <asp:TextBox ID="TextBox10" runat="server">Guardian PhoneNo</asp:TextBox>
            </div>
           
            <div class="col-md-4">
                 <asp:Label ID="Label11" runat="server" Text="Guardian Email:"></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server">Guardian Email</asp:TextBox>
            </div> 
            </div>

               <div class="row">
            <div class="col-md-4">
                  <asp:Label ID="Label12" runat="server" Text="Home Address:"></asp:Label>
                <asp:TextBox ID="TextBox12" runat="server">Home Address</asp:TextBox>
            </div>
            
            <div class="col-md-4">
                  <asp:Label ID="Label13" runat="server" Text="City:"></asp:Label>
                <asp:TextBox ID="TextBox13" runat="server">City</asp:TextBox>
            </div>
           
            <div class="col-md-4">
                 <asp:Label ID="Label14" runat="server" Text="State:"></asp:Label>
                <asp:TextBox ID="TextBox14" runat="server">State</asp:TextBox>
            </div> 
            </div>

                <div class="row">
            <div class="col-md-3">
                  <asp:Label ID="Label15" runat="server" Text="Year of Entery:"></asp:Label>
                <asp:TextBox ID="TextBox15" runat="server">Year of Entery</asp:TextBox>
            </div>
            
            <div class="col-md-3">
                  <asp:Label ID="Label16" runat="server" Text="Graduated:"></asp:Label>
                <asp:TextBox ID="TextBox16" runat="server">Graduated</asp:TextBox>
            </div>
           
            <div class="col-md-3">
                 <asp:Label ID="Label17" runat="server" Text="Year of Graduation:"></asp:Label>
                <asp:TextBox ID="TextBox17" runat="server">Year of Graduation</asp:TextBox>
            </div> 

              <div class="col-md-3">
                 <asp:Label ID="Label18" runat="server" Text="ParentID:"></asp:Label>
                <asp:TextBox ID="TextBox18" runat="server">ParentID</asp:TextBox>
            </div> 
            </div>
        
               <div class="row">
                   <asp:Button ID="Button1" runat="server" Text="Submit" />
               </div>

</fieldset>

    </form>

    <script src="Scripts/jquery-3.4.1.js"></script>
    <script src="Content/vendor/bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
