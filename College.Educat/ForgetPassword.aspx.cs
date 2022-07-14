using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace College.Educat
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void ButtonForget_Click(object sender, EventArgs e)
        {
            Validate();

            if (IsValid)
            {
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();

                var user = await signinManager.UserManager.FindByNameAsync(EmailBox.Text);
                if(user != null)
                {

                }
            }
        }
    }
}