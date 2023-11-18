using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univi.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedToModel231 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Buidlings_BuildingId",
                table: "Reports");

            migrationBuilder.RenameColumn(
                name: "BuildingId",
                table: "Reports",
                newName: "BuildingID");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_BuildingId",
                table: "Reports",
                newName: "IX_Reports_BuildingID");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingID",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Buidlings_BuildingID",
                table: "Reports",
                column: "BuildingID",
                principalTable: "Buidlings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Buidlings_BuildingID",
                table: "Reports");

            migrationBuilder.RenameColumn(
                name: "BuildingID",
                table: "Reports",
                newName: "BuildingId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_BuildingID",
                table: "Reports",
                newName: "IX_Reports_BuildingId");

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
    }
}
