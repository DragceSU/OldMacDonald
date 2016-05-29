namespace OldMacDonald.Domain.Animals
{
    #region

    using System;

    #endregion

    public class Dog : AnimalBase
    {
        public override AnimalTypeEnum Type
        {
            get
            {
                return AnimalTypeEnum.Dog;
            }
        }

        public override string AnimalName
        {
            get
            {
                return "dog";
            }
        }

        public override string AnimalSound
        {
            get
            {
                return "woof";
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