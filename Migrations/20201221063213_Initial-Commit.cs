using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlazorUser",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Phone_Number = table.Column<string>(type: "TEXT", nullable: true),
                    Domain = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlazorUser", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "BlazorUser",
                columns: new[] { "Name", "Domain", "Email", "Notes", "Phone_Number" },
                values: new object[] { "NewUser", "gmail.com", "NewUser@gmail.com", " first blazor app", "0711111111" });

            migrationBuilder.InsertData(
                table: "BlazorUser",
                columns: new[] { "Name", "Domain", "Email", "Notes", "Phone_Number" },
                values: new object[] { "NewUser2", "gmail.com", "NewUser2@gmail.com", " first blazor app", "0711111112" });

            migrationBuilder.InsertData(
                table: "BlazorUser",
                columns: new[] { "Name", "Domain", "Email", "Notes", "Phone_Number" },
                values: new object[] { "NewUser3", "gmail.com", "NewUser3@gmail.com", " first blazor app", "0711111113" });

            migrationBuilder.InsertData(
                table: "BlazorUser",
                columns: new[] { "Name", "Domain", "Email", "Notes", "Phone_Number" },
                values: new object[] { "NewUser4", "gmail.com", "NewUser4@gmail.com", " first blazor app", "0711111114" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlazorUser");
        }
    }
}
