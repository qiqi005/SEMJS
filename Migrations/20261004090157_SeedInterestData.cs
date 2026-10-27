using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SEMJS.Migrations
{
    /// <inheritdoc />
    public partial class SeedInterestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "InterestId", "Description", "InterestName" },
                values: new object[,]
                {
                    { 1, "Interest in developing software applications and systems.", "Software Development" },
                    { 2, "Interest in creating and maintaining websites and web applications.", "Web Development" },
                    { 3, "Interest in developing applications for mobile devices.", "Mobile App Development" },
                    { 4, "Interest in artificial intelligence and intelligent computer systems.", "Artificial Intelligence" },
                    { 5, "Interest in machine learning and data-driven systems.", "Machine Learning" },
                    { 6, "Interest in analyzing data and discovering useful insights.", "Data Science" },
                    { 7, "Interest in database design, management and optimization.", "Database Management" },
                    { 8, "Interest in protecting systems, networks and data from security threats.", "Cybersecurity" },
                    { 9, "Interest in computer networks and network infrastructure.", "Networking" },
                    { 10, "Interest in cloud platforms, services and infrastructure.", "Cloud Computing" },
                    { 11, "Interest in designing user interfaces and user experiences.", "UI/UX Design" },
                    { 12, "Interest in designing and developing computer and mobile games.", "Game Development" },
                    { 13, "Interest in programming and solving problems through code.", "Programming" },
                    { 14, "Interest in information technology and computer systems.", "Information Technology" },
                    { 15, "Interest in analyzing and improving information systems.", "System Analysis" },
                    { 16, "Interest in planning and managing technology projects.", "Project Management" },
                    { 17, "Interest in analyzing business needs and system requirements.", "Business Analysis" },
                    { 18, "Interest in online marketing and digital communication.", "Digital Marketing" },
                    { 19, "Interest in starting and developing new businesses and ideas.", "Entrepreneurship" },
                    { 20, "Interest in new technologies and innovative solutions.", "Technology Innovation" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "InterestId",
                keyValue: 20);
        }
    }
}
