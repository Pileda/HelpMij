using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeerhallEF.Migrations
{
    public partial class CreateRelationBrewerBeers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrewerId",
                table: "Beer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Beer_BrewerId",
                table: "Beer",
                column: "BrewerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beer_Brewer_BrewerId",
                table: "Beer",
                column: "BrewerId",
                principalTable: "Brewer",
                principalColumn: "BrewerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beer_Brewer_BrewerId",
                table: "Beer");

            migrationBuilder.DropIndex(
                name: "IX_Beer_BrewerId",
                table: "Beer");

            migrationBuilder.DropColumn(
                name: "BrewerId",
                table: "Beer");
        }
    }
}
