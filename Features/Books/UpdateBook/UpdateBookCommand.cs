using MediatR;

namespace FeatureSlices.Features.Books.UpdateBook
{
    public record UpdateBookCommand(int Id, string Title, string Author) : IRequest<bool>;
}
