using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrintersApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Printers");

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeDeTonner",
                table: "Tonners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SelbValue",
                table: "Tonners",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "SelbValue",
                table: "Selbs",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "SelbValue",
                table: "Printers",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantidadeDeTonner",
                table: "Tonners");

            migrationBuilder.DropColumn(
                name: "SelbValue",
                table: "Tonners");

            migrationBuilder.DropColumn(
                name: "SelbValue",
                table: "Selbs");

            migrationBuilder.DropColumn(
                name: "SelbValue",
                table: "Printers");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Printers",
                type: "longtext",
                nullable: true);
        }
    }
}
