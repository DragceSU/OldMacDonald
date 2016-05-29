// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cow.cs" company="">
// </copyright>
// <summary>
//   The cow.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OldMacDonald.Domain.Animals
{
    #region

    using System;

    #endregion

    /// <summary>
    /// The cow.
    /// </summary>
    public class Cow : AnimalBase
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        public override AnimalTypeEnum Type
        {
            get
            {
                return AnimalTypeEnum.Cow;
            }
        }

        /// <summary>
        /// Gets the animal name.
        /// </summary>
        public override string AnimalName
        {
            get
            {
                return "cow";
            }
        }

        /// <summary>
        /// Gets the animal sound.
        /// </summary>
        public override string AnimalSound
        {
            get
            {
                return "moo";
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