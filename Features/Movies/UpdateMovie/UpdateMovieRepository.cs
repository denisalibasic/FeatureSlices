using FeatureSlices.Models;

namespace FeatureSlices.Features.Movies.UpdateMovie
{
    public class UpdateMovieRepository : IUpdateMovieRepository
    {
        private readonly MyDbContext _context;

        public UpdateMovieRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> UpdateMovieAsync(int id, string title, string director)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return false;
            }

            movie.Title = title;
            movie.Director = director;
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
