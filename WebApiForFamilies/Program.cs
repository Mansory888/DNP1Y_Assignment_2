using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment_1.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;
using WebApiForFamilies.Persistance;

namespace WebApiForFamilies
{
    public class Program
    {
        private static ITFamilyManager _familyManager = new FamilyManager();
        
        public static void Main(string[] args)
        {
            using (FamilyDBContext todoContext = new FamilyDBContext())
            {
                Seed(todoContext);
            }
            
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
        
        
        private static async Task Seed(FamilyDBContext context)
        {
            // List<Family> families = new List<Family>();
            // string content = File.ReadAllText("families.json");
            // families = JsonSerializer.Deserialize<List<Family>>(content);
            //
            // foreach (Family family in families)
            // {
            //     context.Families.Add(family);
            // }
            //
            // context.SaveChangesAsync();
            
            
            // Family test = new Family()
            // {
            //     HouseNumber = 777,
            //     StreetName = "test",
            //     Adults = new List<Adult>(),
            //     Children = new List<Child>(),
            //     Id = 999,
            //     Pets = new List<Pet>()
            // };
            //
            // Adult testAdult = new Adult()
            // {
            //     Age = 50,
            //     FirstName = "a",
            //     LastName = "b",
            //     EyeColor = "fff",
            //     HairColor = "aaa",
            //     Height = 12,
            //     Id = 5,
            //     Sex = "m",
            //     Weight = 50,
            // }; 
            // test.Adults.Add(testAdult);
            //
            // context.Families.AddAsync(test);
            // context.SaveChangesAsync();
        }
        
    }
    
    
}