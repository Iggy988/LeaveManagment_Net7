using LeaveManagment.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagment.Web.Configurations.Entities;
public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(new IdentityRole
        {
            Id = "07e65fb8-2o67-4912-807b-db9c5578c15i",
            Name = Roles.Administrator,
            NormalizedName = Roles.Administrator.ToUpper(),
        },
        new IdentityRole
        {
            Id = "07e65fb7-2o67-4131-807b-db9c5578c15i",
            Name = Roles.User,
            NormalizedName = Roles.User.ToUpper(),
        });
    }
}