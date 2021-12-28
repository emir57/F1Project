using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace f1project.webui.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager,RoleManager<IdentityRole> roleManager,IConfiguration configuration)
        {
            var username = configuration["Data:AdminUser:username"];
            var password = configuration["Data:AdminUser:password"];
            var email = configuration["Data:AdminUser:email"];
            var role = configuration["Data:AdminUser:role"];
            var editorRole = "Editör";
            var checkRole = await roleManager.FindByNameAsync(editorRole);
            if(checkRole == null)
            {
                await roleManager.CreateAsync(new IdentityRole{Name=editorRole});
            }
            if(await userManager.FindByNameAsync(username)==null)
            {
                
                await roleManager.CreateAsync(new IdentityRole(role));
                var user = new User(){
                    FirstName="admin",
                    LastName="admin",
                    ProfileDescription="standart admin kullanıcısı.",
                    UserName = username,
                    Email = email,
                    EmailConfirmed=true
                    
                };
                var result = await userManager.CreateAsync(user,password);
                if(result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user,role);
                }
            }
        }
    }
}