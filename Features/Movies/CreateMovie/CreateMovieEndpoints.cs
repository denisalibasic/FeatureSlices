using MediatR;

namespace FeatureSlices.Features.Movies.CreateMovie
{
    public static class CreateMovieEndpoints
    {
        public static void MapCreateMovieEndpoints(this WebApplication app)
        {
            app.MapPost("api/movies", async (CreateMovieCommand command, IMediator mediator) =>
            {
                await mediator.Send(command);
                return Results.Ok();
            });
        }

        public static void AddCreateMovieServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateMovieRepository, CreateMovieRepository>();
        }
    }
}
