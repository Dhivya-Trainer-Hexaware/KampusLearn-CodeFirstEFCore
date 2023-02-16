using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KampusLearn_CodeFirstEFCore.Migrations
{
    public partial class TryingtodeletetheBatchTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batches");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    BatchNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BatchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoOfParticipants = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.BatchNo);
                });
        }
    }
}
