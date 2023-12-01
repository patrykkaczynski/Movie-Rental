using AutoMapper;
using MediatR;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.CountriesOfOrigin.Queries.GetCountryOfOriginList;

public record GetCountryOfOriginListQuery() : IRequest<IEnumerable<CountryOfOriginListQueryDto>>;

public class GetCountryOfOriginListQueryHandler : IRequestHandler<GetCountryOfOriginListQuery, IEnumerable<CountryOfOriginListQueryDto>>
{
    private readonly IMapper _mapper;
    private readonly ICountryOfOriginRepository _countryOfOriginRepository;

    public GetCountryOfOriginListQueryHandler(IMapper mapper, ICountryOfOriginRepository countryOfOriginRepository)
    {
        _mapper = mapper;
        _countryOfOriginRepository = countryOfOriginRepository;
    }
    public async Task<IEnumerable<CountryOfOriginListQueryDto>> Handle(GetCountryOfOriginListQuery request, CancellationToken cancellationToken)
    {
        var countriesOfOrigin = await _countryOfOriginRepository.GetAllAsync(cancellationToken);

        await Task.Delay(5000, cancellationToken);

        return _mapper.Map<IEnumerable<CountryOfOriginListQueryDto>>(countriesOfOrigin);
    }
}
