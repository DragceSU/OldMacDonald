#region

using System;

#endregion

namespace OldMacDonald.Core.Animals
{
    public class Cow : AnimalBase
    {
        public override AnimalType Type
        {
            get { return AnimalType.Cow; }
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
            get { return "cow"; }
        }

        public override string AnimalSound
        {
            get { return "moo"; }
        }
    }
}