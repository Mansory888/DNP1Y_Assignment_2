using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebApiForFamilies.Persistance;

namespace Assignment_1.Data
{
    public class UserService : ITUserInterface
    {
        private static List<User> users;
        private static FamilyDBContext Context = new FamilyDBContext();

        public UserService()
        {
            users = new List<User>();
            LoadUserFromDb(Context);
            
        }

        public async Task<User> AddUser(User user)
        {
            EntityEntry<User> newlyAdded = await Context.Users.AddAsync(user);
            await Context.SaveChangesAsync();
            return newlyAdded.Entity;
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

        private static async Task LoadUserFromDb(FamilyDBContext familyDbContext)
        {
            users = await familyDbContext.Users.ToListAsync();
        }
    }
}