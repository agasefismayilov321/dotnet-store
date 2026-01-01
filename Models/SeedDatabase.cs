using Microsoft.AspNetCore.Identity;

namespace dotnet_store.Models;

public static class SeedDatabase
{
    public static async void Initialize(IApplicationBuilder app)
    {
        var userManager = app.ApplicationServices.
                            CreateScope().
                            ServiceProvider.
                            GetRequiredService<UserManager<AppUser>>();
        var roleManager = app.ApplicationServices.
                            CreateScope().
                            ServiceProvider.
                            GetRequiredService<RoleManager<AppRole>>();

        if (!roleManager.Roles.Any())
        {
            var adminRole = new AppRole{ Name = "Admin"};
            await roleManager.CreateAsync(adminRole);
        }

        if (!userManager.Users.Any())
        {
            var adminKullanici = new AppUser
            {
                AdSoyad = "Agasef Ismayilov",
                UserName = "agasefismayilov",
                Email = "agasefismayilov321@gmail.com"
            };

            await userManager.CreateAsync(adminKullanici,"123456789");
            await userManager.AddToRoleAsync(adminKullanici, "Admin");
        }
    }
}