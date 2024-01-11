using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "computer",
                columns: table => new
                {
                    ComputerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    Procesor = table.Column<string>(type: "TEXT", nullable: false),
                    Memory = table.Column<int>(type: "INTEGER", nullable: false),
                    Karta_Graficzna = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    Producent = table.Column<string>(type: "TEXT", nullable: false),
                    data_produkcji = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_computer", x => x.ComputerId);
                });

            migrationBuilder.InsertData(
                table: "computer",
                columns: new[] { "ComputerId", "data_produkcji", "Karta_Graficzna", "Memory", "Nazwa", "Priority", "Procesor", "Producent" },
                values: new object[] { 1, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brak", 8, "Domowy", 1, "Intel Core i5-12400F", "MSI" });

            migrationBuilder.InsertData(
                table: "computer",
                columns: new[] { "ComputerId", "data_produkcji", "Karta_Graficzna", "Memory", "Nazwa", "Priority", "Procesor", "Producent" },
                values: new object[] { 2, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSI GeForce RTX 4060 Gaming X 8GB", 32, "Gamingowy", 1, "INTEL Core i9-13900KF", "Asus" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "computer");
        }
    }
}
