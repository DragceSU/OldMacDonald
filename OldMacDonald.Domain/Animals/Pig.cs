// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pig.cs" company="">
// </copyright>
// <summary>
//   The pig.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OldMacDonald.Domain.Animals
{
    #region

    using System;

    #endregion

  
    public class Pig : AnimalBase
    {
        public override AnimalTypeEnum Type
        {
            get
            {
                return AnimalTypeEnum.Pig;
            }
        }

      
        public override string AnimalName
        {
            get
            {
                return "pig";
            }
        }

      
        public override string AnimalSound
        {
            get
            {
                return "oink";
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