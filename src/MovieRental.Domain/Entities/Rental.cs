
namespace MovieRental.Domain.Entities;

public class Rental
{
    public int Id { get; private set; }
    public DateTimeOffset RentalDate { get; set; }
    public DateTimeOffset? ReturnedDate { get; set; }
    public DateTimeOffset DueDate { get; set; }

    public Guid PhysicalMovieId { get; set; }
    public PhysicalMovie? PhysicalMovie { get; set; }

    public Guid UserId { get; set; }
    public User? User { get; set; }
}
