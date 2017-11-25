using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MS4App.Data.Migrations
{
    public partial class newTables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CnItems",
                table: "CnItems");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "CnItems");

            migrationBuilder.RenameTable(
                name: "CnItems",
                newName: "CnItemsSelection3");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CnItemsSelection3",
                table: "CnItemsSelection3",
                column: "CnItemId");

            migrationBuilder.CreateTable(
                name: "CnItems",
                columns: table => new
                {
                    CnItemId = table.Column<string>(nullable: false),
                    A = table.Column<int>(nullable: false),
                    AArea = table.Column<float>(nullable: false),
                    B = table.Column<int>(nullable: false),
                    BArea = table.Column<float>(nullable: false),
                    C = table.Column<int>(nullable: false),
                    CArea = table.Column<float>(nullable: false),
                    CnItemDescription = table.Column<string>(nullable: false),
                    D = table.Column<int>(nullable: false),
                    DArea = table.Column<float>(nullable: false),
                    IsChecked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CnItems", x => x.CnItemId);
                });

            migrationBuilder.CreateTable(
                name: "CnItemsSelection1",
                columns: table => new
                {
                    CnItemId = table.Column<string>(nullable: false),
                    A = table.Column<int>(nullable: false),
                    AArea = table.Column<float>(nullable: false),
                    B = table.Column<int>(nullable: false),
                    BArea = table.Column<float>(nullable: false),
                    C = table.Column<int>(nullable: false),
                    CArea = table.Column<float>(nullable: false),
                    CnItemDescription = table.Column<string>(nullable: false),
                    D = table.Column<int>(nullable: false),
                    DArea = table.Column<float>(nullable: false),
                    IsChecked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CnItemsSelection1", x => x.CnItemId);
                });

            migrationBuilder.CreateTable(
                name: "CnItemsSelection2",
                columns: table => new
                {
                    CnItemId = table.Column<string>(nullable: false),
                    A = table.Column<int>(nullable: false),
                    AArea = table.Column<float>(nullable: false),
                    B = table.Column<int>(nullable: false),
                    BArea = table.Column<float>(nullable: false),
                    C = table.Column<int>(nullable: false),
                    CArea = table.Column<float>(nullable: false),
                    CnItemDescription = table.Column<string>(nullable: false),
                    D = table.Column<int>(nullable: false),
                    DArea = table.Column<float>(nullable: false),
                    IsChecked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CnItemsSelection2", x => x.CnItemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CnItems");

            migrationBuilder.DropTable(
                name: "CnItemsSelection1");

            migrationBuilder.DropTable(
                name: "CnItemsSelection2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CnItemsSelection3",
                table: "CnItemsSelection3");

            migrationBuilder.RenameTable(
                name: "CnItemsSelection3",
                newName: "CnItems");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "CnItems",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CnItems",
                table: "CnItems",
                column: "CnItemId");
        }
    }
}
