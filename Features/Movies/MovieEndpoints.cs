using FeatureSlices.Features.Movies.CreateMovie;
using FeatureSlices.Features.Movies.DeleteMovie;
using FeatureSlices.Features.Movies.GetMovies;
using FeatureSlices.Features.Movies.UpdateMovie;

namespace FeatureSlices.Features.Movies
{
    public static class MovieEndpoints
    {
        public static void MapMovieEndpoints(this WebApplication app)
        {
            app.MapCreateMovieEndpoints();
            app.MapGetMovieEndpoints();
            app.MapDeleteMovieEndpoints();
            app.MapUpdateMovieEndpoints();
        }

        public static void AddMovieServices(this IServiceCollection services)
        {
            services.AddCreateMovieServices();
            services.AddGetMovieServices();
            services.AddDeleteMovieServices();
            services.AddUpdateMovieServices();
        }
    }
}
