using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univi.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedToModel12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Buidlings_BuildingId",
                table: "Reports");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingId",
                table: "Reports",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Buidlings_BuildingId",
                table: "Reports",
                column: "BuildingId",
                principalTable: "Buidlings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Buidlings_BuildingId",
                table: "Reports");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingId",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Buidlings_BuildingId",
                table: "Reports",
                column: "BuildingId",
                principalTable: "Buidlings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
