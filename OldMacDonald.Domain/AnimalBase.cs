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

    /// <summary>
    /// The animal base.
    /// </summary>
    public abstract class AnimalBase : IAnimal
    {
        /// <summary>
        /// The _verse.
        /// </summary>
        protected StringBuilder _verse = Verse.GetDefaultVerse();

        /// <summary>
        /// Gets the current.
        /// </summary>
        private AnimalBase Current
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// Gets the animal name.
        /// </summary>
        public abstract string AnimalName { get; }

        /// <summary>
        /// Gets the animal sound.
        /// </summary>
        public abstract string AnimalSound { get; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        public abstract AnimalTypeEnum Type { get; }

        /// <summary>
        /// The get get animal name and sound.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetGetAnimalNameAndSound()
        {
            return this.Current.GetAnimalNameAndSound();
        }

        /// <summary>
        /// The animal factory.
        /// </summary>
        /// <param name="animalTypeEnum">
        /// The animal type enum.
        /// </param>
        /// <returns>
        /// The <see cref="AnimalBase"/>.
        /// </returns>
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

        /// <summary>
        /// The get internal animal name and sound.
        /// </summary>
        /// <param name="animal">
        /// The animal.
        /// </param>
        /// <param name="sound">
        /// The sound.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetInternalAnimalNameAndSound(string animal, string sound)
        {
            return GetAnimalNameAndSound(animal, sound);
        }

        /// <summary>
        /// The get animal name and sound.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        protected abstract string GetAnimalNameAndSound();

        /// <summary>
        /// The get animal name and sound.
        /// </summary>
        /// <param name="animal">
        /// The animal.
        /// </param>
        /// <param name="sound">
        /// The sound.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
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