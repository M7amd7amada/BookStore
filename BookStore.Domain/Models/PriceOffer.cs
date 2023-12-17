namespace BookStore.Domain.Models;

public class PriceOffer
{
    public Guid PriceOfferId { get; set; }

    public decimal NewPrice { get; set; }
    public string PromotionalText { get; set; } = default!;

    // Relations
    public Guid BookId { get; set; }
}