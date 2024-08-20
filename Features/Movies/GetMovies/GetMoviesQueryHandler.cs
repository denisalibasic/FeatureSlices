using FeatureSlices.Models;
using MediatR;

namespace FeatureSlices.Features.Movies.GetMovies
{
    public class GetMoviesQueryHandler : IRequestHandler<GetMoviesQuery, List<Movie>>
    {
        private readonly IGetMovieRepository _movieRepository;

        public GetMoviesQueryHandler(IGetMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<List<Movie>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
        {
            return await _movieRepository.GetMoviesAsync();
        }
    }
}
