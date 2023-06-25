using Ecomerce.Data;
using Ecomerce.Models;
using Ecomerce.Services;
using Microsoft.EntityFrameworkCore;


namespace Ecomerce.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        private readonly AuthInterface _authService;

        public UserRepository(AppDbContext context)
        {
            _context = context;
            _authService = new AuthService(_context);
        }

        public bool SaveUser(UserModel user)
        {
            user.Password = PassWordManager.HashPassword(user.Password);
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public UserModel GetUserById(Guid id)
        {
            return _context.Users.Find(id);
        }
        public bool UpdateUser(Guid id, UserUpdateDTO user)
        {
            if (user.Password != null)
            {
                user.Password = PassWordManager.HashPassword(user.Password);
            }

            var existingUser = _context.Users.Find(id);
            if (existingUser != null)
            {
                _context.Entry(existingUser).State = EntityState.Detached;
            }

            var userToUpdate = new UserModel
            {
                Id = id,
                Username = user.Username,
                Email = user.Email,
                Password = user.Password,
                Category = user.Category
            };

            _context.Users.Update(userToUpdate);
            _context.SaveChanges();

            return true;
        }


        public bool DeleteUser(Guid id)
        {
            var user = this.GetUserById(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
            return true;
        }

        public List<UserModel> GetAll()
        {
            return _context.Users.ToList();
        }public string AuthtenTicateUser(string email, string password, string category)
        {
            return _authService.Authenticate(email, password, category);
        }


    }
}
