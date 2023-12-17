namespace BookStore.Domain.Models;

public class Author
{
    public Guid AuthorId { get; set; }

    public string Name { get; set; } = default!;

    // Relations
    public ICollection<BookAuthor> Books { get; set; } = default!;
}