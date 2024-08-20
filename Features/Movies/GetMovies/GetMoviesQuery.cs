using FeatureSlices.Models;
using MediatR;

namespace FeatureSlices.Features.Movies.GetMovies
{
    public record GetMoviesQuery : IRequest<List<Movie>>;
}
