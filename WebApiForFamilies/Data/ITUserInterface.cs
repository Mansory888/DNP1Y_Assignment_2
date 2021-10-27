using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assignment_1.Data
{
    public interface ITUserInterface
    {
        Task<User> ValidateUser(string userName, string Password);
        Task<User> AddUser(User user);
        Task<IList<User>> getUsers();
    }
}