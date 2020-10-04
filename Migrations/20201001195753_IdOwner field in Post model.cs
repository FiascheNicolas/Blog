using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class IdOwnerfieldinPostmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdOwner",
                table: "Posts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdOwner",
                table: "Posts");
        }
    }
}
