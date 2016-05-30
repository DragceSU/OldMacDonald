// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cat.cs" company="">
// </copyright>
// <summary>
//   The cat.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace OldMacDonald.Domain.Animals
{
    #region

    using System;

    #endregion

   
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