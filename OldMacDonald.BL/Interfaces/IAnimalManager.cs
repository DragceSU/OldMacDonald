#region

using OldMacDonald.BL;
using OldMacDonald.Core;

#endregion

namespace OldMacDonald.Interfaces.BL
{
    public interface IAnimalManager<T> where T : AnimalBase
    {
        //T InitializeAnimal(AnimalType type);
        void GetAnimals(AnimalManager<AnimalBase> manager);
    }
}