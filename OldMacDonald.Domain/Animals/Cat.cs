namespace OldMacDonald.Domain.Animals
{
    using System;

    public class Cat : AnimalBase
    {
        public override AnimalTypeEnum Type
        {
            get
            {
                return AnimalTypeEnum.Cat;
            }
        }

        public override string AnimalName
        {
            get
            {
                return "cat";
            }
        }

        public override string AnimalSound
        {
            get
            {
                return "meow";
            }
        }

        protected override string GetAnimalNameAndSound()
        {
            return
                this._verse.Replace("@newLine", Environment.NewLine)
                    .Replace("@animal", this.AnimalName)
                    .Replace("@sound", this.AnimalSound)
                    .ToString();
        }
    }
}