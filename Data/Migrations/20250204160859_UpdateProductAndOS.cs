using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet6_NexaWorks.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductAndOS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketOperatingSystems_AppOperatingSystems_AppOperatingSystemId",
                table: "TicketOperatingSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketOperatingSystems_ProductVersions_ProductVersionId",
                table: "TicketOperatingSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketOperatingSystems_Tickets_TicketId",
                table: "TicketOperatingSystems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketOperatingSystems",
                table: "TicketOperatingSystems");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductVersions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AppOperatingSystems");

            migrationBuilder.RenameTable(
                name: "TicketOperatingSystems",
                newName: "TicketProductOperatingSystems");

            migrationBuilder.RenameIndex(
                name: "IX_TicketOperatingSystems_ProductVersionId",
                table: "TicketProductOperatingSystems",
                newName: "IX_TicketProductOperatingSystems_ProductVersionId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketOperatingSystems_AppOperatingSystemId",
                table: "TicketProductOperatingSystems",
                newName: "IX_TicketProductOperatingSystems_AppOperatingSystemId");

            migrationBuilder.AddColumn<float>(
                name: "Version",
                table: "ProductVersions",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketProductOperatingSystems",
                table: "TicketProductOperatingSystems",
                columns: new[] { "TicketId", "AppOperatingSystemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TicketProductOperatingSystems_AppOperatingSystems_AppOperatingSystemId",
                table: "TicketProductOperatingSystems",
                column: "AppOperatingSystemId",
                principalTable: "AppOperatingSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketProductOperatingSystems_ProductVersions_ProductVersionId",
                table: "TicketProductOperatingSystems",
                column: "ProductVersionId",
                principalTable: "ProductVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketProductOperatingSystems_Tickets_TicketId",
                table: "TicketProductOperatingSystems",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketProductOperatingSystems_AppOperatingSystems_AppOperatingSystemId",
                table: "TicketProductOperatingSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketProductOperatingSystems_ProductVersions_ProductVersionId",
                table: "TicketProductOperatingSystems");

            migrationBuilder.DropForeignKey(
                name: "FK_TicketProductOperatingSystems_Tickets_TicketId",
                table: "TicketProductOperatingSystems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketProductOperatingSystems",
                table: "TicketProductOperatingSystems");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "ProductVersions");

            migrationBuilder.RenameTable(
                name: "TicketProductOperatingSystems",
                newName: "TicketOperatingSystems");

            migrationBuilder.RenameIndex(
                name: "IX_TicketProductOperatingSystems_ProductVersionId",
                table: "TicketOperatingSystems",
                newName: "IX_TicketOperatingSystems_ProductVersionId");

            migrationBuilder.RenameIndex(
                name: "IX_TicketProductOperatingSystems_AppOperatingSystemId",
                table: "TicketOperatingSystems",
                newName: "IX_TicketOperatingSystems_AppOperatingSystemId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductVersions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AppOperatingSystems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketOperatingSystems",
                table: "TicketOperatingSystems",
                columns: new[] { "TicketId", "AppOperatingSystemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TicketOperatingSystems_AppOperatingSystems_AppOperatingSystemId",
                table: "TicketOperatingSystems",
                column: "AppOperatingSystemId",
                principalTable: "AppOperatingSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketOperatingSystems_ProductVersions_ProductVersionId",
                table: "TicketOperatingSystems",
                column: "ProductVersionId",
                principalTable: "ProductVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TicketOperatingSystems_Tickets_TicketId",
                table: "TicketOperatingSystems",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
