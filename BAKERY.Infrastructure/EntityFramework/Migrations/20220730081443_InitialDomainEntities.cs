using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BAKERY.Infrastructure.EntityFramework.Migrations
{
    public partial class InitialDomainEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    BakingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    HoursCountForSale = table.Column<int>(type: "INTEGER", nullable: false),
                    SaleDeadline = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BeginPrice = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buns", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buns");
        }
    }
}
