using Assignment_1.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace WebApiForFamilies.Persistance
{
    public class FamilyDBContext : DbContext
    {
        public DbSet<Family> Families { get; set; }
        public DbSet<Adult> Adults { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Interest> Interests { get; set; }
        
        public DbSet<User> Users { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // name of database
            optionsBuilder.UseSqlite("Data Source = users.db");
        }

    }
}