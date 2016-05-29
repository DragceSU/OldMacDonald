namespace OldMacDonald.BL.Interfaces
{
    #region

    using OldMacDonald.Domain;

    #endregion

    public interface IAnimalManager<T>
        where T : AnimalBase
    {
        string GetAnimals();
    }
}