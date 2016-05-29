// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cat.cs" company="">
// </copyright>
// <summary>
//   The cat.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OldMacDonald.Domain.Animals
{
    #region

    using System;

    #endregion

    /// <summary>
    /// The cat.
    /// </summary>
    public class Cat : AnimalBase
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        public override AnimalTypeEnum Type
        {
            get
            {
                return AnimalTypeEnum.Cat;
            }
        }

        /// <summary>
        /// Gets the animal name.
        /// </summary>
        public override string AnimalName
        {
            get
            {
                return "cat";
            }
        }

        /// <summary>
        /// Gets the animal sound.
        /// </summary>
        public override string AnimalSound
        {
            get
            {
                return "meow";
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