using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace HubService.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FacilityName = table.Column<string>(type: "longtext", nullable: false),
                    FacilityType = table.Column<string>(type: "longtext", nullable: false),
                    MultiFacility = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EHRVendorName = table.Column<string>(type: "longtext", nullable: false),
                    EHRDataFormat = table.Column<string>(type: "longtext", nullable: false),
                    EHRDataFormatVersion = table.Column<string>(type: "longtext", nullable: false),
                    EMPI = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DemographicsEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LabsEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedsEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    VitalsEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AllergiesEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facility");
        }
    }
}
