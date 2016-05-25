namespace OldMacDonald.Domain.Interfaces
{
    public interface IAnimal
    {
        AnimalType Type { get; }
        string GetGetAnimalNameAndSound();
    }
}