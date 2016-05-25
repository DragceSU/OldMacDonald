#region

using System;

#endregion

namespace OldMacDonald.Domain.Animals
{
    public class Duck : AnimalBase
    {
        public override AnimalType Type
        {
            get { return AnimalType.Duck; }
        }

        public override string AnimalName
        {
            get { return "duck"; }
        }

        public override string AnimalSound
        {
            get { return "quack"; }
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