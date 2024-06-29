using BookstoreAPI.DataAccess.Entities;
using BookstoreAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Bookstore.Shared.DTOs;

namespace BookstoreAPI.GraphQL.Queries
{
    public class Query
    {
        public IQueryable<BookDTO> GetBooks([Service] BookstoreDBContext context)
        {
            return context.Books
                .Select(book => new BookDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                    Genre = book.Genre,
                    AuthorId = book.AuthorId,
                    Author = new AuthorDTO
                    {
                        Id = book.Author.Id,
                        Name = book.Author.Name
                    }
                });
        }

        public IQueryable<AuthorDTO> GetAuthors([Service] BookstoreDBContext context)
        {
            return context.Authors
                .Select(author => new AuthorDTO
                {
                    Id = author.Id,
                    Name = author.Name,
                    Books = author.Books.Select(book => new BookDTO
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Genre = book.Genre,
                        AuthorId = book.AuthorId
                    }).ToList()
                });
        }
    }
}
