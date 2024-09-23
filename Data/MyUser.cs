using Microsoft.AspNetCore.Identity;

public class MyUser : IdentityUser
{
    public string? FavouriteColor { get; set; }
    
}