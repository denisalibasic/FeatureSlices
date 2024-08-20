using MediatR;

namespace FeatureSlices.Features.Books.CreateBook
{
    public static class CreateBookEndpoints
    {
        public static void MapCreateBookEndpoints(this WebApplication app)
        {
            app.MapPost("api/books", async (CreateBookCommand command, IMediator mediator) =>
            {
                await mediator.Send(command);
                return Results.Ok();
            });
        }

        public static void AddCreateBookServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateBookRepository, CreateBookRepository>();
        }
    }
}
