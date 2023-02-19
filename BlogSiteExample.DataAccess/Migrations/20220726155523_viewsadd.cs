using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSiteExample.DataAccess.Migrations
{
    public partial class viewsadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "Blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Views",
                table: "Blogs");
        }
    }
}
