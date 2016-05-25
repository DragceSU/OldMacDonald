#region

using System;
using System.Text;
using OldMacDonald.Core.Interfaces;

#endregion

namespace OldMacDonald.Core
{
    public abstract class AnimalBase : IAnimal
    {
        protected StringBuilder _verse = Verse.GetDefaultVerse();

        private AnimalBase Current
        {
            get { return this; }
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

        protected static string GetAnimalNameAndSound(string animal, string sound)
        {
            return Verse.GetDefaultVerse().Replace("@newLine", Environment.NewLine)
                .Replace("@animal", animal)
                .Replace("@sound", sound)
                .ToString();
        }
    }
}