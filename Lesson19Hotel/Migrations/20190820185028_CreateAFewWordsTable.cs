using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lesson19Hotel.Migrations
{
    public partial class CreateAFewWordsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AFewWordss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Icon = table.Column<string>(maxLength: 100, nullable: false),
                    TitleBig = table.Column<string>(maxLength: 100, nullable: false),
                    TitleSmall = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AFewWordss", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AFewWordss");
        }
    }
}
