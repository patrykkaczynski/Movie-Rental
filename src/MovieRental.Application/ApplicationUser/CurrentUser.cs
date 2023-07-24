namespace MovieRental.Application.ApplicationUser;

public class CurrentUser
{
    public CurrentUser(string fullName)
    {
        FullName = fullName;
    }
    public string FullName { get; set; }

}
