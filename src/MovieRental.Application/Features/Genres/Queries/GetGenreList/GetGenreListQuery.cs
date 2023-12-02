using AutoMapper;
using MediatR;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Genres.Queries.GetGenreList;

public record GetGenreListQuery() : IRequest<IEnumerable<GenreListQueryDto>>;
internal sealed class GetGenreListQueryHandler : IRequestHandler<GetGenreListQuery, IEnumerable<GenreListQueryDto>>
{
    private readonly IMapper _mapper;
    private readonly IGenreRepository _genreRepository;

    public GetGenreListQueryHandler(IMapper mapper, IGenreRepository genreRepository)
    {
        _mapper = mapper;
        _genreRepository = genreRepository;
    }
    public async Task<IEnumerable<GenreListQueryDto>> Handle(GetGenreListQuery request, CancellationToken cancellationToken)
    {
        var genres = await _genreRepository.GetAllAsync(cancellationToken);

        return _mapper.Map<IEnumerable<GenreListQueryDto>>(genres);
    }
}
