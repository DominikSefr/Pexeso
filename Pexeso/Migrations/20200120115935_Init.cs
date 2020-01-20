using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pexeso.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imgs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    src = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imgs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    score = table.Column<int>(nullable: false),
                    temp1 = table.Column<int>(nullable: false),
                    temp2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id_pair = table.Column<int>(nullable: false),
                    PoleId = table.Column<int>(nullable: false),
                    Revealed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Pole_PoleId",
                        column: x => x.PoleId,
                        principalTable: "Pole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Imgs",
                columns: new[] { "Id", "src" },
                values: new object[,]
                {
                    { 1, "~/images/1.jpg" },
                    { 15, "~/images/7.jpg" },
                    { 14, "~/images/6.jpg" },
                    { 13, "~/images/5.jpg" },
                    { 12, "~/images/4.jpg" },
                    { 11, "~/images/3.jpg" },
                    { 10, "~/images/2.jpg" },
                    { 16, "~/images/8.jpg" },
                    { 9, "~/images/1.jpg" },
                    { 7, "~/images/7.jpg" },
                    { 6, "~/images/6.jpg" },
                    { 5, "~/images/5.jpg" },
                    { 4, "~/images/4.jpg" },
                    { 3, "~/images/3.jpg" },
                    { 2, "~/images/2.jpg" },
                    { 8, "~/images/8.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Pole",
                columns: new[] { "Id", "score", "temp1", "temp2" },
                values: new object[] { 1, 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Id_pair", "PoleId", "Revealed" },
                values: new object[,]
                {
                    { 1, 2, 1, false },
                    { 2, 1, 1, false },
                    { 3, 4, 1, false },
                    { 4, 3, 1, false },
                    { 5, 6, 1, false },
                    { 6, 5, 1, false },
                    { 7, 8, 1, false },
                    { 8, 7, 1, false },
                    { 9, 10, 1, false },
                    { 10, 9, 1, false },
                    { 11, 12, 1, false },
                    { 12, 11, 1, false },
                    { 13, 14, 1, false },
                    { 14, 13, 1, false },
                    { 15, 16, 1, false },
                    { 16, 15, 1, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PoleId",
                table: "Cards",
                column: "PoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Imgs");

            migrationBuilder.DropTable(
                name: "Pole");
        }
    }
}
