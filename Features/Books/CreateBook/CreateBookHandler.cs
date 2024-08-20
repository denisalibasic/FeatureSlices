using MediatR;

namespace FeatureSlices.Features.Books.CreateBook
{
    public class CreateBookHandler : IRequestHandler<CreateBookCommand, Unit>
    {
        private readonly ICreateBookRepository _repository;

        public CreateBookHandler(ICreateBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddBookAsync(request.Title, request.Author);
            return Unit.Value;
        }
    }
}
