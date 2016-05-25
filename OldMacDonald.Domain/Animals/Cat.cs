#region

using System;

#endregion

namespace OldMacDonald.Core.Animals
{
    public class Cat : AnimalBase
    {
        public override AnimalType Type
        {
            get { return AnimalType.Cat; }
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
            get { return "cat"; }
        }

        public override string AnimalSound
        {
            get { return "meow"; }
        }
    }
}