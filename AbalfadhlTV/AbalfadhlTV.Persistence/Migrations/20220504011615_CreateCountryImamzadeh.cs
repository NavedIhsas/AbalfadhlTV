using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbalfadhlTV.Persistence.Migrations
{
    public partial class CreateCountryImamzadeh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.CreateTable(
                name: "CountriesImamzadehs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountriesImamzadehs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CitiesImamzadehs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    CountryImamzadehId = table.Column<long>(type: "bigint", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitiesImamzadehs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CitiesImamzadehs_CountriesImamzadehs_CountryImamzadehId",
                        column: x => x.CountryImamzadehId,
                        principalTable: "CountriesImamzadehs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemsImamzadehs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    CitiesImamzadehId = table.Column<long>(type: "bigint", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsImamzadehs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsImamzadehs_CitiesImamzadehs_CitiesImamzadehId",
                        column: x => x.CitiesImamzadehId,
                        principalTable: "CitiesImamzadehs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitiesImamzadehs_CountryImamzadehId",
                table: "CitiesImamzadehs",
                column: "CountryImamzadehId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsImamzadehs_CitiesImamzadehId",
                table: "ItemsImamzadehs",
                column: "CitiesImamzadehId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsImamzadehs");

            migrationBuilder.DropTable(
                name: "CitiesImamzadehs");

            migrationBuilder.DropTable(
                name: "CountriesImamzadehs");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });
        }
    }
}
