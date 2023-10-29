using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTermProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    BookFormat = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 1, null, "Fantasy" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 2, null, "Self-Help" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Name" },
                values: new object[] { 3, null, "Fiction" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AuthorName", "BookFormat", "BookTitle", "GenreId" },
                values: new object[] { 1, "JK Rowling", 2, "Harry Potter and the Sorcerer's Stone", 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AuthorName", "BookFormat", "BookTitle", "GenreId" },
                values: new object[] { 2, "James Clear", 0, "Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones", 2 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AuthorName", "BookFormat", "BookTitle", "GenreId" },
                values: new object[] { 3, "Kristin Hannah", null, "Night Road", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
