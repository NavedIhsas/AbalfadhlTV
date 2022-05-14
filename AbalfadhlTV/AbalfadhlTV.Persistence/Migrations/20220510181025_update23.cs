using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbalfadhlTV.Persistence.Migrations
{
    public partial class update23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Child",
                table: "Beqas",
                newName: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Beqas",
                newName: "Child");
        }
    }
}
