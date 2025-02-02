using Microsoft.AspNetCore.Identity;
using ShoppingCart1.Constants;

namespace ShoppingCart1.Data
{
    public class Dbseeder
    {


        public static async Task SeedfaultData(IServiceProvider service)
        {
            var userMgr = service.GetRequiredService<UserManager<IdentityUser>>();
            var roleMgr = service.GetRequiredService<RoleManager<IdentityRole>>();


            // Check and add roles if they don't exist
            if (!await roleMgr.RoleExistsAsync(Role.Admin.ToString()))
            {
                await roleMgr.CreateAsync(new IdentityRole(Role.Admin.ToString()));
            }
            if (!await roleMgr.RoleExistsAsync(Role.User.ToString()))
            {
                await roleMgr.CreateAsync(new IdentityRole(Role.User.ToString()));
            }

            // create Admin User

            var admin = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true

            };


            var result = await userMgr.CreateAsync(admin, "Admin@123");
            if (result.Succeeded)
            {
                await userMgr.AddToRoleAsync(admin, Role.Admin.ToString());
            }

        }
    }
}
