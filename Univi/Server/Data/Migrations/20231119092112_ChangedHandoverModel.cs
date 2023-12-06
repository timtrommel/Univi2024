using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univi.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangedHandoverModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HandoverStartTime",
                table: "Handovers",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "HandoverStartDate",
                table: "Handovers",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "HandoverEndTime",
                table: "Handovers",
                newName: "EndTime");

            migrationBuilder.RenameColumn(
                name: "HandoverEndDate",
                table: "Handovers",
                newName: "EndDate");

            migrationBuilder.AddColumn<bool>(
                name: "NoStartEnd",
                table: "Handovers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ReportNo",
                table: "Handovers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoStartEnd",
                table: "Handovers");

            migrationBuilder.DropColumn(
                name: "ReportNo",
                table: "Handovers");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Handovers",
                newName: "HandoverStartTime");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Handovers",
                newName: "HandoverStartDate");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Handovers",
                newName: "HandoverEndTime");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Handovers",
                newName: "HandoverEndDate");
        }
    }
}
