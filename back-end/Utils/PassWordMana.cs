using Bcrypt = BCrypt.Net.BCrypt;


namespace Ecomerce.Utils
{
  public class PassWordManager
  {
    public static string HashPassword(string password)
    {
      var salt = Bcrypt.GenerateSalt(12);
      var hash = Bcrypt.HashPassword(password, salt);
      return hash;
    }

    public static bool ValidatePassword(string password, string correctHash)
    {
      return Bcrypt.Verify(password, correctHash);
    }
  }
}