using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MS4App.Data.Migrations
{
    public partial class AddSlectionTables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CnItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CnItemsSelect1",
                table: "CnItemsSelect1");

            migrationBuilder.RenameTable(
                name: "CnItemsSelect1",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CnItems",
                table: "CnItems");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "CnItems");

            migrationBuilder.RenameTable(
                name: "CnItems",
                newName: "CnItemsSelect1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CnItemsSelect1",
                table: "CnItemsSelect1",
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
        }
    }
}
