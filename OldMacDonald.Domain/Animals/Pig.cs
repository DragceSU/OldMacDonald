#region

using System;

#endregion

namespace OldMacDonald.Domain.Animals
{
    public class Pig : AnimalBase
    {
        public override AnimalType Type
        {
            get { return AnimalType.Pig; }
        }

        public override string AnimalName
        {
            get { return "pig"; }
        }

        public override string AnimalSound
        {
            get { return "oink"; }
        }

        protected override string GetAnimalNameAndSound()
        {
            return _verse.Replace("@newLine", Environment.NewLine)
                .Replace("@animal", AnimalName)
                .Replace("@sound", AnimalSound)
                .ToString();
        }
    }
}