using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealEstateWebSite.Data.Migrations
{
    public partial class _1403Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AgencyId",
                table: "Estaties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrokerId",
                table: "Estaties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AgencyId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Agency",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EndWorkTime = table.Column<double>(nullable: false),
                    Fax = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StartWorkTime = table.Column<double>(nullable: false),
                    TelNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgencyEstate",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AgencyId = table.Column<string>(nullable: true),
                    EstateId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgencyEstate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgencyEstate_Agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AgencyEstate_Estaties_EstateId",
                        column: x => x.EstateId,
                        principalTable: "Estaties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estaties_AgencyId",
                table: "Estaties",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Estaties_BrokerId",
                table: "Estaties",
                column: "BrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AgencyId",
                table: "AspNetUsers",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AgencyEstate_AgencyId",
                table: "AgencyEstate",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_AgencyEstate_EstateId",
                table: "AgencyEstate",
                column: "EstateId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Agency_AgencyId",
                table: "AspNetUsers",
                column: "AgencyId",
                principalTable: "Agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estaties_Agency_AgencyId",
                table: "Estaties",
                column: "AgencyId",
                principalTable: "Agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estaties_AspNetUsers_BrokerId",
                table: "Estaties",
                column: "BrokerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Agency_AgencyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Estaties_Agency_AgencyId",
                table: "Estaties");

            migrationBuilder.DropForeignKey(
                name: "FK_Estaties_AspNetUsers_BrokerId",
                table: "Estaties");

            migrationBuilder.DropTable(
                name: "AgencyEstate");

            migrationBuilder.DropTable(
                name: "Agency");

            migrationBuilder.DropIndex(
                name: "IX_Estaties_AgencyId",
                table: "Estaties");

            migrationBuilder.DropIndex(
                name: "IX_Estaties_BrokerId",
                table: "Estaties");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AgencyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AgencyId",
                table: "Estaties");

            migrationBuilder.DropColumn(
                name: "BrokerId",
                table: "Estaties");

            migrationBuilder.DropColumn(
                name: "AgencyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
