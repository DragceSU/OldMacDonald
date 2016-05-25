#region

using System;

#endregion

namespace OldMacDonald.Core.Animals
{
    public class Pig : AnimalBase
    {
        public override AnimalType Type
        {
            get { return AnimalType.Pig; }
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
            get { return "pig"; }
        }

        public override string AnimalSound
        {
            get { return "oink"; }
        }
    }
}