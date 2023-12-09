using Identity.Core.Entities;

namespace Identity.Core.Repositories
{
    public interface IUserRepository
    {
        //Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(User user);
        Task<User> AddUser(User user);
        //Task<User> UpdateUser(User user);
        //Task<int> DeleteUser(int id);
    }
}
