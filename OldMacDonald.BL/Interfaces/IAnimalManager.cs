#region

using OldMacDonald.Domain;

#endregion

namespace OldMacDonald.BL.Interfaces
{
    public interface IAnimalManager<T> where T : AnimalBase
    {
        string GetAnimals();
    }
}