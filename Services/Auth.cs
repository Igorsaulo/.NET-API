using Ecomerce.Data;


namespace Ecomerce.Services
{
    public class AuthService : AuthInterface
{
    private readonly AppDbContext _context;
    public AuthService(AppDbContext context)
    {
        _context = context;
    }
    public string Authenticate(string email, string password, string category)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == email);
        if (user == null)
        {
            return null;
        }
        if (PassWordManager.ValidatePassword(password, user.Password))
        {
            return TokenService.GenerateToken(user);
        }

        return null;
    }
    public bool IsAuthenticated(string token)
    {
        var user = TokenService.DecodeToken(token);
        if (user == null)
        {
            return false;
        }
        return true;
    }
    public string DecodedToken(string token)
    {
        var user = TokenService.DecodeToken(token);
        if (user == null)
        {
            return null;
        }
        return user;
    }
}
}