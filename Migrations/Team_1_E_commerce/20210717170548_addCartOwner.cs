using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_1_E_commerce.Migrations.Team_1_E_commerce
{
    public partial class addCartOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CartOwner",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartOwner",
                table: "Cart");
        }
    }
}
