using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class MovieEntityChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsMovie",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMovie",
                table: "Movies");

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
                    CoverUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Rating = table.Column<float>(type: "REAL", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SeasonNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true)
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
    }
}
