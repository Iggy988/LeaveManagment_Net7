using LeaveManagment.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagment.Web.Configurations.Entities;
public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
    {
        builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "07e65fb8-2o67-4912-807b-db9c5578c15i",
                UserId = "f52402a2-4558-4ec2-ac2f-81d33d5e55fd"
            },
            new IdentityUserRole<string>
            {
                RoleId = "07e65fb7-2o67-4131-807b-db9c5578c15i",
                UserId = "07e65fb8-2e67-4912-807b-db9c5578c15a"
            });
    }
}