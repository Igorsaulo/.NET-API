public interface AuthInterface
{
    string Authenticate (string email, string password, string category);
    bool IsAuthenticated (string token);
    string DecodedToken (string token);
}