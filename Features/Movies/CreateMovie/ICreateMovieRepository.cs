namespace FeatureSlices.Features.Movies.CreateMovie
{
    public interface ICreateMovieRepository
    {
        Task AddMovieAsync(string title, string director);
    }
}
