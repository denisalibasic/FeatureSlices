using FeatureSlices.Models;

namespace FeatureSlices.Features.Books.CreateBook
{
    public class CreateBookRepository : ICreateBookRepository
    {
        private readonly MyDbContext _context;

        public CreateBookRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task AddBookAsync(string title, string author)
        {
            var book = new Book { Title = title, Author = author };
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
        }
    }
}
