using Ecomerce.Models;

namespace Ecomerce.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool SaveUser(User user);
        User GetUserById(Guid id);
        List<User> GetAllUsers();
        bool UpdateUser(Guid id, User user);
        bool DeleteUser(Guid id);
        string AuthtenTicateUser(string email, string password, string category);
    }
}
