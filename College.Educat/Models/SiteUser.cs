using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;

namespace College.Educat.Models
{
    public class SiteUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public string PhoneNo { get; set; }
        public bool DeleteFirst { get; set; }
        public string LastError { get; set; }

        public async Task<bool> Create()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {

                UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                ApplicationUser user1 = await userManager.FindByNameAsync(UserName);

                if (DeleteFirst)
                {
                    if (user1 != null)
                    {
                        await userManager.DeleteAsync(user1);
                    }
                }

                IdentityResult answer = await userManager.CreateAsync(new ApplicationUser()
                {
                    UserName = UserName,
                    PhoneNumber = PhoneNo,
                    LockoutEnabled = true,
                    Email = Email,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                }, Password);

                bool Answer;
                if (answer.Succeeded)
                {
                    user1 = userManager.FindByName(UserName);
                    foreach (var rol in user1.Roles)
                    {
                        await userManager.RemoveFromRoleAsync(user1.Id, rol.RoleId);
                    }

                    userManager.AddToRole(user1.Id, RoleName);

                    Answer = true;
                    LastError = "";
                }
                else
                {
                    foreach (var er in answer.Errors)
                    {
                        LastError += er + " ";
                    }

                    Answer = false;
                }
                return Answer;
            }
        }

        public string[] GetAllRoles()
        {
            string[] roles = new string[2];

            return roles;
        }

        public bool ChangeRole(string Newrole)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                using (UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db)))
                {
                    ApplicationUser user1 = userManager.FindByName(UserName);
                    if (user1 != null)
                    {
                        user1.Roles.Clear();
                        userManager.Update(user1);
                        IdentityResult answer = userManager.AddToRole(user1.Id, Newrole);
                        userManager.Update(user1);
                        return answer.Succeeded == true;
                    }
                    return false;
                }
            }
        }
        public bool ResetPassword(string NewPassword)
        {
            bool Answer = false;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                ApplicationUser user1 = userManager.FindByName(UserName);
                if (user1 != null)
                {
                    var result = userManager.RemovePassword(user1.Id);
                    result = userManager.AddPassword(user1.Id, NewPassword);
                    if (result.Succeeded)
                        Answer = true;
                }
            }
            return Answer;
        }

        public bool ChangePassword(string NewPassword)
        {
            bool Answer = false;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                ApplicationUser user1 = userManager.FindByName(UserName);
                if (user1 != null)
                {
                    var result = userManager.ResetPassword(user1.Id, user1.SecurityStamp, NewPassword);// UserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);
                    if (result.Succeeded)
                    {
                        Answer = true;
                    }
                }
            }
            return Answer;
        }

        public async Task<bool> ChangePasswordAsync(string NewPassword)
        {
            bool Answer = false;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                UserManager<ApplicationUser> manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                ApplicationUser user1 = await manager.FindByNameAsync(UserName);
                if (user1 != null)
                {
                    var result = await manager.ChangePasswordAsync(user1.Id, Password, NewPassword);
                    if (result.Succeeded)
                        Answer = true;
                }
            }
            return Answer;
        }

        public async Task<bool> ResetUserPassword(string NewPassword)
        {
            bool Answer = false;

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                UserStore<ApplicationUser> store = new UserStore<ApplicationUser>(context);
                ApplicationUser user1 = await userManager.FindByNameAsync(UserName);
                if (user1 != null)
                {
                    string hashedNewPassword = userManager.PasswordHasher.HashPassword(NewPassword);
                    await store.SetPasswordHashAsync(user1, hashedNewPassword);
                    await store.UpdateAsync(user1);
                    Answer = true;
                }
            }
            return Answer;
        }
    }
}