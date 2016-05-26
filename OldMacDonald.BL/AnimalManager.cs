#region

using System;
using System.Text;
using OldMacDonald.BL.Interfaces;
using OldMacDonald.Domain;
using OldMacDonald.Domain.Animals;

#endregion

namespace OldMacDonald.BL
{
    public class AnimalManager<T> : IAnimalManager<T> where T : AnimalBase
    {
        public string GetAnimals()
        {
            var initinitializeAnimalCounter = 0;
            StringBuilder textToBeReturned = new StringBuilder();
            while (true)
            {
                AnimalType type;
                if (!Enum.TryParse(initinitializeAnimalCounter.ToString(), false, out type)) continue;
                if (Enum.IsDefined(typeof(AnimalType), type))
                {
                    textToBeReturned.Append(InitializeAnimal(type).GetGetAnimalNameAndSound());
                    initinitializeAnimalCounter++;
                }
                else
                    break;
            }
            return textToBeReturned.ToString();
        }

        private static T InitializeAnimal(AnimalType type)
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

        public static string InitializeCustomAnimal(string animalName, string animalSound)
        {
            return AnimalBase.GetInternalAnimalNameAndSound(animalName, animalSound);
        }
    }
}