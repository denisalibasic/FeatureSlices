using MediatR;

namespace FeatureSlices.Features.Books.CreateBook
{
    public record CreateBookCommand(string Title, string Author) : IRequest<Unit>;
}
