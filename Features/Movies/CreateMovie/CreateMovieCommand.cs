using MediatR;

namespace FeatureSlices.Features.Movies.CreateMovie
{
    public record CreateMovieCommand(string Title, string Director) : IRequest<Unit>;
}
