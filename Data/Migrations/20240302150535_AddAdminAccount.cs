using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

#nullable disable

namespace EpicBookstore.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminAccount : Migration
    {
        const string ADMIN_USER_GUID = "fee4ae1f-4db1-4ba3-ab25-a874cddb56d1";
        const string ADMIN_ROLE_GUID = "040bea7d-6e1b-4af4-8ced-1505ae2eda96";

        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            var passwordHash = hasher.HashPassword(null, "admin"); //TODO: HIDE PASSWORD!

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd", "LockoutEnabled", "AccessFailedCount" },
                values: new object[,]
                {
                    { $"{ADMIN_USER_GUID}", "admin@epicbookstore.com", "ADMIN@EPICBOOKSTORE.COM", "admin@epicbookstore.com", "ADMIN@EPICBOOKSTORE.COM", true, $"{passwordHash}", "", "", null, false, false, null, false, 0 }
                    // Add more rows as needed
                });


            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[,]
                {
                    { $"{ADMIN_ROLE_GUID}", "Admin", "ADMIN", "" }
                    // Add more rows as needed
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { $"{ADMIN_USER_GUID}", $"{ADMIN_ROLE_GUID}" }
                    // Add more rows as needed
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId = '{ADMIN_USER_GUID}' AND RoleId = '{ADMIN_ROLE_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetUsers WHERE Id = '{ADMIN_USER_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id = '{ADMIN_ROLE_GUID}'");
        }
    }
}
