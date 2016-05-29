#region

using System;

#endregion

namespace OldMacDonald.Domain.Animals
{
    public class Cat : AnimalBase
    {
        public override AnimalTypeEnum Type
        {
            get { return AnimalTypeEnum.Cat; }
        }

        public override string AnimalName
        {
            get { return "cat"; }
        }

        public override string AnimalSound
        {
            get { return "meow"; }
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