using Ecomerce.Models;


namespace Ecomerce.Repositories
{
    public interface IUserRepository
    {
        bool SaveUser(UserModel user);
        UserModel GetUserById(Guid id);
        bool UpdateUser(Guid id, UserUpdateDTO user);
        bool DeleteUser(Guid id);
        List<UserModel> GetAll();
        string AuthtenTicateUser(string email, string password, string category);
    }
}
