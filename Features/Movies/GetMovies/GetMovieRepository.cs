using FeatureSlices.Models;
using Microsoft.EntityFrameworkCore;

namespace FeatureSlices.Features.Movies.GetMovies
{
    public class GetMovieRepository : IGetMovieRepository
    {
        private readonly MyDbContext _context;

        public GetMovieRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Movie>> GetMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }
    }
}
