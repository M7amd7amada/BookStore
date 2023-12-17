using BookStore.Application.Common.Interfaces.Services;

namespace BookStore.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime Now => DateTime.Now;
}