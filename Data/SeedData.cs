using Microsoft.AspNetCore.Identity;

namespace StudyPlannerSoft.Data;

public static class SeedData
{
    public static async Task Initialize(UserManager<MyUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        await SeedRoles(roleManager);
        await SeedUsers(userManager, roleManager);
    }

    private static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
    {
        string[] roleNames = { "Admin", "Deputy", "Lecturer", "Faculty", "Department" };

        foreach (var roleName in roleNames)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }
    }

    private static async Task SeedUsers(UserManager<MyUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        string userName = "admin@viko.lt";
        string password = "Kolegija1@";

        if (await userManager.FindByNameAsync(userName) == null)
        {
            var user = new MyUser()
            {
                UserName = userName,
                Email = userName,
                EmailConfirmed = true,
                FavouriteColor = "Red"
            };

            var result = await userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}

