using MediatR;

namespace FeatureSlices.Features.Movies.UpdateMovie
{
    public record UpdateMovieCommand(int Id, string Title, string Director) : IRequest<bool>;
}
