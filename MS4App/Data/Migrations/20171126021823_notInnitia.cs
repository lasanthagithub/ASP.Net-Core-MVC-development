using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MS4App.Data.Migrations
{
    public partial class notInnitia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CnItems",
                table: "CnItems");

            migrationBuilder.RenameTable(
                name: "CnItems",
                newName: "CnItemsMain");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CnItemsMain",
                table: "CnItemsMain");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "CnItemsMain");

            migrationBuilder.RenameTable(
                name: "CnItemsMain",
                newName: "CnItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CnItems",
                table: "CnItems",
                column: "Id");
        }
    }
}
