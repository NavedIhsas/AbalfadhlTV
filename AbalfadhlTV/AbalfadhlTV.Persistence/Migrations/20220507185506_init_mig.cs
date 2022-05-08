using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbalfadhlTV.Persistence.Migrations
{
    public partial class init_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beqas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    ParentBeqaId = table.Column<long>(type: "bigint", nullable: true),
                    HashCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beqas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beqas_Beqas_ParentBeqaId",
                        column: x => x.ParentBeqaId,
                        principalTable: "Beqas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BeqaTagTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeqaTagTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountriesImamzadehs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HashCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "BeqaContacts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeqaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeqaContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeqaContacts_Beqas_BeqaId",
                        column: x => x.BeqaId,
                        principalTable: "Beqas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeqaCoordinates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeqaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeqaCoordinates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeqaCoordinates_Beqas_BeqaId",
                        column: x => x.BeqaId,
                        principalTable: "Beqas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsZerih = table.Column<bool>(type: "bit", nullable: false),
                    BeqaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cameras_Beqas_BeqaId",
                        column: x => x.BeqaId,
                        principalTable: "Beqas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DigestTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeqaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medias_Beqas_BeqaId",
                        column: x => x.BeqaId,
                        principalTable: "Beqas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonBeqas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Father = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mather = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeathDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeqaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonBeqas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonBeqas_Beqas_BeqaId",
                        column: x => x.BeqaId,
                        principalTable: "Beqas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeqaBeqaTagType",
                columns: table => new
                {
                    BeqaTagTypesId = table.Column<long>(type: "bigint", nullable: false),
                    BeqasId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeqaBeqaTagType", x => new { x.BeqaTagTypesId, x.BeqasId });
                    table.ForeignKey(
                        name: "FK_BeqaBeqaTagType_Beqas_BeqasId",
                        column: x => x.BeqasId,
                        principalTable: "Beqas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BeqaBeqaTagType_BeqaTagTypes_BeqaTagTypesId",
                        column: x => x.BeqaTagTypesId,
                        principalTable: "BeqaTagTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    HashCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "MediaFormats",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormatType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resolution = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaFormats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaFormats_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    HashCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "IX_BeqaBeqaTagType_BeqasId",
                table: "BeqaBeqaTagType",
                column: "BeqasId");

            migrationBuilder.CreateIndex(
                name: "IX_BeqaContacts_BeqaId",
                table: "BeqaContacts",
                column: "BeqaId");

            migrationBuilder.CreateIndex(
                name: "IX_BeqaCoordinates_BeqaId",
                table: "BeqaCoordinates",
                column: "BeqaId");

            migrationBuilder.CreateIndex(
                name: "IX_Beqas_ParentBeqaId",
                table: "Beqas",
                column: "ParentBeqaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cameras_BeqaId",
                table: "Cameras",
                column: "BeqaId");

            migrationBuilder.CreateIndex(
                name: "IX_CitiesImamzadehs_CountryImamzadehId",
                table: "CitiesImamzadehs",
                column: "CountryImamzadehId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsImamzadehs_CitiesImamzadehId",
                table: "ItemsImamzadehs",
                column: "CitiesImamzadehId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaFormats_MediaId",
                table: "MediaFormats",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medias_BeqaId",
                table: "Medias",
                column: "BeqaId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonBeqas_BeqaId",
                table: "PersonBeqas",
                column: "BeqaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeqaBeqaTagType");

            migrationBuilder.DropTable(
                name: "BeqaContacts");

            migrationBuilder.DropTable(
                name: "BeqaCoordinates");

            migrationBuilder.DropTable(
                name: "Cameras");

            migrationBuilder.DropTable(
                name: "ItemsImamzadehs");

            migrationBuilder.DropTable(
                name: "MediaFormats");

            migrationBuilder.DropTable(
                name: "PersonBeqas");

            migrationBuilder.DropTable(
                name: "BeqaTagTypes");

            migrationBuilder.DropTable(
                name: "CitiesImamzadehs");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "CountriesImamzadehs");

            migrationBuilder.DropTable(
                name: "Beqas");
        }
    }
}
