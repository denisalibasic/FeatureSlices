using FeatureSlices.Models;

namespace FeatureSlices.Features.Movies.CreateMovie
{
    public class CreateMovieRepository : ICreateMovieRepository
    {
        private readonly MyDbContext _context;

        public CreateMovieRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task AddMovieAsync(string title, string director)
        {
            var movie = new Movie { Title = title, Director = director };
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }
    }
}
