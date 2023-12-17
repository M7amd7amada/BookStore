using BookStore.Application.Extensions;
using BookStore.Infrastructure.Extensions;

namespace BookStore.Api.Extensions;

public static class Extensions
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddControllers();

        builder.Services
            .AddApplication()
            .AddInfrastructure(builder.Configuration);
    }
}