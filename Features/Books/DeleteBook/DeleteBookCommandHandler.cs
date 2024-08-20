using MediatR;

namespace FeatureSlices.Features.Books.DeleteBook
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, bool>
    {
        private readonly IDeleteBookRepository _bookRepository;

        public DeleteBookCommandHandler(IDeleteBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<bool> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            return await _bookRepository.DeleteBookAsync(request.Id);
        }
    }
}
