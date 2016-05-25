#region

using OldMacDonald.BL;
using OldMacDonald.Domain;

#endregion

namespace OldMacDonald.Interfaces.BL
{
    public interface IAnimalManager<T> where T : AnimalBase
    {
        void GetAnimals(AnimalManager<AnimalBase> manager);
    }
}