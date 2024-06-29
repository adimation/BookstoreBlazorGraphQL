using BookstoreAPI.DataAccess.Entities;
using BookstoreAPI.DataAccess;
using Bookstore.Shared.DTOs;

namespace BookstoreAPI.GraphQL.Mutations
{
    public class Mutation
    {
        public async Task<BookCrudDTO> AddBookAsync(BookCrudDTO bookDto, [Service] BookstoreDBContext context)
        {
            var book = new Book
            {
                Title = bookDto.Title,
                Genre = bookDto.Genre,
                AuthorId = bookDto.AuthorId
            };
            context.Books.Add(book);
            await context.SaveChangesAsync();
            bookDto.Id = book.Id;
            return bookDto;
        }

        public async Task<BookCrudDTO> UpdateBookAsync(int id, BookCrudDTO bookDto, [Service] BookstoreDBContext context)
        {
            var book = await context.Books.FindAsync(id);
            if (book != null)
            {
                book.Title = bookDto.Title;
                book.Genre = bookDto.Genre;
                book.AuthorId = bookDto.AuthorId;
                await context.SaveChangesAsync();
            }
            return bookDto;
        }
    }
}
