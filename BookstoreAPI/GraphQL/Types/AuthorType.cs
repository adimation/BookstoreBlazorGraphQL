using BookstoreAPI.DataAccess.Entities;
using Bookstore.Shared.DTOs;

namespace BookstoreAPI.GraphQL.Types
{
    public class AuthorType : ObjectType<AuthorDTO>
    {
        protected override void Configure(IObjectTypeDescriptor<AuthorDTO> descriptor)
        {
            descriptor.Description("Represents an author.");
        }
    }
}
