using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPropImgUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Book");
        }
    }
}
