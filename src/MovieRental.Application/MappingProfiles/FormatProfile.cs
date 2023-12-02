using AutoMapper;
using MovieRental.Application.Features.Formats.Queries.GetFormatList;
using MovieRental.Domain.Entities;

namespace MovieRental.Application.MappingProfiles;

public class FormatProfile : Profile
{
    public FormatProfile()
    {
        CreateMap<Format, FormatListQueryDto>();
    }
}
