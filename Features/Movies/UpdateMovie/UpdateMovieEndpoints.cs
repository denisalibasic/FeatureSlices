using MediatR;

namespace FeatureSlices.Features.Movies.UpdateMovie
{
    public static class UpdateMovieEndpoints
    {
        public static void MapUpdateMovieEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapPut("/api/movies/{id}", async (int id, UpdateMovieCommand command, IMediator mediator) =>
            {
                if (id != command.Id)
                {
                    return Results.BadRequest();
                }

                var result = await mediator.Send(command);
                return result ? Results.NoContent() : Results.NotFound();
            });
        }

        public static void AddUpdateMovieServices(this IServiceCollection services)
        {
            services.AddScoped<IUpdateMovieRepository, UpdateMovieRepository>();
        }
    }
}
