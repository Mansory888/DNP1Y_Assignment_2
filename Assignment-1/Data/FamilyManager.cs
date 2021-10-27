using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace Assignment_1.Data
{
    public class FamilyManager 
    {
        private string DataFile = "families.json";
        private List<Family> families;

        public FamilyManager()
        {
            if (!File.Exists(DataFile))
            {
                Console.WriteLine("File does not exist");
            }
            else
            {
                string content = File.ReadAllText(DataFile);
                families = JsonSerializer.Deserialize<List<Family>>(content);
            }
        }

        public IList<Family> getFamilies()
        {
            List<Family> fam = new List<Family>(families);
            return fam;
        }

        public IList<Adult> getAdults()
        {
            List<Adult> adults = new List<Adult>();

            foreach (var family in families)
            {
                adults.AddRange(family.Adults);
            }
            
            return adults;
        }

        public Family get(int id)
        {
            return families.FirstOrDefault(f=>f.Id == id);
        }

        public void AddAdult(Adult adult, int FamilyId)
        {
            foreach (var family in families)
            {
                if (family.Id == FamilyId)
                {
                    family.Adults.Add(adult);
                }
            }
            WriteToFile();
        }
        
        public void AddPet(Pet pet, int FamilyId)
        {
            foreach (var family in families)
            {
                if (family.Id == FamilyId)
                {
                    family.Pets.Add(pet);
                }
            }
            WriteToFile();
        }
        
        public void AddChild(Child child, int FamilyId)
        {
            foreach (var family in families)
            {
                if (family.Id == FamilyId)
                {
                    family.Children.Add(child);
                }
            }
            WriteToFile();
        }

        public void RemoveFamily(int FamilyId)
        {
            foreach (var family in families.ToList())
            {
                if (family.Id == FamilyId)
                {
                    families.Remove(family);
                }
            }
            WriteToFile();
        }

        public void AddFamily(Family family)
        {
            families.Add(family);
        }
        
        private void WriteToFile()
        {
            string familyAsJson = JsonSerializer.Serialize(families);
            File.WriteAllText(DataFile, familyAsJson);
        }
    }
}