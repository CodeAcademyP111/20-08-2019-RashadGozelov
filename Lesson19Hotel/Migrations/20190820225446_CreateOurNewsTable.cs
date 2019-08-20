using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lesson19Hotel.Migrations
{
    public partial class CreateOurNewsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OurNewss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(maxLength: 100, nullable: false),
                    ImageModal = table.Column<string>(maxLength: 100, nullable: false),
                    TitlePicture = table.Column<string>(maxLength: 100, nullable: false),
                    Description1 = table.Column<string>(maxLength: 400, nullable: false),
                    Description2 = table.Column<string>(maxLength: 400, nullable: false),
                    Activ = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurNewss", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OurNewss");
        }
    }
}
