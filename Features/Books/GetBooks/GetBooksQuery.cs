using FeatureSlices.Models;
using MediatR;

namespace FeatureSlices.Features.Books.GetBooks
{
    public record GetBooksQuery : IRequest<List<Book>>;
}
