using MediatR;

namespace FeatureSlices.Features.Books.UpdateBook
{
    public static class UpdateBookEndpoints
    {
        public static void MapUpdateBookEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapPut("/api/books/{id}", async (int id, UpdateBookCommand command, IMediator mediator) =>
            {
                if (id != command.Id)
                {
                    return Results.BadRequest();
                }

                var result = await mediator.Send(command);
                return result ? Results.NoContent() : Results.NotFound();
            });
        }

        public static void AddUpdateBookServices(this IServiceCollection services)
        {
            services.AddScoped<IUpdateBookRepository, UpdateBookRepository>();
        }
    }
}
