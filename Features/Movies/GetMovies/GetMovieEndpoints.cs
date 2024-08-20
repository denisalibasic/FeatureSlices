using FeatureSlices.Features.Movies.CreateMovie;
using MediatR;

namespace FeatureSlices.Features.Movies.GetMovies
{
    public static class GetMovieEndpoints
    {
        public static void MapGetMovieEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/api/movies", async (IMediator mediator) =>
            {
                var result = await mediator.Send(new GetMoviesQuery());
                return Results.Ok(result);
            });
        }

        public static void AddGetMovieServices(this IServiceCollection services)
        {
            services.AddScoped<IGetMovieRepository, GetMovieRepository>();
        }
    }
}
