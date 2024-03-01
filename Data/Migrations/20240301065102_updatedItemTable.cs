using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EpicBookstore.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Item");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
