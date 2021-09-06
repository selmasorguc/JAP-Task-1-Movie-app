using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class TvShowEntityAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TVShowId",
                table: "Actors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TVShows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CoverUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Rating = table.Column<float>(type: "REAL", nullable: false),
                    SeasonNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVShows", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_TVShowId",
                table: "Actors",
                column: "TVShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_TVShows_TVShowId",
                table: "Actors",
                column: "TVShowId",
                principalTable: "TVShows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_TVShows_TVShowId",
                table: "Actors");

            migrationBuilder.DropTable(
                name: "TVShows");

            migrationBuilder.DropIndex(
                name: "IX_Actors_TVShowId",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "TVShowId",
                table: "Actors");
        }
    }
}
