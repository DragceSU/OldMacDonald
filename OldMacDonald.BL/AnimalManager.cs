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
            var initializeAnimalCounter = 0;
            var textToBeReturned = new StringBuilder();
            while (true)
            {
                AnimalType type;
                if (!Enum.TryParse(initializeAnimalCounter.ToString(), false, out type)) continue;
                if (Enum.IsDefined(typeof(AnimalType), type))
                {
                    textToBeReturned.Append(InitializeAnimal(type).GetGetAnimalNameAndSound());
                    initializeAnimalCounter++;
                }
                else
                    break;
            }
            return textToBeReturned.ToString();
        }

        private static T InitializeAnimal(AnimalType type)
        {
            T animalObject = null;
            switch (type)
            {
                case AnimalType.Cow:
                    animalObject = new Cow() as T;
                    break;
                case AnimalType.Dog:
                    animalObject = new Dog() as T;
                    break;
                case AnimalType.Cat:
                    animalObject = new Cat() as T;
                    break;
                case AnimalType.Pig:
                    animalObject = new Pig() as T;
                    break;
                case AnimalType.Duck:
                    animalObject = new Duck() as T;
                    break;
            }

            return animalObject;
        }

        public static string InitializeCustomAnimal(string animalName, string animalSound)
        {
            return AnimalBase.GetInternalAnimalNameAndSound(animalName, animalSound);
        }
    }
}