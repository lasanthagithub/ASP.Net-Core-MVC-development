using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MS4App.Data.Migrations
{
    public partial class AddSlectionTables33 : Migration
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
                newName: "CnItemsSelect3");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CnItemsSelect3",
                table: "CnItemsSelect3",
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
                name: "CnItemsSelect1",
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
                    table.PrimaryKey("PK_CnItemsSelect1", x => x.CnItemId);
                });

            migrationBuilder.CreateTable(
                name: "CnItemsSelect2",
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
                    table.PrimaryKey("PK_CnItemsSelect2", x => x.CnItemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CnItems");

            migrationBuilder.DropTable(
                name: "CnItemsSelect1");

            migrationBuilder.DropTable(
                name: "CnItemsSelect2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CnItemsSelect3",
                table: "CnItemsSelect3");

            migrationBuilder.RenameTable(
                name: "CnItemsSelect3",
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
