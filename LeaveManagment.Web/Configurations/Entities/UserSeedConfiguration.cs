using LeaveManagment.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagment.Web.Configurations.Entities;
public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        var hasher = new PasswordHasher<Employee>();
        builder.HasData(
            new Employee
             {
                Id = "f52402a2-4558-4ec2-ac2f-81d33d5e55fd",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                FirstName = "System",
                LastName = "Admin",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            },
            new Employee
            {
                Id = "07e65fb8-2e67-4912-807b-db9c5578c15a",
                Email = "user@localhost.com",
                NormalizedEmail = "USER@LOCALHOST.COM",
                NormalizedUserName = "USER@LOCALHOST.COM",
                UserName = "user@localhost.com",
                FirstName = "System",
                LastName = "User",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            }); 
    }
}