// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Duck.cs" company="">
// </copyright>
// <summary>
//   The duck.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OldMacDonald.Domain.Animals
{
    #region

    using System;

    #endregion

    /// <summary>
    /// The duck.
    /// </summary>
    public class Duck : AnimalBase
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        public override AnimalTypeEnum Type
        {
            get
            {
                return AnimalTypeEnum.Duck;
            }
        }

        /// <summary>
        /// Gets the animal name.
        /// </summary>
        public override string AnimalName
        {
            get
            {
                return "duck";
            }
        }

        /// <summary>
        /// Gets the animal sound.
        /// </summary>
        public override string AnimalSound
        {
            get
            {
                return "quack";
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