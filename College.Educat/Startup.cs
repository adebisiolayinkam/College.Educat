using College.Educat.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System.Threading.Tasks;

[assembly: OwinStartupAttribute(typeof(College.Educat.Startup))]
namespace College.Educat
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
            Task.Run(() => InitialiseMyAppAsync());
        }
 
        private async Task InitialiseMyAppAsync()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                using (UserManager<ApplicationUser> UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context)))
                {
                    using (RoleManager<IdentityRole> rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context)))
                    {

                        string[] roles = { "admin", "students", "parents","bursar" };

                        foreach (var r in roles)
                            if (!rolemanager.RoleExists(r))
                                await rolemanager.CreateAsync(new IdentityRole(r));

                        ApplicationUser user1 = await UserManager.FindByNameAsync("akansa");
                        if (user1 == null)
                        {
                            SiteUser create = new SiteUser()
                            {
                                UserName = "akansa",
                                Email = "akansa@abblack.sch.ng",
                                Password = "abcd_1234",
                                PhoneNo = "08098110501",
                                RoleName = roles[0],
                                DeleteFirst = false
                            };
                            await create.Create();
                        }

                        user1 = await UserManager.FindByNameAsync("mysuperadmin");
                        if (user1 == null)
                        {
                            SiteUser create = new SiteUser()
                            {
                                UserName = "mysuperadmin",
                                Email = "mysuperadmin@abblack.sch.ng",
                                Password = "abcd_1234",
                                PhoneNo = "08098110501",
                                RoleName = roles[0],
                                DeleteFirst = false
                            };

                            await create.Create();
                        }
                        
                        user1 = await UserManager.FindByNameAsync("Bursar");
                        if (user1 == null)
                        {
                            SiteUser create = new SiteUser()
                            {
                                UserName = "Bursar",
                                Email = "bursar@abblack.sch.ng",
                                Password = "abcd_1234",
                                PhoneNo = "08098110501",
                                RoleName = roles[3],
                                DeleteFirst = false
                            };

                            await create.Create();
                        }

                        user1 = await UserManager.FindByNameAsync("mc");
                        if (user1 == null)
                        {
                            SiteUser create = new SiteUser()
                            {
                                UserName = "mc",
                                Email = "mc@abblack.sch.ng",
                                Password = "abcd_1234",
                                PhoneNo = "08098110501",
                                RoleName = roles[0],
                                DeleteFirst = false
                            };
                            await create.Create();
                        }
                        user1 = await UserManager.FindByNameAsync("charlse");
                        if (user1 == null)
                        {
                            SiteUser create = new SiteUser()
                            {
                                UserName = "charlse",
                                Email = "charlse@abblack.sch.ng",
                                Password = "abcd_1234",
                                PhoneNo = "08098110501",
                                RoleName = roles[0],
                                DeleteFirst = false
                            };
                            await create.Create();
                        }
                        user1 = await UserManager.FindByNameAsync("gabriel");
                        if (user1 == null)
                        {
                            SiteUser create = new SiteUser()
                            {
                                UserName = "gabriel",
                                Email = "gabriel@abblack.sch.ng",
                                Password = "abcd_1234",
                                PhoneNo = "08098110501",
                                RoleName = roles[0],
                                DeleteFirst = false
                            };
                            await create.Create();
                        }
                    }
                }
            }
        }
    }
    
}
