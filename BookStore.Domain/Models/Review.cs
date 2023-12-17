namespace BookStore.Domain.Models;

public class Review
{
    public Guid ReviewId { get; set; }

    public string VoterName { get; set; } = default!;
    public int NumStars { get; set; }
    public string Comment { get; set; } = default!;

    // Relations
    public Guid BookId { get; set; }
}