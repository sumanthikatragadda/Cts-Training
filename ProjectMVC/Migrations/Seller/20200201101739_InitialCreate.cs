using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectMVC.Migrations.Seller
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sname = table.Column<string>(nullable: true),
                    Companyname = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    Semail = table.Column<string>(nullable: true),
                    Spassword = table.Column<string>(nullable: true),
                    Saddress = table.Column<string>(nullable: true),
                    Contactno = table.Column<int>(nullable: false),
                    Photopath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Sid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
