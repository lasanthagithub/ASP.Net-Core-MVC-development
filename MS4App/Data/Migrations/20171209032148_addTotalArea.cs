using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MS4App.Data.Migrations
{
    public partial class addTotalArea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Total",
                table: "CnItemsSelection3",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Total",
                table: "CnItemsSelection2",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Total",
                table: "CnItemsSelection1",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Total",
                table: "CnItemsMain",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "CnItemsSelection3");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "CnItemsSelection2");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "CnItemsSelection1");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "CnItemsMain");
        }
    }
}
