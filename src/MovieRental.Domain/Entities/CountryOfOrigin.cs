
namespace MovieRental.Domain.Entities;

public class CountryOfOrigin
{
    public int Id { get; set; }
    public required string CommonName { get; set; }
    public required string NameAlpha3Code { get; set; }
    public ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
