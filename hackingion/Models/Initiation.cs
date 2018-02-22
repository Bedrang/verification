using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hackingion.Models
{
    public class Initiation
    { 
     public static async Task InitializeAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        string username = "Admin";
        string password = "unotallowedthere";
        if (await roleManager.FindByNameAsync("Admin") == null)
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));
        }
        if (await roleManager.FindByNameAsync("User") == null)
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));
        }
        if (await userManager.FindByNameAsync(username) == null)
        {
            AppUser Admin = new AppUser { UserName = username, Password = password };
            IdentityResult result = await userManager.CreateAsync(Admin, password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(Admin, "Admin");
            }
        }
    }


    }
}
