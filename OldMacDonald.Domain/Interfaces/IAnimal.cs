// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAnimal.cs" company="">
// </copyright>
// <summary>
//   The Animal interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OldMacDonald.Domain.Interfaces
{
    /// <summary>
    /// The Animal interface.
    /// </summary>
    public interface IAnimal
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        AnimalTypeEnum Type { get; }

        /// <summary>
        /// The get get animal name and sound.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string GetGetAnimalNameAndSound();
    }
}