using AutoMapper;
using MediatR;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Movies.Queries.GetMovieList;

public record GetMovieListQuery() : IRequest<IEnumerable<MovieListQueryDto>>;
internal sealed class GetMovieListQueryHandler : IRequestHandler<GetMovieListQuery, IEnumerable<MovieListQueryDto>>
{
    private readonly IMapper _mapper;
    private readonly IMovieRepository _movieRepository;
    public GetMovieListQueryHandler(IMapper mapper, IMovieRepository movieRepository)
    {
        _mapper = mapper;
        _movieRepository = movieRepository;
    }
    public async Task<IEnumerable<MovieListQueryDto>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
    {
        var movies = await _movieRepository.GetAllAsync();

        return _mapper.Map<IEnumerable<MovieListQueryDto>>(movies);
    }
}
