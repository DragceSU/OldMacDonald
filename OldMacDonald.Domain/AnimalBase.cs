// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AnimalBase.cs" company="">
// </copyright>
// <summary>
//   The animal base.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OldMacDonald.Domain
{
    #region

    using System;
    using System.Text;

    using OldMacDonald.Domain.Animals;
    using OldMacDonald.Domain.Interfaces;

    #endregion

   
    public abstract class AnimalBase : IAnimal
    {
       
        protected StringBuilder _verse = Verse.GetDefaultVerse();

       
        private AnimalBase Current
        {
            get
            {
                return this;
            }
        }

       
        public abstract string AnimalName { get; }

     
        public abstract string AnimalSound { get; }

      
        public abstract AnimalTypeEnum Type { get; }

      
        public string GetGetAnimalNameAndSound()
        {
            return this.Current.GetAnimalNameAndSound();
        }

       
        public static AnimalBase AnimalFactory(AnimalTypeEnum animalTypeEnum)
        {
            AnimalBase createAnimal = null;

            switch (animalTypeEnum)
            {
                case AnimalTypeEnum.Cat:
                    createAnimal = new Cat();
                    break;
                case AnimalTypeEnum.Cow:
                    createAnimal = new Cow();
                    break;
                case AnimalTypeEnum.Dog:
                    createAnimal = new Dog();
                    break;
                case AnimalTypeEnum.Duck:
                    createAnimal = new Duck();
                    break;
                case AnimalTypeEnum.Pig:
                    createAnimal = new Pig();
                    break;
            }

            return createAnimal;
        }

       
        public static string GetInternalAnimalNameAndSound(string animal, string sound)
        {
            return GetAnimalNameAndSound(animal, sound);
        }

       
        protected abstract string GetAnimalNameAndSound();

      
        private static string GetAnimalNameAndSound(string animal, string sound)
        {
            return
                Verse.GetDefaultVerse()
                    .Replace("@newLine", Environment.NewLine)
                    .Replace("@animal", animal)
                    .Replace("@sound", sound)
                    .ToString();
        }
    }
}