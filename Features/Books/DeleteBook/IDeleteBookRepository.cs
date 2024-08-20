namespace FeatureSlices.Features.Books.DeleteBook
{
    public interface IDeleteBookRepository
    {
        Task<bool> DeleteBookAsync(int id);
    }
}
