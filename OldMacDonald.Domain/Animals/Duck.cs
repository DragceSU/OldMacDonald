#region

using System;

#endregion

namespace OldMacDonald.Core.Animals
{
    public class Duck : AnimalBase
    {
        public override AnimalType Type
        {
            get { return AnimalType.Duck; }
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
            get { return "duck"; }
        }

        public override string AnimalSound
        {
            get { return "quack"; }
        }
    }
}