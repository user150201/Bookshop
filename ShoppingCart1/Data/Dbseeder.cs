using Microsoft.AspNetCore.Identity;
using ShoppingCart1.Constants;

namespace ShoppingCart1.Data
{
    public class Dbseeder
    {


        public static async Task SeedfaultData(IServiceProvider service)
        {
            var userMgr =service.GetService<UserManager<IdentityUser>>();
             var roleMgr = service.GetService<RoleManager<IdentityRole>>();

            //adding some role to db
            await roleMgr.CreateAsync(new IdentityRole(Role.Admin.ToString()));
            await roleMgr.CreateAsync(new IdentityRole(Role.User.ToString()));

            // create Admin User

            var admin = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true

            };

            var userInDb=await userMgr.FindByEmailAsync(admin.Email);
            if (userInDb is null)
            {
                await userMgr.CreateAsync(admin, "Admin@123");
                await userMgr.AddToRoleAsync(admin,Role.Admin.ToString());
            }

        }
    }
}
