using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class Allocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07e65fb8-2e67-4912-807b-db9c5578c15a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "189cb2b8-9323-4813-ba33-5e154163190f", "AQAAAAIAAYagAAAAEIpQCmPZYAb3FnjRGKbhtBC53GCHmzHQfO+xhp1M819vtDQT3sUqS9xyhpzmY+3MDg==", "26dbb82f-4ba2-4175-9838-0d34df2d41ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52402a2-4558-4ec2-ac2f-81d33d5e55fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15eaaeb9-5dc6-4586-b12c-7de8d04d6b3a", "AQAAAAIAAYagAAAAELDAdrke31ZYblRhenvwbvR6upHquOum2diCmR0LX7QmGJw/A+0ERiN9weoiw+WlgA==", "9234d927-88b0-4bf9-8e01-c3804f8fbab7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07e65fb8-2e67-4912-807b-db9c5578c15a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e665aa3c-bf07-4fa8-8c4c-e4086f163092", "AQAAAAIAAYagAAAAEDnMsuc2NBl+QWeWuV6DG6l/bVTWxqtAxjAcYO0Av9WdXsyOGiEHQDHERz3KHFQEpA==", "4549c812-3c65-426e-8638-9171b05879ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52402a2-4558-4ec2-ac2f-81d33d5e55fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "031d5630-a357-4629-a799-b05aad4eb989", "AQAAAAIAAYagAAAAELPP4Q82ySR3L/YQQKtyGmOPE3rAu+2o1jyQn2iC3suARlH8w6FOViSFbUJal2X9TA==", "464a9bb8-2ded-45e3-a4e1-f908b9f7f8b0" });
        }
    }
}
