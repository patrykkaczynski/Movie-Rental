using AutoMapper;
using MediatR;
using MovieRental.Application.ApplicationUser;
using MovieRental.Domain.Entities;
using MovieRental.Domain.Exceptions;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Reviews.Commands;

public record class CreateReviewCommand(
    Guid MovieId,
    string Description, 
    int Rating) : IRequest<Guid>;

internal sealed class CreateReviewHandler : IRequestHandler<CreateReviewCommand, Guid>
{
    private readonly IMovieRepository _movieRepository;
    private readonly IMapper _mapper;
    private readonly IUserContext _userContext;
    private readonly IReviewRepository _reviewRepository;

    public CreateReviewHandler(IMovieRepository movieRepository, IMapper mapper, IUserContext userContext, IReviewRepository reviewRepository)
    {
        _movieRepository = movieRepository;
        _mapper = mapper;
        _userContext = userContext;
        _reviewRepository = reviewRepository;
    }
    public async Task<Guid> Handle(CreateReviewCommand request, CancellationToken cancellationToken)
    {
        var currentUser = _userContext.GetCurrentUser();
        if (currentUser == null || !currentUser.IsInRole("Client"))
        {
            throw new NotFoundException($"You do not have access");
        }
        var movie = await _movieRepository.GetByIdAsync(request.MovieId);

        if(movie is null)
            throw new NotFoundException($"Movie does not exist with {request.MovieId} id");

        var review = _mapper.Map<Review>(request);

        review.CreatedBy = currentUser.FullName;
        review.CreationDate = DateTime.UtcNow;
        review.MovieId = request.MovieId;

        var id = await _reviewRepository.CreateAsync(review);

        return id;
    }
}
