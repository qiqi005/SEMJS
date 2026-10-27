using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMJS.Migrations
{
    /// <inheritdoc />
    public partial class AddCertificateAttachments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AttachmentName",
                table: "ProfileItems",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StoredFileName",
                table: "ProfileItems",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentName",
                table: "ProfileItems");

            migrationBuilder.DropColumn(
                name: "StoredFileName",
                table: "ProfileItems");
        }
    }
}
