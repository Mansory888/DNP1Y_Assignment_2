using System.Threading.Tasks;

namespace Assignment_1.Data
{
    public interface ITUserInterface
    {
        Task<User> ValidateUserOnCloud(string userName, string Password);
       
        Task AddUser(User user);
    }
}