using MediatR;

namespace FeatureSlices.Features.Movies.DeleteMovie
{
    public class DeleteMovieCommandHandler : IRequestHandler<DeleteMovieCommand, bool>
    {
        private readonly IDeleteMovieRepository _movieRepository;

        public DeleteMovieCommandHandler(IDeleteMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<bool> Handle(DeleteMovieCommand request, CancellationToken cancellationToken)
        {
            return await _movieRepository.DeleteMovieAsync(request.Id);
        }
    }
}
