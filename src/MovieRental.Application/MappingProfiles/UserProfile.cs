using AutoMapper;
using MovieRental.Application.Features.Accounts.Commands.RegisterUser;
using MovieRental.Domain.Entities;

namespace MovieRental.Application.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterUserCommand, User>()
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());
        }
    }
}
