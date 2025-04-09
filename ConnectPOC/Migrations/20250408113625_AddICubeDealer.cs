using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectPOC.Migrations
{
    /// <inheritdoc />
    public partial class AddICubeDealer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ICubeDealers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DelarCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Landmark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CappingCount = table.Column<int>(type: "int", nullable: false),
                    DistanceLimit = table.Column<int>(type: "int", nullable: false),
                    IsHTRAvailable = table.Column<bool>(type: "bit", nullable: false),
                    DealerStartDate = table.Column<int>(type: "int", nullable: false),
                    HTRStartDate = table.Column<int>(type: "int", nullable: false),
                    WeeklyOffDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDTRAvailable = table.Column<bool>(type: "bit", nullable: false),
                    DealerBranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMSDealerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleSeriesId = table.Column<long>(type: "bigint", nullable: true),
                    PinCode = table.Column<int>(type: "int", nullable: true),
                    OldDealerCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ICubeDealers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ICubeDealers");
        }
    }
}
