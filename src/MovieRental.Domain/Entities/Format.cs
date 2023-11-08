
namespace MovieRental.Domain.Entities;

public class Format
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public ICollection<PhysicalMovie> PhysicalMovies = new List<PhysicalMovie>();
}
