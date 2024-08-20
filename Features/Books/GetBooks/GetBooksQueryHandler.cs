using FeatureSlices.Models;
using MediatR;

namespace FeatureSlices.Features.Books.GetBooks
{
    public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, List<Book>>
    {
        private readonly IGetBookRepository _bookRepository;

        public GetBooksQueryHandler(IGetBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<Book>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            return await _bookRepository.GetBooksAsync();
        }
    }
}
