using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieWebApp.Migrations
{
    public partial class CreateActors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Ensure the 'Actors' table doesn't exist before creating it
            migrationBuilder.Sql(
                "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Actors') " +
                "BEGIN " +
                "CREATE TABLE [Actors] (" +
                "[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, " +
                "[FirstName] NVARCHAR(20) NOT NULL, " +
                "[Surname] NVARCHAR(20) NOT NULL, " +
                "[Description] NVARCHAR(700) NOT NULL, " +
                "[ActorImageUrl] NVARCHAR(MAX) NOT NULL)" +
                "END"
            );

            // Add other migrations safely (ensure no duplicates)
            migrationBuilder.Sql(
                "IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TVShows') " +
                "BEGIN " +
                "CREATE TABLE [TVShows] (" +
                "[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, " +
                "[Title] NVARCHAR(70) NOT NULL, " +
                "[Genre] NVARCHAR(30) NOT NULL, " +
                "[ReleaseDate] DATETIME2 NOT NULL, " +
                "[Casts] NVARCHAR(350) NOT NULL, " +
                "[Duration] INT NOT NULL, " +
                "[Country] NVARCHAR(50) NOT NULL, " +
                "[Production] NVARCHAR(210) NOT NULL, " +
                "[TVSeriesImageUrl] NVARCHAR(MAX) NOT NULL, " +
                "[Description] NVARCHAR(700) NOT NULL)" +
                "END"
            );

            // Insert data into Actors
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ActorImageUrl", "Description", "FirstName", "Surname" },
                values: new object[,]
                {
                    { Guid.NewGuid(), "https://s.abcnews.com/images/GMA/240222_gma_digital_paul_giamatti_hpMain_4x5_608.jpg", "Paul Giamatti is a celebrated American actor...", "Paul", "Giamatti" },
                    { Guid.NewGuid(), "https://i.pinimg.com/736x/b0/86/f1/b086f106f5f95f68df6d86b8fab10b6d.jpg", "Cillian Murphy is an Irish actor renowned...", "Cillian", "Murphy" },
                    // Add more records here as needed
                });

            // Insert data into TVShows
            migrationBuilder.InsertData(
                table: "TVShows",
                columns: new[] { "Id", "Casts", "Country", "Description", "Duration", "Genre", "Production", "ReleaseDate", "TVSeriesImageUrl", "Title" },
                values: new object[,]
                {
                    { Guid.NewGuid(), "Bryan Cranston, Anna Gunn...", "United States of America", "Breaking Bad description...", 45, "Drama", "Sony Pictures Television...", new DateTime(2008, 1, 20), "https://breaking-bad.jpg", "Breaking Bad" },
                    { Guid.NewGuid(), "Cillian Murphy, Paul Anderson...", "United Kingdom", "Peaky Blinders description...", 60, "Crime, Drama", "BBC Productions...", new DateTime(2013, 9, 12), "https://peaky-blinders.jpg", "Peaky Blinders" },
                    // Add more records here as needed
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the TVShows table if it exists
            migrationBuilder.Sql("IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'TVShows') DROP TABLE [TVShows]");

            // Delete records from Actors table
            migrationBuilder.Sql("DELETE FROM [Actors] WHERE [FirstName] IN ('Paul', 'Cillian')");

            // Drop the Actors table if it exists
            migrationBuilder.Sql("IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Actors') DROP TABLE [Actors]");
        }
    }
}
