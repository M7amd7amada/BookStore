namespace BookStore.Domain.Models;

public class Tag
{
    public Guid TagId { get; set; }

    // Relations
    public ICollection<Book> Books { get; set; } = default!;
}