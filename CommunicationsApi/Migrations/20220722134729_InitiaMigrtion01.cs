using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommunicationsApi.Migrations
{
    public partial class InitiaMigrtion01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessageModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromWho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToWho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDeliveredStatus = table.Column<bool>(type: "bit", nullable: false),
                    MessageSentStatus = table.Column<bool>(type: "bit", nullable: false),
                    MessageRecievedStatus = table.Column<bool>(type: "bit", nullable: false),
                    MessageReadStatus = table.Column<bool>(type: "bit", nullable: false),
                    MessageSavedStatus = table.Column<bool>(type: "bit", nullable: false),
                    MessageDeletedStatus = table.Column<bool>(type: "bit", nullable: false),
                    MessageStatusDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageModel");
        }
    }
}
