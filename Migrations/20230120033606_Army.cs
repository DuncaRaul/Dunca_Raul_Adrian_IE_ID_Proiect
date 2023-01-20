using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Migrations
{
    public partial class Army : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArmyID",
                table: "Subject",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Army",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    NobleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Army", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Army_Noble_NobleID",
                        column: x => x.NobleID,
                        principalTable: "Noble",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ArmyID",
                table: "Subject",
                column: "ArmyID");

            migrationBuilder.CreateIndex(
                name: "IX_Army_NobleID",
                table: "Army",
                column: "NobleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Army_ArmyID",
                table: "Subject",
                column: "ArmyID",
                principalTable: "Army",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Army_ArmyID",
                table: "Subject");

            migrationBuilder.DropTable(
                name: "Army");

            migrationBuilder.DropIndex(
                name: "IX_Subject_ArmyID",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "ArmyID",
                table: "Subject");
        }
    }
}
