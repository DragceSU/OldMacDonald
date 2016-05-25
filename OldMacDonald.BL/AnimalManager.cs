#region

using System;
using OldMacDonald.Domain;
using OldMacDonald.Domain.Animals;
using OldMacDonald.Interfaces.BL;

#endregion

namespace OldMacDonald.BL
{
    public class AnimalManager<T> : IAnimalManager<T> where T : AnimalBase
    {
        public void GetAnimals(AnimalManager<AnimalBase> manager)
        {
            GetAllAnimalsAndWriteToScreen(manager);
        }

        private static void GetAllAnimalsAndWriteToScreen(AnimalManager<AnimalBase> manager)
        {
            var initinitializeAnimalCounter = 0;
            while (true)
            {
                AnimalType type;
                if (!Enum.TryParse(initinitializeAnimalCounter.ToString(), false, out type)) continue;
                if (Enum.IsDefined(typeof(AnimalType), type))
                {
                    Console.WriteLine(manager.InitializeAnimal(type).GetGetAnimalNameAndSound());
                    initinitializeAnimalCounter++;
                }
                else
                    break;
            }
        }

        private T InitializeAnimal(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Dog:
                    return new Dog() as T;
                case AnimalType.Pig:
                    return new Pig() as T;
                case AnimalType.Cat:
                    return new Cat() as T;
                case AnimalType.Cow:
                    return new Cow() as T;
                case AnimalType.Duck:
                    return new Duck() as T;
            }
            return null;
        }

        public string InitializeCustomAnimal(string animalName, string animalSound)
        {
            return AnimalBase.GetInternalAnimalNameAndSound(animalName, animalSound);
        }
    }
}