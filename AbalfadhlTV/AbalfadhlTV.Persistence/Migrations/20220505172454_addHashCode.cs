using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbalfadhlTV.Persistence.Migrations
{
    public partial class addHashCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HashCode",
                table: "ItemsImamzadehs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HashCode",
                table: "CountriesImamzadehs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HashCode",
                table: "CitiesImamzadehs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HashCode",
                table: "ItemsImamzadehs");

            migrationBuilder.DropColumn(
                name: "HashCode",
                table: "CountriesImamzadehs");

            migrationBuilder.DropColumn(
                name: "HashCode",
                table: "CitiesImamzadehs");
        }
    }
}
