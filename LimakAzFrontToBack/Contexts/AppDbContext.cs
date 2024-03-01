using LimakAzFrontToBack.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LimakAzFrontToBack.Contexts;

public class AppDbContext:IdentityDbContext<AppUser,IdentityRole<int>,int>
{
    public AppDbContext(DbContextOptions<AppDbContext> opt):base(opt)
    {
        
    }
}
