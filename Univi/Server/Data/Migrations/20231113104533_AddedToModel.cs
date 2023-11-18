using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univi.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedToModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reports_BuildingId",
                table: "Reports",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_KindofReportID",
                table: "Reports",
                column: "KindofReportID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Buidlings_BuildingId",
                table: "Reports",
                column: "BuildingId",
                principalTable: "Buidlings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_KindOfReports_KindofReportID",
                table: "Reports",
                column: "KindofReportID",
                principalTable: "KindOfReports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Buidlings_BuildingId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_KindOfReports_KindofReportID",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_BuildingId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_KindofReportID",
                table: "Reports");
        }
    }
}
