using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MS4App.Data.Migrations
{
    public partial class AddCnItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CnItems",
                columns: table => new
                {
                    CnItemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    A = table.Column<int>(type: "int", nullable: false),
                    AArea = table.Column<float>(type: "real", nullable: false),
                    B = table.Column<int>(type: "int", nullable: false),
                    BArea = table.Column<float>(type: "real", nullable: false),
                    C = table.Column<int>(type: "int", nullable: false),
                    CArea = table.Column<float>(type: "real", nullable: false),
                    CnItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D = table.Column<int>(type: "int", nullable: false),
                    DArea = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CnItems", x => x.CnItemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CnItems");
        }
    }
}
