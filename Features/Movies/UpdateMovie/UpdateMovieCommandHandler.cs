using MediatR;

namespace FeatureSlices.Features.Movies.UpdateMovie
{
    public class UpdateMovieCommandHandler : IRequestHandler<UpdateMovieCommand, bool>
    {
        private readonly IUpdateMovieRepository _movieRepository;

        public UpdateMovieCommandHandler(IUpdateMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<bool> Handle(UpdateMovieCommand request, CancellationToken cancellationToken)
        {
            return await _movieRepository.UpdateMovieAsync(request.Id, request.Title, request.Director);
        }
    }
}
