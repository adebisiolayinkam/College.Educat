using Microsoft.AspNet.Identity;
using System;
using System.Web;

namespace College.Educat.auth
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.IsInRole("students") || User.IsInRole("parents"))
            {
                Response.Redirect("~/students");
            }
            else if (User.IsInRole("admin"))
            {
                Response.Redirect("~/admin");
            }
            else
            {
                Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
                Response.Redirect("~/SignIn");
            }
        }
    }
}