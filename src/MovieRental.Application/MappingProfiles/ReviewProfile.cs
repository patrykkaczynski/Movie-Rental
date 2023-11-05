using AutoMapper;
using MovieRental.Application.Features.Reviews.Commands;
using MovieRental.Application.Features.Reviews.Queries;
using MovieRental.Domain.Entities;

namespace MovieRental.Application.MappingProfiles
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<CreateReviewCommand, Review>();

            CreateMap<Review, ReviewListQueryDto>();
        }
    }
}
