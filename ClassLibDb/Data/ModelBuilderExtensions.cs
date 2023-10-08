using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace ClassLibDb.Data
{
public static class ModelBuilderExtensions {
    public static void SeedRoles(this ModelBuilder builder) {
        var pwd = "P@$$w0rd";
        var passwordHasher = new PasswordHasher<IdentityUser>();

        // Seed Roles
        var adminRole = new IdentityRole("Admin");
        adminRole.NormalizedName = adminRole.Name.ToUpper();

        var finaceRole = new IdentityRole("Finance");
        finaceRole .NormalizedName = finaceRole.Name.ToUpper();

        List<IdentityRole> roles = new List<IdentityRole>() {
           adminRole,
           finaceRole
        };

        builder.Entity<IdentityRole>().HasData(roles);

         
        // Seed Users
        var adminUser = new IdentityUser {
            UserName = "aa@aa.aa",
            Email = "aa@aa.aa",
            EmailConfirmed = true,
        };
        adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
        adminUser.NormalizedEmail = adminUser.Email.ToUpper();
        adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, pwd);

        var finaceUser = new IdentityUser {
            UserName = "f@f.f",
            Email = "f@f.f",
            EmailConfirmed = true,
        };
        finaceUser.NormalizedUserName = finaceUser.UserName.ToUpper();
        finaceUser.NormalizedEmail = finaceUser.Email.ToUpper();
        finaceUser.PasswordHash = passwordHasher.HashPassword(finaceUser, pwd);

        List<IdentityUser> users = new List<IdentityUser>() {
           adminUser,
           finaceUser,
        };

        builder.Entity<IdentityUser>().HasData(users);

        // Seed FinanceRoles
        List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

        userRoles.Add(new IdentityUserRole<string> {
            UserId = users[0].Id,
            RoleId = roles.First(q => q.Name == "Admin").Id
        });

        userRoles.Add(new IdentityUserRole<string> {
            UserId = users[1].Id,
            RoleId = roles.First(q => q.Name == "Finance").Id
        });


        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
    }
}

}