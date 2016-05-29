#region

using System;

#endregion

namespace OldMacDonald.Domain.Animals
{
    public class Cow : AnimalBase
    {
        public override AnimalTypeEnum Type
        {
            get { return AnimalTypeEnum.Cow; }
        }

        public override string AnimalName
        {
            get { return "cow"; }
        }

        public override string AnimalSound
        {
            get { return "moo"; }
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