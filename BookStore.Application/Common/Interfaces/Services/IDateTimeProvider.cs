namespace BookStore.Application.Common.Interfaces.Services;

public interface IDateTimeProvider
{
    public DateTime Now { get; }
}