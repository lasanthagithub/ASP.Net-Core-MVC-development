using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MS4App.Data.Migrations
{
    public partial class add_other_DBS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CnItemsSelection2",
                columns: table => new
                {
                    S2Id = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_CnItemsSelection2", x => x.S2Id);
                });

            migrationBuilder.CreateTable(
                name: "CnItemsSelection3",
                columns: table => new
                {
                    S3Id = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_CnItemsSelection3", x => x.S3Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CnItemsSelection2");

            migrationBuilder.DropTable(
                name: "CnItemsSelection3");
        }
    }
}
