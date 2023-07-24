using AutoMapper;
using MediatR;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Reviews.Queries;

public record GetReviewsQuery(Guid MovieId) : IRequest<IEnumerable<GetReviewListQueryDto>>;

internal sealed class GetReviewsQueryHandler : IRequestHandler<GetReviewsQuery, IEnumerable<GetReviewListQueryDto>>
{
    private readonly IReviewRepository _reviewRepository;
    private readonly IMapper _mapper;

    public GetReviewsQueryHandler(IReviewRepository reviewRepository, IMapper mapper)
    {
        _reviewRepository = reviewRepository;
        _mapper = mapper;
    }
    public async Task<IEnumerable<GetReviewListQueryDto>> Handle(GetReviewsQuery request, CancellationToken cancellationToken)
    {
        var reviews = await _reviewRepository.GetAsync(request.MovieId);

        return _mapper.Map<IEnumerable<GetReviewListQueryDto>>(reviews);
    }
}



