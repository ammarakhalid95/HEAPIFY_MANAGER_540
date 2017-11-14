using HEAPIFY_Manager_540.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HEAPIFY_Manager_540.Startup))]
namespace HEAPIFY_Manager_540
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();
        }
        private void CreateRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            
            if (!roleManager.RoleExists("IT Administrator"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "IT Administrator";
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.UserName = "HEAP";
                user.Email = "heapify540@gmail.com";

                string userPWD = "Password1!";

                var chkUser = UserManager.Create(user, userPWD);
   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "IT Administrator");
                }
            }

            if (!roleManager.RoleExists("Employee"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Employee";
                roleManager.Create(role);

            }

            if (!roleManager.RoleExists("Medical Receptionist"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Medical Receptionist";
                roleManager.Create(role);

            }

            if (!roleManager.RoleExists("Medical Staff"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Medical Staff";
                roleManager.Create(role);

            }

            if (!roleManager.RoleExists("Patient Billing Representative"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Patient Billing Representative";
                roleManager.Create(role);

            }
        }
    }

   

}
