﻿namespace Bookstore.Shared.DTOs
{
    public class BookCrudDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }
    }
}
