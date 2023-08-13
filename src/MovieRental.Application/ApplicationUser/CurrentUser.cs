namespace MovieRental.Application.ApplicationUser;

public class CurrentUser
{
    public CurrentUser(string fullName, IEnumerable<string> roles)
    {
        FullName = fullName;
        Roles = roles;

    }
    public string FullName { get; set; }
    public IEnumerable<string> Roles { get; set; }

    public bool IsInRole(string role) => Roles.Contains(role);

}
