using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using MovieRental.Domain.Entities;
using MovieRental.Infrastructure.Persistence;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MovieRental.Api.Swagger.ParameterFilters
{
    public class RolesParameterFilter : IParameterFilter
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public RolesParameterFilter(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }
        public void Apply(OpenApiParameter parameter, ParameterFilterContext context)
        {
            if (parameter.Name.Equals("role", StringComparison.InvariantCultureIgnoreCase))
            {
                using var scope = _serviceScopeFactory.CreateScope();
                var dbContext = scope.ServiceProvider.GetRequiredService<MovieRentalDbContext>();

                IEnumerable<Role> roles = dbContext.Roles.ToArray();

                parameter.Schema.Enum = roles.Select(r => new OpenApiString(r.Name)).ToList<IOpenApiAny>();
            }
        }
    }
}
