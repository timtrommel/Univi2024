using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univi.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class changedModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "malfunctionsId",
                table: "Malfunctions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StatusCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusCodes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Malfunctions_malfunctionsId",
                table: "Malfunctions",
                column: "malfunctionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Malfunctions_Malfunctions_malfunctionsId",
                table: "Malfunctions",
                column: "malfunctionsId",
                principalTable: "Malfunctions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Malfunctions_Malfunctions_malfunctionsId",
                table: "Malfunctions");

            migrationBuilder.DropTable(
                name: "StatusCodes");

            migrationBuilder.DropIndex(
                name: "IX_Malfunctions_malfunctionsId",
                table: "Malfunctions");

            migrationBuilder.DropColumn(
                name: "malfunctionsId",
                table: "Malfunctions");
        }
    }
}
