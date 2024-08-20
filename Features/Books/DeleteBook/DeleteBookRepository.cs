using FeatureSlices.Models;

namespace FeatureSlices.Features.Books.DeleteBook
{
    public class DeleteBookRepository : IDeleteBookRepository
    {
        private readonly MyDbContext _context;

        public DeleteBookRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return false;
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
