using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Migrations
{
    public partial class Ruler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Territory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rulers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    publicAcceptance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    TerritoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rulers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rulers_Territory_TerritoryID",
                        column: x => x.TerritoryID,
                        principalTable: "Territory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rulers_TerritoryID",
                table: "Rulers",
                column: "TerritoryID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rulers");

            migrationBuilder.DropTable(
                name: "Territory");
        }
    }
}
