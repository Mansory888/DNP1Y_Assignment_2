using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models;
using WebApiForFamilies.Persistance;

namespace Assignment_1.Data
{
    public class DBFamilyManager : ITFamilyManager
    {
        private FamilyDBContext context;

        public DBFamilyManager(FamilyDBContext context)
        {
            this.context = context;
        }

        public async Task<IList<Family>> getFamilies()
        {
            return await context.Families.Include(family => family.Adults).ThenInclude(adult => adult.JobTitle)
                .Include(family => family.Children).ThenInclude(child => child.Pets)
                .Include(family => family.Children).ThenInclude(child => child.Interests)
                .Include(family => family.Pets).ToListAsync();
        }

        public Task<IList<Adult>> getAdults()
        {
            throw new System.NotImplementedException();
        }

        public Family get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddAdult(Adult adult, int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddPet(Pet pet, int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddChild(Child child, int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task RemoveFamily(int FamilyId)
        {
            Family toDelete = await context.Families.FirstOrDefaultAsync(f => f.Id == FamilyId);
            if (toDelete != null)
            {
                context.Families.Remove(toDelete);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Family> AddFamily(Family family)
        {
            EntityEntry<Family> newlyAdded = await context.Families.AddAsync(family);
            await context.SaveChangesAsync();
            return newlyAdded.Entity;
        }

        public async Task<Family> UpdateFamily(Family family)
        {
            try
            {
                Family toUpdate = await context.Families.FirstOrDefaultAsync(f => f.Id == family.Id);
                toUpdate.HouseNumber = family.HouseNumber;
                toUpdate.StreetName = family.StreetName;
                toUpdate.Adults = family.Adults;
                toUpdate.Children = family.Children;
                toUpdate.Pets = family.Pets;
                context.Update(toUpdate);
                await context.SaveChangesAsync();
                return toUpdate;
            }
            catch (Exception e)
            {
                throw new Exception($"Did not find family");
            }
            
        }

        public Task<List<Family>> UpdateFamilies(List<Family> familiesToUpdate)
        {
            throw new System.NotImplementedException();
        }
    }
}