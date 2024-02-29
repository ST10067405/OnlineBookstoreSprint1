using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EpicBookstore.Data.Migrations
{
    /// <inheritdoc />
    public partial class editedItemModel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Item");
        }
    }
}
