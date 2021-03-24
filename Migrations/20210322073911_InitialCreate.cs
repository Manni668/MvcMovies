using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVcMovie.Migrations
{
    public partial class InitialCreate : Migration
    {
        //创建Movie表
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    //Id为主键
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });
        }

        //Down方法可还原Up迁移做的更改
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
