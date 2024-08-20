using FeatureSlices.Models;

namespace FeatureSlices.Features.Movies.DeleteMovie
{
    public class DeleteMovieRepository : IDeleteMovieRepository
    {
        private readonly MyDbContext _context;

        public DeleteMovieRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return false;
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
