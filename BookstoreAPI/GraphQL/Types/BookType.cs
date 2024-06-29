using BookstoreAPI.DataAccess.Entities;
using Bookstore.Shared.DTOs;

namespace BookstoreAPI.GraphQL.Types
{
    public class BookType : ObjectType<BookDTO>
    {
        protected override void Configure(IObjectTypeDescriptor<BookDTO> descriptor)
        {
            descriptor.Description("Represents a book.");
        }
    }
}
