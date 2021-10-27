using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Assignment_1.Data
{
    public interface ITFamilyManager
    {
        Task<IList<Family>> getFamilies();
        Task<IList<Adult>> getAdults();
        Family get(int id);
        void AddAdult(Adult adult, int id);
        void AddPet(Pet pet, int id);
        void AddChild(Child child, int id);
        Task<Family> RemoveFamily(int FamilyId);
        Task<Family> AddFamily(Family family);
        Task<Family> UpdateFamily(Family family);

        Task<List<Family>> UpdateFamilies(List<Family> familiesToUpdate);
    }
}