
namespace MovieRental.Domain.Entities;

public class Rental
{
    public Guid Id { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime? ReturnedDate { get; set; }
    public DateTime DueDate { get; set; }

    public Guid PhysicalMovieId { get; set; }
    public PhysicalMovie? PhysicalMovie { get; set; }

    public Guid UserId { get; set; }
    public User? User { get; set; }
}
