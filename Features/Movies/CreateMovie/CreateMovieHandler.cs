using MediatR;

namespace FeatureSlices.Features.Movies.CreateMovie
{
    public class CreateMovieHandler : IRequestHandler<CreateMovieCommand, Unit>
    {
        private readonly ICreateMovieRepository _repository;

        public CreateMovieHandler(ICreateMovieRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddMovieAsync(request.Title, request.Director);
            return Unit.Value;
        }
    }
}
