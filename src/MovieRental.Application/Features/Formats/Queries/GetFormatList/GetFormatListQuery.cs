using AutoMapper;
using MediatR;
using MovieRental.Domain.Interfaces;

namespace MovieRental.Application.Features.Formats.Queries.GetFormatList;

public record GetFormatListQuery() : IRequest<IEnumerable<FormatListQueryDto>>;

internal sealed class GetFormatListQueryHandler : IRequestHandler<GetFormatListQuery, IEnumerable<FormatListQueryDto>>
{
    private readonly IMapper _mapper;
    private readonly IFormatRepository _formatRepository;

    public GetFormatListQueryHandler(IMapper mapper, IFormatRepository formatRepository)
    {
        _mapper = mapper;
        _formatRepository = formatRepository;
    }
    public async Task<IEnumerable<FormatListQueryDto>> Handle(GetFormatListQuery request, CancellationToken cancellationToken)
    {
        var formats = await _formatRepository.GetAllAsync(cancellationToken);

        return _mapper.Map<IEnumerable<FormatListQueryDto>>(formats);
    }
}
