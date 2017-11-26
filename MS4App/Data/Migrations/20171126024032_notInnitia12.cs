using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MS4App.Data.Migrations
{
    public partial class notInnitia12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CnItemsMain",
                table: "CnItemsMain");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "CnItemsMain");

            migrationBuilder.RenameTable(
                name: "CnItemsMain",
                newName: "CnItemsSelection1");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CnItemsSelection1",
                newName: "S1Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CnItemsSelection1",
                table: "CnItemsSelection1",
                column: "S1Id");

            migrationBuilder.CreateTable(
                name: "CnItemsMain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    A = table.Column<int>(nullable: false),
                    AArea = table.Column<float>(nullable: false),
                    B = table.Column<int>(nullable: false),
                    BArea = table.Column<float>(nullable: false),
                    C = table.Column<int>(nullable: false),
                    CArea = table.Column<float>(nullable: false),
                    CnItemDescription = table.Column<string>(nullable: false),
                    CnItemId = table.Column<string>(nullable: false),
                    D = table.Column<int>(nullable: false),
                    DArea = table.Column<float>(nullable: false),
                    IsChecked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CnItemsMain", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CnItemsMain");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CnItemsSelection1",
                table: "CnItemsSelection1");

            migrationBuilder.RenameTable(
                name: "CnItemsSelection1",
                newName: "CnItemsMain");

            migrationBuilder.RenameColumn(
                name: "S1Id",
                table: "CnItemsMain",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "CnItemsMain",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CnItemsMain",
                table: "CnItemsMain",
                column: "Id");
        }
    }
}
