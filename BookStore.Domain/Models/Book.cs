namespace BookStore.Domain.Models;

public class Book
{
    public Guid BookId { get; set; }

    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public DateTime PublishedOne { get; set; }
    public string Publisher { get; set; } = default!;
    public decimal Price { get; set; }
    public string ImageUrl { get; set; } = default!;

    // Relations
    public ICollection<BookAuthor> Authors { get; set; } = default!;
    public PriceOffer? PriceOffer { get; set; }
    public ICollection<Review> Reviews { get; set; } = default!;
    public ICollection<Tag> Tags { get; set; } = default!;
}