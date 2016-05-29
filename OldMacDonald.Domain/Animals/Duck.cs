﻿namespace OldMacDonald.Domain.Animals
{
    using System;

    public class Duck : AnimalBase
    {
        public override AnimalTypeEnum Type
        {
            get
            {
                return AnimalTypeEnum.Duck;
            }
        }

        public override string AnimalName
        {
            get
            {
                return "duck";
            }
        }

        public override string AnimalSound
        {
            get
            {
                return "quack";
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