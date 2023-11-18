using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Univi.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedHandoverModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Handovers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KindofHandoverId = table.Column<int>(type: "int", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateHandover = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLastEdit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateArchived = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HandoverStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HandoverStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HandoverEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HandoverEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastEditById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatiëntNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherInformation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Handovers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Handovers");
        }
    }
}
