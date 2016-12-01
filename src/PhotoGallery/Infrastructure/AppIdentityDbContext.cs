using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhotoGallery.Entities;
namespace PhotoGallery.Infrastructure 
{

    public class AppIdentityDbContext : IdentityDbContext<ApplicationUser> 
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
            : base(options) 
            { 
                Database.EnsureCreated();
            }
    }
}
