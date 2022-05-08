using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbalfadhlTV.Persistence.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Beqas",
                newName: "Child");

            migrationBuilder.AddColumn<bool>(
                name: "IsZiaratOnline",
                table: "Cameras",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNeabati",
                table: "Beqas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Beqas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsZiaratOnline",
                table: "Cameras");

            migrationBuilder.DropColumn(
                name: "IsNeabati",
                table: "Beqas");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Beqas");

            migrationBuilder.RenameColumn(
                name: "Child",
                table: "Beqas",
                newName: "ParentId");
        }
    }
}
