namespace OldMacDonald.BL.Interfaces
{
    using OldMacDonald.Domain;

    public interface IAnimalManager<T>
        where T : AnimalBase
    {
        string GetAnimals();
    }
}