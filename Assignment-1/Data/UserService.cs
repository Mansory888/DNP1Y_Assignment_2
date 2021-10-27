using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_1.Data
{
    public class UserService 
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

        public void AddUser(User user)
        {
            users.Add(user);
        }
        
        public User ValidateUser(string userName, string Password)
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