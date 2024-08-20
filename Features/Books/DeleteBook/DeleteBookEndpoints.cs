using MediatR;

namespace FeatureSlices.Features.Books.DeleteBook
{
    public static class DeleteBookEndpoints
    {
        public static void MapDeleteBookEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapDelete("/api/books/{id}", async (int id, IMediator mediator) =>
            {
                var result = await mediator.Send(new DeleteBookCommand(id));
                return result ? Results.NoContent() : Results.NotFound();
            });
        }

        public static void AddDeleteBookServices(this IServiceCollection services)
        {
            services.AddScoped<IDeleteBookRepository, DeleteBookRepository>();
        }
    }
}
