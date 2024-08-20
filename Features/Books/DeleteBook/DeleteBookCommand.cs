using MediatR;

namespace FeatureSlices.Features.Books.DeleteBook
{
    public record DeleteBookCommand(int Id) : IRequest<bool>;
}
