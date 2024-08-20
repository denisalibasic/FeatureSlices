namespace FeatureSlices.Features.Movies.DeleteMovie
{
    public interface IDeleteMovieRepository
    {
        Task<bool> DeleteMovieAsync(int id);
    }
}
