using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BandidGirlsAPI.Migrations
{
    /// <inheritdoc />
    public partial class INITDATABASE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MagicalGirls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origun_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contract_Date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicalGirls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Historials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviussState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChangeDade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MagicalGirlId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historials_MagicalGirls_MagicalGirlId",
                        column: x => x.MagicalGirlId,
                        principalTable: "MagicalGirls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Historials_MagicalGirlId",
                table: "Historials",
                column: "MagicalGirlId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historials");

            migrationBuilder.DropTable(
                name: "MagicalGirls");
        }
    }
}
