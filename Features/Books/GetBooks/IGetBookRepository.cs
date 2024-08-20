using FeatureSlices.Models;

namespace FeatureSlices.Features.Books.GetBooks
{
    public interface IGetBookRepository
    {
        Task<List<Book>> GetBooksAsync();
    }
}
