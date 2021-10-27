using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1.Data
{
    public class UserService : ITUserInterface
    {
        private List<User> users;

        public UserService()
        {
            users = new List<User>();
            users.Add(new User()
            {
                UserName = "admin",
                pass = "1234",
                BirthYear = 2001,
                SecurityLevel = 5
            });
        }

        public async Task<User> AddUser(User user)
        {
            users.Add(user);
            return user;
        }
        
        public async Task<IList<User>> getUsers()
        {
            List<User> allUsers = new List<User>(users);
            return allUsers;
        }

        public async Task<User> ValidateUser(string userName, string Password)
        {
            User toValidate = users.FirstOrDefault(user => user.UserName.Equals(userName));

            if (toValidate==null)
            {
                throw new Exception("user not found");
            }

            if (!toValidate.pass.Equals(Password))
            {
                throw new Exception("wrong password");
            }
            
            return toValidate;
        }
    }
}