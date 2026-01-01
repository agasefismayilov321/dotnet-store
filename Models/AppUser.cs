using dotnet_store.Models;
using Microsoft.AspNetCore.Identity;

public class AppUser : IdentityUser<int>
{
    public string AdSoyad { get; set; } = null!;
}