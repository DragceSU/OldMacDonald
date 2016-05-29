// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pig.cs" company="">
// </copyright>
// <summary>
//   The pig.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OldMacDonald.Domain.Animals
{
    #region

    using System;

    #endregion

    /// <summary>
    /// The pig.
    /// </summary>
    public class Pig : AnimalBase
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        public override AnimalTypeEnum Type
        {
            get
            {
                return AnimalTypeEnum.Pig;
            }
        }

        /// <summary>
        /// Gets the animal name.
        /// </summary>
        public override string AnimalName
        {
            get
            {
                return "pig";
            }
        }

        /// <summary>
        /// Gets the animal sound.
        /// </summary>
        public override string AnimalSound
        {
            get
            {
                return "oink";
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