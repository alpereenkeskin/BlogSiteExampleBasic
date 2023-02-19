using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSiteExample.DataAccess.Migrations
{
    public partial class addingmessa2_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SenderRecieverWriterId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderUserWriterId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Message2s",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender = table.Column<int>(type: "int", nullable: false),
                    Reciever = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message2s", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Message2s_Writers_Reciever",
                        column: x => x.Reciever,
                        principalTable: "Writers",
                        principalColumn: "WriterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Message2s_Writers_Sender",
                        column: x => x.Sender,
                        principalTable: "Writers",
                        principalColumn: "WriterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderRecieverWriterId",
                table: "Messages",
                column: "SenderRecieverWriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderUserWriterId",
                table: "Messages",
                column: "SenderUserWriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_Reciever",
                table: "Message2s",
                column: "Reciever");

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_Sender",
                table: "Message2s",
                column: "Sender");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Writers_SenderRecieverWriterId",
                table: "Messages",
                column: "SenderRecieverWriterId",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Writers_SenderUserWriterId",
                table: "Messages",
                column: "SenderUserWriterId",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_SenderRecieverWriterId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_SenderUserWriterId",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "Message2s");

            migrationBuilder.DropIndex(
                name: "IX_Messages_SenderRecieverWriterId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_SenderUserWriterId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderRecieverWriterId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderUserWriterId",
                table: "Messages");
        }
    }
}
