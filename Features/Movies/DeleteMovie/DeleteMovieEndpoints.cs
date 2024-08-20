using MediatR;

namespace FeatureSlices.Features.Movies.DeleteMovie
{
    public static class DeleteMovieEndpoints
    {
        public static void MapDeleteMovieEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapDelete("/api/movies/{id}", async (int id, IMediator mediator) =>
            {
                var result = await mediator.Send(new DeleteMovieCommand(id));
                return result ? Results.NoContent() : Results.NotFound();
            });
        }

        public static void AddDeleteMovieServices(this IServiceCollection services)
        {
            services.AddScoped<IDeleteMovieRepository, DeleteMovieRepository>();
        }
    }
}
