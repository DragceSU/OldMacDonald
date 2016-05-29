// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Dog.cs" company="">
// </copyright>
// <summary>
//   The dog.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OldMacDonald.Domain.Animals
{
    #region

    using System;

    #endregion

    /// <summary>
    /// The dog.
    /// </summary>
    public class Dog : AnimalBase
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        public override AnimalTypeEnum Type
        {
            get
            {
                return AnimalTypeEnum.Dog;
            }
        }

        /// <summary>
        /// Gets the animal name.
        /// </summary>
        public override string AnimalName
        {
            get
            {
                return "dog";
            }
        }

        /// <summary>
        /// Gets the animal sound.
        /// </summary>
        public override string AnimalSound
        {
            get
            {
                return "woof";
            }
        }

        /// <summary>
        /// The get animal name and sound.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        protected override string GetAnimalNameAndSound()
        {
            return
                this._verse.Replace("@newLine", Environment.NewLine)
                    .Replace("@animal", this.AnimalName)
                    .Replace("@sound", this.AnimalSound)
                    .ToString();
        }
    }
}