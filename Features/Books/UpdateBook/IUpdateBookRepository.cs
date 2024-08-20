namespace FeatureSlices.Features.Books.UpdateBook
{
    public interface IUpdateBookRepository
    {
        Task<bool> UpdateBookAsync(int id, string title, string author);
    }
}
