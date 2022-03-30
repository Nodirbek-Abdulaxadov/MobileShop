using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MobileShop.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Additionally",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatteryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatteryCapacity = table.Column<double>(type: "float", nullable: false),
                    ChargerType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Additionally", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Connection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StandardsSupport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Interfaces = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainCharacters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OSVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfFrame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDual = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasFingerPrintScanner = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SimCardType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCharacters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemoryAndProcessor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfCores = table.Column<int>(type: "int", nullable: false),
                    VideoProcessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ROM = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemoryAndProcessor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MultimediaFeatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberOfCameras = table.Column<int>(type: "int", nullable: false),
                    Cameras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrontCamera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AudioSupport = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultimediaFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScreenCharacters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScreenType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagonal = table.Column<double>(type: "float", nullable: false),
                    ImageSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AspectRatio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScreenHZ = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenCharacters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MainCharactersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScreenCharactersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MultimediaFeaturesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConnectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemoryAndProcessorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdditionallyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Additionally_AdditionallyId",
                        column: x => x.AdditionallyId,
                        principalTable: "Additionally",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Connection_ConnectionId",
                        column: x => x.ConnectionId,
                        principalTable: "Connection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MainCharacters_MainCharactersId",
                        column: x => x.MainCharactersId,
                        principalTable: "MainCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MemoryAndProcessor_MemoryAndProcessorId",
                        column: x => x.MemoryAndProcessorId,
                        principalTable: "MemoryAndProcessor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MultimediaFeatures_MultimediaFeaturesId",
                        column: x => x.MultimediaFeaturesId,
                        principalTable: "MultimediaFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ScreenCharacters_ScreenCharactersId",
                        column: x => x.ScreenCharactersId,
                        principalTable: "ScreenCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_AdditionallyId",
                table: "Products",
                column: "AdditionallyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ConnectionId",
                table: "Products",
                column: "ConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MainCharactersId",
                table: "Products",
                column: "MainCharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MemoryAndProcessorId",
                table: "Products",
                column: "MemoryAndProcessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MultimediaFeaturesId",
                table: "Products",
                column: "MultimediaFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ScreenCharactersId",
                table: "Products",
                column: "ScreenCharactersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Additionally");

            migrationBuilder.DropTable(
                name: "Connection");

            migrationBuilder.DropTable(
                name: "MainCharacters");

            migrationBuilder.DropTable(
                name: "MemoryAndProcessor");

            migrationBuilder.DropTable(
                name: "MultimediaFeatures");

            migrationBuilder.DropTable(
                name: "ScreenCharacters");
        }
    }
}
