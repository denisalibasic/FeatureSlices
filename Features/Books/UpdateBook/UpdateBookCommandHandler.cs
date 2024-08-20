using MediatR;

namespace FeatureSlices.Features.Books.UpdateBook
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, bool>
    {
        private readonly IUpdateBookRepository _bookRepository;

        public UpdateBookCommandHandler(IUpdateBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<bool> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            return await _bookRepository.UpdateBookAsync(request.Id, request.Title, request.Author);
        }
    }
}
