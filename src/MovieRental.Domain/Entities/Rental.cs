
namespace MovieRental.Domain.Entities;

public class Rental
{
    public int Id { get; set; }
    public DateTimeOffset RentalDate { get; set; }
    public DateTimeOffset? ReturnedDate { get; set; }
    public DateTimeOffset DueDate { get; set; }

    public int PhysicalMovieId { get; set; }
    public PhysicalMovie? PhysicalMovie { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
}
