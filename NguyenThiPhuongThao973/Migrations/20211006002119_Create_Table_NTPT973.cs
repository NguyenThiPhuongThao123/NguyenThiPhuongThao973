using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenThiPhuongThao973.Migrations
{
    public partial class Create_Table_NTPT973 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTPT0973",
                columns: table => new
                {
                    NTPTId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NTPTName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NTPTGender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTPT0973", x => x.NTPTId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTPT0973");
        }
    }
}
