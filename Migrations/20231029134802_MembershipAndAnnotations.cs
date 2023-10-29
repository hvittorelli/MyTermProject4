using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTermProject.Migrations
{
    public partial class MembershipAndAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Memberships",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(name: "First Name", type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(name: "Last Name", type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zipcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memberships", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "ID", "Address", "City", "ConfirmPassword", "Country", "Email", "First Name", "Last Name", "Password", "Zipcode", "State", "Username" },
                values: new object[] { 1, "", "", "", "", "johnR@gmail.com", "John", "Robinson", "multi!Master21", "", "", "JoRobinson" });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "ID", "Address", "City", "ConfirmPassword", "Country", "Email", "First Name", "Last Name", "Password", "Zipcode", "State", "Username" },
                values: new object[] { 2, "", "", "", "", "sallyS@gmail.com", "Sally", "Smith", "yellow&Spot46", "", "", "SaSmith" });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "ID", "Address", "City", "ConfirmPassword", "Country", "Email", "First Name", "Last Name", "Password", "Zipcode", "State", "Username" },
                values: new object[] { 3, "", "", "", "", "rogerJ@gmail.com", "Roger", "Johnson", "blue*Flip62", "", "", "RoJohnson" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Memberships");
        }
    }
}
