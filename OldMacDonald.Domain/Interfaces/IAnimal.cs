
namespace OldMacDonald.Domain.Interfaces
{
  
    public interface IAnimal
    {
       
        AnimalTypeEnum Type { get; }

       
        string GetGetAnimalNameAndSound();
    }
}