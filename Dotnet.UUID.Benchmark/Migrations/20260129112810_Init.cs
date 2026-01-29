using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dotnet.UUID.Benchmark.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guidv4",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guidv4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guidv7",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guidv7", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SimpleInt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleInt", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guidv4");

            migrationBuilder.DropTable(
                name: "Guidv7");

            migrationBuilder.DropTable(
                name: "SimpleInt");
        }
    }
}
