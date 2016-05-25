namespace OldMacDonald.Core.Interfaces
{
    public interface IAnimal
    {
        AnimalType Type { get; }

        string GetGetAnimalNameAndSound();
    }
}