using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dunca_Raul_Adrian_IE_ID_Proiect.Migrations
{
    public partial class Noble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Noble",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    TerritoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noble", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Noble_Territory_TerritoryID",
                        column: x => x.TerritoryID,
                        principalTable: "Territory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Noble_TerritoryID",
                table: "Noble",
                column: "TerritoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Noble");
        }
    }
}
