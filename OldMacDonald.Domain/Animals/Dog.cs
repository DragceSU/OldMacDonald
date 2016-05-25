#region

using System;

#endregion

namespace OldMacDonald.Core.Animals
{
    public class Dog : AnimalBase
    {
        public override AnimalType Type
        {
            get { return AnimalType.Dog; }
        }

        protected override string GetAnimalNameAndSound()
        {
            return _verse.Replace("@newLine", Environment.NewLine)
                .Replace("@animal", AnimalName)
                .Replace("@sound", AnimalSound)
                .ToString();
        }

        public override string AnimalName
        {
            get { return "dog"; }
        }

        public override string AnimalSound
        {
            get { return "woof"; }
        }
    }
}