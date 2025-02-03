using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet6_NexaWorks.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModeleDonnees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_ProductVersions_ProductVersionId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_ProductVersions_ProductVersionId1",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Products_ProductId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Products_ProductId1",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Dates");

            migrationBuilder.DropTable(
                name: "OperatingSystemVersions");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ProductId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ProductId1",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ProductVersionId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ProductVersionId1",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ProductVersionId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ProductVersionId1",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "Resolution",
                table: "Tickets",
                newName: "Response");

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosingDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OpeningDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ProductVersionId",
                table: "TicketOperatingSystems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TicketOperatingSystems_ProductVersionId",
                table: "TicketOperatingSystems",
                column: "ProductVersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketOperatingSystems_ProductVersions_ProductVersionId",
                table: "TicketOperatingSystems",
                column: "ProductVersionId",
                principalTable: "ProductVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketOperatingSystems_ProductVersions_ProductVersionId",
                table: "TicketOperatingSystems");

            migrationBuilder.DropIndex(
                name: "IX_TicketOperatingSystems_ProductVersionId",
                table: "TicketOperatingSystems");

            migrationBuilder.DropColumn(
                name: "ClosingDate",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "OpeningDate",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ProductVersionId",
                table: "TicketOperatingSystems");

            migrationBuilder.RenameColumn(
                name: "Response",
                table: "Tickets",
                newName: "Resolution");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductVersionId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductVersionId1",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Dates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dates_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperatingSystemVersions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppOperatingSystemId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystemVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperatingSystemVersions_AppOperatingSystems_AppOperatingSystemId",
                        column: x => x.AppOperatingSystemId,
                        principalTable: "AppOperatingSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProductId",
                table: "Tickets",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProductId1",
                table: "Tickets",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProductVersionId",
                table: "Tickets",
                column: "ProductVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ProductVersionId1",
                table: "Tickets",
                column: "ProductVersionId1");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_TicketId",
                table: "Dates",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingSystemVersions_AppOperatingSystemId",
                table: "OperatingSystemVersions",
                column: "AppOperatingSystemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_ProductVersions_ProductVersionId",
                table: "Tickets",
                column: "ProductVersionId",
                principalTable: "ProductVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_ProductVersions_ProductVersionId1",
                table: "Tickets",
                column: "ProductVersionId1",
                principalTable: "ProductVersions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Products_ProductId",
                table: "Tickets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Products_ProductId1",
                table: "Tickets",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
