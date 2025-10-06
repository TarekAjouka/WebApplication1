using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations.ApplicationIdentity
{
    /// <inheritdoc />
    public partial class SeedAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a1b2c3d4-e5f6-7890-abcd-1234567890ab", 0, "18355922-2447-4e45-95e1-aafdb5a44ffd", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEPwzvXow6civY/r+WnS/ctnh0VtGmBg9MFUPf9EQfvrcNQZog8S1n7LKMTQINrNShA==", null, false, "a0d6d444-9b77-46b8-823f-ad41981dd278", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "21ba7501-d5b1-4011-8e3b-9f6aeb6c8fc2", "a1b2c3d4-e5f6-7890-abcd-1234567890ab" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "21ba7501-d5b1-4011-8e3b-9f6aeb6c8fc2", "a1b2c3d4-e5f6-7890-abcd-1234567890ab" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-e5f6-7890-abcd-1234567890ab");
        }
    }
}
