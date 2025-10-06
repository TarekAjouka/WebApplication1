using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data;

public class ApplicationIdentityContext : IdentityDbContext<IdentityUser>
{
    public ApplicationIdentityContext(DbContextOptions<ApplicationIdentityContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "21ba7501-d5b1-4011-8e3b-9f6aeb6c8fc2",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = "60fb36d8-ad54-4043-88be-3dcac7ffa861",
                Name = "User",
                NormalizedName = "USER"
            },
            new IdentityRole
            {
                Id = "138e8e76-4d1a-4097-83d3-1e4f9f1c2e6b",
                Name = "Manager",
                NormalizedName = "MANAGER"
            }
        );

        builder.Entity<IdentityUser>().HasData(
            new IdentityUser
            {
                Id = "a1b2c3d4-e5f6-7890-abcd-1234567890ab",
                ConcurrencyStamp = "18355922-2447-4e45-95e1-aafdb5a44ffd", // static
                SecurityStamp = "a0d6d444-9b77-46b8-823f-ad41981dd278",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEPwzvXow6civY/r+WnS/ctnh0VtGmBg9MFUPf9EQfvrcNQZog8S1n7LKMTQINrNShA=="
            }
        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                UserId = "a1b2c3d4-e5f6-7890-abcd-1234567890ab",
                RoleId = "21ba7501-d5b1-4011-8e3b-9f6aeb6c8fc2" // Admin role Id
            }
        );
    }

}