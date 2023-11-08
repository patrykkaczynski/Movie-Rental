
namespace MovieRental.Domain.Entities;

public class PhysicalMovie
{
    public int Id { get; private set; }
    public int Quantity { get; set; }

    public int FormatId { get; set; }
    public Format? Format { get; set; }

    public int MovieId { get; set; }
    public Movie? Movie { get; set; }
    public ICollection<Rental> Rentals { get; set; } = new List<Rental>();
}


