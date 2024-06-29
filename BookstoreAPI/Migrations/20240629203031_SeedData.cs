using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookstoreAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Seed authors and books
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                { 1, "J.K. Rowling" },
                { 2, "J.R.R. Tolkien" },
                { 3, "Leo Tolstoy" },
                { 4, "Jane Austen" },
                { 5, "Fyodor Dostoevsky" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Title", "Genre", "AuthorId" },
                values: new object[,]
                {
                { 1, "Harry Potter and the Philosopher's Stone", "Fantasy", 1 },
                { 2, "The Lord of the Rings", "Fantasy", 2 },
                { 3, "War and Peace", "Historical Fiction", 3 },
                { 4, "Pride and Prejudice", "Romance, Classic Literature", 4 },
                { 5, "Crime and Punishment", "Psychological Fiction, Philosophical Fiction", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Remove all data
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4, 5 });

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4, 5 });
        }
    }
}
