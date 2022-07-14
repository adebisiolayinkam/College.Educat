<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="_leftsidebar.ascx.cs" Inherits="College.Educat.partials._leftsidebar" %>
<!-- Sidebar -->
<ul class="sidebar navbar-nav">
    <% if (!Page.User.IsInRole("admin") || !Page.User.IsInRole("Teacher"))
        { %>
    <li class="nav-item">
        <asp:Image ID="StudentPicture" runat="server" CssClass="" ImageUrl="~/students/MyPicture.ashx" />
    </li>
    <%} %>
    <li class="nav-item active">
        <a class="nav-link" href="index.html">
            <i class="fas fa-fw fa-tachometer-alt"></i>
            <span>Dashboard</span>
        </a>
    </li>
    <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="pagesDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
            <i class="fas fa-fw fa-folder"></i>
            <span>Application Setups</span>
        </a>
        <div class="dropdown-menu" aria-labelledby="pagesDropdown">
            <h6 class="dropdown-header">School Setup</h6>
            <a class="dropdown-item" href="AddSchoolInfo.aspx">School Information</a>
              <a class="dropdown-item" href="ShowStudentDetails.aspx">Student Information</a>
              <a class="dropdown-item" href="UploadScore.aspx">UpLoad Score</a>
            <a class="dropdown-item" href="#">Grades Setup</a>
            <a class="dropdown-item" href="ShowSubject.aspx">Subjects Setup</a>
            <a class="dropdown-item" href="#">Current Session Info</a>
        </div>
    </li>
    <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="pagesDropdown2" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
            <i class="fas fa-fw fa-folder"></i>
            <span>Classes Setup</span>
        </a>
        <div class="dropdown-menu" aria-labelledby="pagesDropdown">
            <h6 class="dropdown-header">Classes, Arms and Levels:</h6>
            <a class="dropdown-item" href="AddClasses.aspx">Classes Setup</a>
            <a class="dropdown-item" href="#">Class Arms Setup</a>
            <a class="dropdown-item" href="#">Class/Subjects Registration</a>
            <div class="dropdown-divider"></div>
            <h6 class="dropdown-header">Promotion to Next Level/Term:</h6>
            <a class="dropdown-item" href="#">Automatic</a>
            <a class="dropdown-item" href="#">Manual Promotion</a>
          
        </div>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="charts.html">
            <i class="fas fa-fw fa-chart-area"></i>
            <span>Charts</span></a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="#">
            <i class="fas fa-fw fa-table"></i>
            <span>Reset Users</span></a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="#" data-toggle="modal" data-target="#logoutModal">
            <i class="fas fa-fw fa-user"></i>
            <span>Logout</span></a>
    </li>
</ul>
