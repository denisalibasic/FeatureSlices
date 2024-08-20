using FeatureSlices.Models;

namespace FeatureSlices.Features.Movies.GetMovies
{
    public interface IGetMovieRepository
    {
        Task<List<Movie>> GetMoviesAsync();
    }
}
