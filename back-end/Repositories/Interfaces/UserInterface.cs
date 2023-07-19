using Ecomerce.Models;

namespace Ecomerce.Repositories
{
    public interface IUserRepository
    {
        bool SaveUser(User user);
        User GetUserById(Guid id);
        bool UpdateUser(Guid id, User user);
        bool DeleteUser(Guid id);
        List<User> GetAll();
        bool addProducInShoppingCar(Guid id, Product product);
        bool removeProductInShoppingCar(Guid id, Product product);
        string AuthtenTicateUser(string email, string password, string category);
    }
}
