using System;
using System.Web;
using Microsoft.AspNet.Identity.Owin;

namespace College.Educat
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected async void SubmitButton_Click(object sender, EventArgs e)
        {
            Validate();

            if (IsValid)
            {
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();
                var result = await signinManager.PasswordSignInAsync(
                                                 userName: UserNameBox.Text,
                                                 password: PasswordBox.Text,
                                                 isPersistent: RememberMeBox.Checked,
                                                 shouldLockout: false);

                switch (result)
                {
                    case SignInStatus.Success:
                        Response.Redirect("~/Auth/", false);
                        break;
                    case SignInStatus.LockedOut:
                    case SignInStatus.RequiresVerification:
                    case SignInStatus.Failure:
                    default:
                        SpanError.Text = "Invalid login attempt";
                        break;
                }
            }
        }
    }
}