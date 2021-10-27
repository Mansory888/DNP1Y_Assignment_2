using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Assignment_1.Data
{
    public interface ITFamilyManager
    {
        IList<Family> getFamilies();
        IList<Adult> getAdults();
        Family get(int id);
        void AddAdult(Adult adult, int id);
        void AddPet(Pet pet, int id);
        void AddChild(Child child, int id);
        void RemoveFamily(int FamilyId);
        void AddFamily(Family family);
       
    }
}