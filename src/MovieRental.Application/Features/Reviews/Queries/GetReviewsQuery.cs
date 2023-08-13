using AutoMapper;
using MediatR;
using MovieRental.Domain.Exceptions;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Reviews.Queries;

public record GetReviewsQuery(Guid MovieId) : IRequest<IEnumerable<ReviewListQueryDto>>;

internal sealed class GetReviewsQueryHandler : IRequestHandler<GetReviewsQuery, IEnumerable<ReviewListQueryDto>>
{
    private readonly IMovieRepository _movieRepository;
    private readonly IMapper _mapper;

    public GetReviewsQueryHandler(IMovieRepository movieRepository, IMapper mapper)
    {
        _movieRepository = movieRepository;
        _mapper = mapper;
    }
    public async Task<IEnumerable<ReviewListQueryDto>> Handle(GetReviewsQuery request, CancellationToken cancellationToken)
    {
        var restaurant = await _movieRepository.GetByIdAsync(request.MovieId) ?? throw new NotFoundException($"Movie does not exist with {request.MovieId} id");

        return _mapper.Map<IEnumerable<ReviewListQueryDto>>(restaurant.Reviews);
    }
}



