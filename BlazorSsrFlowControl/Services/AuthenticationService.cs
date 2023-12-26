namespace BlazorServerProductionControl.Services;

public class AuthenticationService
{
    private readonly List<User> users =
    [
        new User { Username = "admin", Password = "eskabe2023" },
        new User { Username = "soldadura", Password = "soldadura2023" }
    ];

    public User? Authenticate(string username, string password)
    {
        return users.FirstOrDefault(u => u.Username == username && u.Password == password);
    }
}
