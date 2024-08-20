using FeatureSlices.Features.Books.CreateBook;
using MediatR;

namespace FeatureSlices.Features.Books.GetBooks
{
    public static class GetBookEndpoints
    {
        public static void MapGetBooksEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/api/books", async (IMediator mediator) =>
            {
                var result = await mediator.Send(new GetBooksQuery());
                return Results.Ok(result);
            });
        }

        public static void AddGetBooksServices(this IServiceCollection services)
        {
            services.AddScoped<IGetBookRepository, GetBookRepository>();
        }
    }
}
