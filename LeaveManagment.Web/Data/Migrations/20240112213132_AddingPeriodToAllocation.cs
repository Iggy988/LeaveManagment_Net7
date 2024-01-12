using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07e65fb8-2e67-4912-807b-db9c5578c15a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9238e0d6-3045-48af-bc99-3187054f2edd", "AQAAAAIAAYagAAAAEIN38klMS48sG7o/AWL2PdKa9cC9qSn6HSvWqHXZf1tlXT6N0Z93DPFck8d4ogRMhg==", "3f867227-1352-4f4c-a43f-30bd6c4334b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52402a2-4558-4ec2-ac2f-81d33d5e55fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9379ba94-16c4-4340-a531-96ce2e19bd30", "AQAAAAIAAYagAAAAEEaI8FIbiMee3bTiC4gZYPPhQg44VY3shcomYxSE94n9kmfeXhoz1KPmtlzslknLAA==", "83a2e39e-3d84-4578-a565-116e21d82fb9" });
        }
    }
}
