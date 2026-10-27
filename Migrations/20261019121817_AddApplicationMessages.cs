using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEMJS.Migrations
{
    public partial class AddApplicationMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationMessage",
                columns: table => new
                {
                    ApplicationMessageId = table.Column<int>(
                        type: "int",
                        nullable: false)
                        .Annotation(
                            "MySql:ValueGenerationStrategy",
                            MySqlValueGenerationStrategy.IdentityColumn),

                    ApplicationId = table.Column<int>(
                        type: "int",
                        nullable: false),

                    SenderUserId = table.Column<int>(
                        type: "int",
                        nullable: false),

                    SenderRole = table.Column<string>(
                        type: "varchar(20)",
                        maxLength: 20,
                        nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    Text = table.Column<string>(
                        type: "varchar(3000)",
                        maxLength: 3000,
                        nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    SentAtUtc = table.Column<DateTime>(
                        type: "datetime(6)",
                        nullable: false),

                    AttachmentName = table.Column<string>(
                        type: "varchar(255)",
                        maxLength: 255,
                        nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    StoredFileName = table.Column<string>(
                        type: "varchar(100)",
                        maxLength: 100,
                        nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey(
                        "PK_ApplicationMessage",
                        x => x.ApplicationMessageId);

                    table.ForeignKey(
                        name: "FK_ApplicationMessage_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationMessage_ApplicationId",
                table: "ApplicationMessage",
                column: "ApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationMessage");
        }
    }
}