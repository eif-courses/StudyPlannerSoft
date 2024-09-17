using Microsoft.AspNetCore.Identity;

namespace StudyPlannerSoft.Data;

public static class SeedData
{
    public static async Task Initialize(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        string roleName = "Admin";
        string userName = "admin@viko.lt";
        string password = "Kolegija1@";
        

        if (!await roleManager.RoleExistsAsync(roleName))
        {
            await roleManager.CreateAsync(new IdentityRole(roleName));
        }
        
        if (await userManager.FindByNameAsync(userName) == null)
        {
            var user = new IdentityUser
            {
                UserName = userName,
                Email = userName,
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, roleName);
            }
        }
    }
}