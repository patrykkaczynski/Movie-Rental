using AutoMapper;
using MediatR;
using MovieRental.Domain.Exceptions;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Movies.Queries.GetMovieDetail
{
    public record class GetMovieDetailQuery(Guid Id) : IRequest<MovieDetailQueryDto>;

    internal sealed class GetMoveDetailQueryHandler : IRequestHandler<GetMovieDetailQuery, MovieDetailQueryDto>
    {
        private readonly IMapper _mapper;
        private readonly IMovieRepository _movieRepository;

        public GetMoveDetailQueryHandler(IMapper mapper, IMovieRepository movieRepository)
        {
            _mapper = mapper;
            _movieRepository = movieRepository;
        }
        public async Task<MovieDetailQueryDto> Handle(GetMovieDetailQuery request, CancellationToken cancellationToken)
        {
            var movie = await _movieRepository.GetByIdAsync(request.Id);

            return movie is null
                ? throw new NotFoundException($"Movie does not exist with {request.Id}")
                : _mapper.Map<MovieDetailQueryDto>(movie);
        }
    }

}
