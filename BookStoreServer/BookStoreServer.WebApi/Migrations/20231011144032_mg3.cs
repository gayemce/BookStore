using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreServer.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImageUrl", "CreateAt", "ISBN", "IsActive", "IsDeleted", "Price", "Quantity", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, "Author 1", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4813), "978-0321125217", true, false, 10m, 10, "", "Book 1" },
                    { 2, "Author 2", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4825), "978-0321125217", true, false, 10m, 10, "", "Book 2" },
                    { 3, "Author 3", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4827), "978-0321125217", true, false, 10m, 10, "", "Book 3" },
                    { 4, "Author 4", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4830), "978-0321125217", true, false, 10m, 10, "", "Book 4" },
                    { 5, "Author 5", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4832), "978-0321125217", true, false, 10m, 10, "", "Book 5" },
                    { 6, "Author 6", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4836), "978-0321125217", true, false, 10m, 10, "", "Book 6" },
                    { 7, "Author 7", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4838), "978-0321125217", true, false, 10m, 10, "", "Book 7" },
                    { 8, "Author 8", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4840), "978-0321125217", true, false, 10m, 10, "", "Book 8" },
                    { 9, "Author 9", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4842), "978-0321125217", true, false, 10m, 10, "", "Book 9" },
                    { 10, "Author 10", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4846), "978-0321125217", true, false, 10m, 10, "", "Book 10" },
                    { 11, "Author 11", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4848), "978-0321125217", true, false, 10m, 10, "", "Book 11" },
                    { 12, "Author 12", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4851), "978-0321125217", true, false, 10m, 10, "", "Book 12" },
                    { 13, "Author 13", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4853), "978-0321125217", true, false, 10m, 10, "", "Book 13" },
                    { 14, "Author 14", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4855), "978-0321125217", true, false, 10m, 10, "", "Book 14" },
                    { 15, "Author 15", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4857), "978-0321125217", true, false, 10m, 10, "", "Book 15" },
                    { 16, "Author 16", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4859), "978-0321125217", true, false, 10m, 10, "", "Book 16" },
                    { 17, "Author 17", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4862), "978-0321125217", true, false, 10m, 10, "", "Book 17" },
                    { 18, "Author 18", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4865), "978-0321125217", true, false, 10m, 10, "", "Book 18" },
                    { 19, "Author 19", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4868), "978-0321125217", true, false, 10m, 10, "", "Book 19" },
                    { 20, "Author 20", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4870), "978-0321125217", true, false, 10m, 10, "", "Book 20" },
                    { 21, "Author 21", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4872), "978-0321125217", true, false, 10m, 10, "", "Book 21" },
                    { 22, "Author 22", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4874), "978-0321125217", true, false, 10m, 10, "", "Book 22" },
                    { 23, "Author 23", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4877), "978-0321125217", true, false, 10m, 10, "", "Book 23" },
                    { 24, "Author 24", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4879), "978-0321125217", true, false, 10m, 10, "", "Book 24" },
                    { 25, "Author 25", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4881), "978-0321125217", true, false, 10m, 10, "", "Book 25" },
                    { 26, "Author 26", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4883), "978-0321125217", true, false, 10m, 10, "", "Book 26" },
                    { 27, "Author 27", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4886), "978-0321125217", true, false, 10m, 10, "", "Book 27" },
                    { 28, "Author 28", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4888), "978-0321125217", true, false, 10m, 10, "", "Book 28" },
                    { 29, "Author 29", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4890), "978-0321125217", true, false, 10m, 10, "", "Book 29" },
                    { 30, "Author 30", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4892), "978-0321125217", true, false, 10m, 10, "", "Book 30" },
                    { 31, "Author 31", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4895), "978-0321125217", true, false, 10m, 10, "", "Book 31" },
                    { 32, "Author 32", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4897), "978-0321125217", true, false, 10m, 10, "", "Book 32" },
                    { 33, "Author 33", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4899), "978-0321125217", true, false, 10m, 10, "", "Book 33" },
                    { 34, "Author 34", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4902), "978-0321125217", true, false, 10m, 10, "", "Book 34" },
                    { 35, "Author 35", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4905), "978-0321125217", true, false, 10m, 10, "", "Book 35" },
                    { 36, "Author 36", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4974), "978-0321125217", true, false, 10m, 10, "", "Book 36" },
                    { 37, "Author 37", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4977), "978-0321125217", true, false, 10m, 10, "", "Book 37" },
                    { 38, "Author 38", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4979), "978-0321125217", true, false, 10m, 10, "", "Book 38" },
                    { 39, "Author 39", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4981), "978-0321125217", true, false, 10m, 10, "", "Book 39" },
                    { 40, "Author 40", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4984), "978-0321125217", true, false, 10m, 10, "", "Book 40" },
                    { 41, "Author 41", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4986), "978-0321125217", true, false, 10m, 10, "", "Book 41" },
                    { 42, "Author 42", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4988), "978-0321125217", true, false, 10m, 10, "", "Book 42" },
                    { 43, "Author 43", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4990), "978-0321125217", true, false, 10m, 10, "", "Book 43" },
                    { 44, "Author 44", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4992), "978-0321125217", true, false, 10m, 10, "", "Book 44" },
                    { 45, "Author 45", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4995), "978-0321125217", true, false, 10m, 10, "", "Book 45" },
                    { 46, "Author 46", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4997), "978-0321125217", true, false, 10m, 10, "", "Book 46" },
                    { 47, "Author 47", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(4999), "978-0321125217", true, false, 10m, 10, "", "Book 47" },
                    { 48, "Author 48", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5001), "978-0321125217", true, false, 10m, 10, "", "Book 48" },
                    { 49, "Author 49", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5004), "978-0321125217", true, false, 10m, 10, "", "Book 49" },
                    { 50, "Author 50", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5006), "978-0321125217", true, false, 10m, 10, "", "Book 50" },
                    { 51, "Author 51", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5008), "978-0321125217", true, false, 10m, 10, "", "Book 51" },
                    { 52, "Author 52", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5010), "978-0321125217", true, false, 10m, 10, "", "Book 52" },
                    { 53, "Author 53", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5013), "978-0321125217", true, false, 10m, 10, "", "Book 53" },
                    { 54, "Author 54", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5015), "978-0321125217", true, false, 10m, 10, "", "Book 54" },
                    { 55, "Author 55", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5017), "978-0321125217", true, false, 10m, 10, "", "Book 55" },
                    { 56, "Author 56", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5019), "978-0321125217", true, false, 10m, 10, "", "Book 56" },
                    { 57, "Author 57", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5021), "978-0321125217", true, false, 10m, 10, "", "Book 57" },
                    { 58, "Author 58", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5024), "978-0321125217", true, false, 10m, 10, "", "Book 58" },
                    { 59, "Author 59", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5026), "978-0321125217", true, false, 10m, 10, "", "Book 59" },
                    { 60, "Author 60", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5028), "978-0321125217", true, false, 10m, 10, "", "Book 60" },
                    { 61, "Author 61", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5030), "978-0321125217", true, false, 10m, 10, "", "Book 61" },
                    { 62, "Author 62", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5032), "978-0321125217", true, false, 10m, 10, "", "Book 62" },
                    { 63, "Author 63", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5035), "978-0321125217", true, false, 10m, 10, "", "Book 63" },
                    { 64, "Author 64", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5037), "978-0321125217", true, false, 10m, 10, "", "Book 64" },
                    { 65, "Author 65", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5039), "978-0321125217", true, false, 10m, 10, "", "Book 65" },
                    { 66, "Author 66", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5043), "978-0321125217", true, false, 10m, 10, "", "Book 66" },
                    { 67, "Author 67", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5045), "978-0321125217", true, false, 10m, 10, "", "Book 67" },
                    { 68, "Author 68", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5047), "978-0321125217", true, false, 10m, 10, "", "Book 68" },
                    { 69, "Author 69", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5049), "978-0321125217", true, false, 10m, 10, "", "Book 69" },
                    { 70, "Author 70", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5052), "978-0321125217", true, false, 10m, 10, "", "Book 70" },
                    { 71, "Author 71", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5115), "978-0321125217", true, false, 10m, 10, "", "Book 71" },
                    { 72, "Author 72", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5117), "978-0321125217", true, false, 10m, 10, "", "Book 72" },
                    { 73, "Author 73", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5120), "978-0321125217", true, false, 10m, 10, "", "Book 73" },
                    { 74, "Author 74", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5122), "978-0321125217", true, false, 10m, 10, "", "Book 74" },
                    { 75, "Author 75", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5124), "978-0321125217", true, false, 10m, 10, "", "Book 75" },
                    { 76, "Author 76", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5126), "978-0321125217", true, false, 10m, 10, "", "Book 76" },
                    { 77, "Author 77", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5128), "978-0321125217", true, false, 10m, 10, "", "Book 77" },
                    { 78, "Author 78", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5130), "978-0321125217", true, false, 10m, 10, "", "Book 78" },
                    { 79, "Author 79", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5133), "978-0321125217", true, false, 10m, 10, "", "Book 79" },
                    { 80, "Author 80", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5135), "978-0321125217", true, false, 10m, 10, "", "Book 80" },
                    { 81, "Author 81", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5137), "978-0321125217", true, false, 10m, 10, "", "Book 81" },
                    { 82, "Author 82", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5140), "978-0321125217", true, false, 10m, 10, "", "Book 82" },
                    { 83, "Author 83", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5142), "978-0321125217", true, false, 10m, 10, "", "Book 83" },
                    { 84, "Author 84", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5144), "978-0321125217", true, false, 10m, 10, "", "Book 84" },
                    { 85, "Author 85", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5146), "978-0321125217", true, false, 10m, 10, "", "Book 85" },
                    { 86, "Author 86", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5149), "978-0321125217", true, false, 10m, 10, "", "Book 86" },
                    { 87, "Author 87", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5151), "978-0321125217", true, false, 10m, 10, "", "Book 87" },
                    { 88, "Author 88", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5153), "978-0321125217", true, false, 10m, 10, "", "Book 88" },
                    { 89, "Author 89", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5155), "978-0321125217", true, false, 10m, 10, "", "Book 89" },
                    { 90, "Author 90", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5157), "978-0321125217", true, false, 10m, 10, "", "Book 90" },
                    { 91, "Author 91", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5160), "978-0321125217", true, false, 10m, 10, "", "Book 91" },
                    { 92, "Author 92", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5162), "978-0321125217", true, false, 10m, 10, "", "Book 92" },
                    { 93, "Author 93", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5164), "978-0321125217", true, false, 10m, 10, "", "Book 93" },
                    { 94, "Author 94", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5166), "978-0321125217", true, false, 10m, 10, "", "Book 94" },
                    { 95, "Author 95", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5168), "978-0321125217", true, false, 10m, 10, "", "Book 95" },
                    { 96, "Author 96", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5171), "978-0321125217", true, false, 10m, 10, "", "Book 96" },
                    { 97, "Author 97", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5173), "978-0321125217", true, false, 10m, 10, "", "Book 97" },
                    { 98, "Author 98", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5175), "978-0321125217", true, false, 10m, 10, "", "Book 98" },
                    { 99, "Author 99", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5177), "978-0321125217", true, false, 10m, 10, "", "Book 99" },
                    { 100, "Author 100", "https://m.media-amazon.com/images/I/715dYvRM3lL._AC_UF1000,1000_QL80_.jpg", new DateTime(2023, 10, 11, 17, 40, 32, 443, DateTimeKind.Local).AddTicks(5180), "978-0321125217", true, false, 10m, 10, "", "Book 100" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsActive", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "Category1" },
                    { 2, true, false, "Category2" },
                    { 3, true, false, "Category3" },
                    { 4, true, false, "Category4" },
                    { 5, true, false, "Category5" },
                    { 6, true, false, "Category6" },
                    { 7, true, false, "Category7" },
                    { 8, true, false, "Category8" },
                    { 9, true, false, "Category9" },
                    { 10, true, false, "Category10" }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 10 },
                    { 3, 10 },
                    { 4, 7 },
                    { 5, 6 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 7 },
                    { 9, 5 },
                    { 10, 8 },
                    { 11, 3 },
                    { 12, 7 },
                    { 13, 2 },
                    { 14, 6 },
                    { 15, 1 },
                    { 16, 5 },
                    { 17, 4 },
                    { 18, 5 },
                    { 19, 2 },
                    { 20, 1 },
                    { 21, 10 },
                    { 22, 9 },
                    { 23, 1 },
                    { 24, 4 },
                    { 25, 7 },
                    { 26, 8 },
                    { 27, 10 },
                    { 28, 10 },
                    { 29, 2 },
                    { 30, 8 },
                    { 31, 7 },
                    { 32, 3 },
                    { 33, 9 },
                    { 34, 7 },
                    { 35, 3 },
                    { 36, 9 },
                    { 37, 6 },
                    { 38, 10 },
                    { 39, 9 },
                    { 40, 1 },
                    { 41, 5 },
                    { 42, 2 },
                    { 43, 8 },
                    { 44, 7 },
                    { 45, 8 },
                    { 46, 4 },
                    { 47, 7 },
                    { 48, 9 },
                    { 49, 10 },
                    { 50, 3 },
                    { 51, 9 },
                    { 52, 3 },
                    { 53, 5 },
                    { 54, 1 },
                    { 55, 1 },
                    { 56, 2 },
                    { 57, 7 },
                    { 58, 9 },
                    { 59, 2 },
                    { 60, 2 },
                    { 61, 10 },
                    { 62, 7 },
                    { 63, 10 },
                    { 64, 7 },
                    { 65, 7 },
                    { 66, 3 },
                    { 67, 6 },
                    { 68, 2 },
                    { 69, 10 },
                    { 70, 7 },
                    { 71, 8 },
                    { 72, 10 },
                    { 73, 5 },
                    { 74, 2 },
                    { 75, 9 },
                    { 76, 4 },
                    { 77, 8 },
                    { 78, 2 },
                    { 79, 6 },
                    { 80, 7 },
                    { 81, 9 },
                    { 82, 6 },
                    { 83, 8 },
                    { 84, 5 },
                    { 85, 7 },
                    { 86, 5 },
                    { 87, 3 },
                    { 88, 6 },
                    { 89, 9 },
                    { 90, 4 },
                    { 91, 10 },
                    { 92, 3 },
                    { 93, 7 },
                    { 94, 5 },
                    { 95, 1 },
                    { 96, 7 },
                    { 97, 1 },
                    { 98, 1 },
                    { 99, 9 },
                    { 100, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 22, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 25, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 26, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 27, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 28, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 30, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 31, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 32, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 33, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 35, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 36, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 37, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 38, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 39, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 41, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 42, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 43, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 44, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 45, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 46, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 47, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 48, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 49, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 50, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 51, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 52, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 53, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 54, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 56, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 57, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 58, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 59, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 60, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 61, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 62, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 63, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 64, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 65, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 66, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 67, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 68, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 69, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 70, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 71, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 72, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 73, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 74, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 75, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 76, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 77, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 79, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 80, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 81, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 82, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 83, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 84, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 85, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 86, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 87, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 88, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 89, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 90, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 91, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 92, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 93, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 94, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 95, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 96, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 97, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 98, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 99, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 100, 6 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Books");
        }
    }
}
