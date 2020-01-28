using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryList.Migrations
{
    public partial class BoolMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInCart",
                table: "Ingredients",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInCart",
                table: "Ingredients");
        }
    }
}
