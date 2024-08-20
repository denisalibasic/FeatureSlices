namespace FeatureSlices.Features.Movies.UpdateMovie
{
    public interface IUpdateMovieRepository
    {
        Task<bool> UpdateMovieAsync(int id, string title, string director);
    }
}
