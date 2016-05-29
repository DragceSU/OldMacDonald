namespace OldMacDonald.Domain.Animals
{
    #region

    using System;

    #endregion

    public class Cow : AnimalBase
    {
        public override AnimalTypeEnum Type
        {
            get
            {
                return AnimalTypeEnum.Cow;
            }
        }

        public override string AnimalName
        {
            get
            {
                return "cow";
            }
        }

        public override string AnimalSound
        {
            get
            {
                return "moo";
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