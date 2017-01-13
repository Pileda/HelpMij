using Microsoft.EntityFrameworkCore.Migrations;

namespace BeerhallEF.Migrations
{
    public partial class UpdateTableBrewers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Brewers",
                table: "Brewers");

            migrationBuilder.RenameTable(
                name: "Brewers",
                newName: "Brewer");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Brewer",
                newName: "BrewerName");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Brewer",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrewerName",
                table: "Brewer",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "Brewer",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brewer",
                table: "Brewer",
                column: "BrewerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Brewer",
                table: "Brewer");

            migrationBuilder.RenameTable(
                name: "Brewer",
                newName: "Brewers");

            migrationBuilder.RenameColumn(
                name: "BrewerName",
                table: "Brewers",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Brewers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brewers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ContactEmail",
                table: "Brewers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brewers",
                table: "Brewers",
                column: "BrewerId");
        }
    }
}
