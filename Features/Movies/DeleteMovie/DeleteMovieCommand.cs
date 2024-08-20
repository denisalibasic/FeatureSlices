using MediatR;

namespace FeatureSlices.Features.Movies.DeleteMovie
{
    public record DeleteMovieCommand(int Id) : IRequest<bool>;
}
