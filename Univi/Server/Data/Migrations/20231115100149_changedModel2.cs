using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univi.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class changedModel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Malfunctions_Malfunctions_malfunctionsId",
                table: "Malfunctions");

            migrationBuilder.DropIndex(
                name: "IX_Malfunctions_malfunctionsId",
                table: "Malfunctions");

            migrationBuilder.DropColumn(
                name: "malfunctionsId",
                table: "Malfunctions");

            migrationBuilder.CreateIndex(
                name: "IX_Malfunctions_KindofMalfunctionId",
                table: "Malfunctions",
                column: "KindofMalfunctionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Malfunctions_KindofMalfunctions_KindofMalfunctionId",
                table: "Malfunctions",
                column: "KindofMalfunctionId",
                principalTable: "KindofMalfunctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Malfunctions_KindofMalfunctions_KindofMalfunctionId",
                table: "Malfunctions");

            migrationBuilder.DropIndex(
                name: "IX_Malfunctions_KindofMalfunctionId",
                table: "Malfunctions");

            migrationBuilder.AddColumn<int>(
                name: "malfunctionsId",
                table: "Malfunctions",
                type: "int",
                nullable: true);

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
    }
}
