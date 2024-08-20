using FeatureSlices.Models;
using Microsoft.EntityFrameworkCore;

namespace FeatureSlices.Features.Books.GetBooks
{
    public class GetBookRepository : IGetBookRepository
    {
        private readonly MyDbContext _context;

        public GetBookRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }
    }
}
