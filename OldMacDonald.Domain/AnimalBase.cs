#region

using System;
using System.Text;
using OldMacDonald.Domain.Interfaces;

#endregion

namespace OldMacDonald.Domain
{


    using OldMacDonald.Domain.Animals;

    public abstract class AnimalBase : IAnimal
    {
        protected StringBuilder _verse = Verse.GetDefaultVerse();

        private AnimalBase Current
        {
            get { return this; }
        }

        public static AnimalBase AnimalFactory(AnimalType animalType)
        {
            AnimalBase createAnimal;

            switch (animalType)
            {
                case AnimalType.Cat:
                    createAnimal = new Cat();
                    break;
                case AnimalType.Cow:
                    createAnimal = new Cow();
                    break;
                case AnimalType.Dog:
                    createAnimal = new Dog();
                    break;
                case AnimalType.Duck:
                    createAnimal = new Duck();
                    break;
                case AnimalType.Pig:
                    createAnimal = new Pig();
                    break;
                default:
                    createAnimal = null;
                    break;
            }

            return createAnimal;
        }

        public abstract string AnimalName { get; }
        public abstract string AnimalSound { get; }
        public abstract AnimalType Type { get; }

        public string GetGetAnimalNameAndSound()
        {
            return Current.GetAnimalNameAndSound();
        }

        public static string GetInternalAnimalNameAndSound(string animal, string sound)
        {
            return GetAnimalNameAndSound(animal, sound);
        }

        protected abstract string GetAnimalNameAndSound();

        public static string GetAnimalNameAndSound(string animal, string sound)
        {
            return Verse.GetDefaultVerse().Replace("@newLine", Environment.NewLine)
                .Replace("@animal", animal)
                .Replace("@sound", sound)
                .ToString();
        }
    }
}