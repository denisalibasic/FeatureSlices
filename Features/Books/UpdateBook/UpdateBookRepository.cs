using FeatureSlices.Models;

namespace FeatureSlices.Features.Books.UpdateBook
{
    public class UpdateBookRepository : IUpdateBookRepository
    {
        private readonly MyDbContext _context;

        public UpdateBookRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> UpdateBookAsync(int id, string title, string author)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return false;
            }

            book.Title = title;
            book.Author = author;
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
