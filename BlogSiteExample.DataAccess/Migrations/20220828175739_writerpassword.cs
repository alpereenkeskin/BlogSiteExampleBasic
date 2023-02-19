using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSiteExample.DataAccess.Migrations
{
    public partial class writerpassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WriterPassword",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WriterPassword",
                table: "Writers");
        }
    }
}
