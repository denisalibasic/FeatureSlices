namespace FeatureSlices.Features.Books.CreateBook
{
    public interface ICreateBookRepository
    {
        Task AddBookAsync(string title, string author);
    }
}
