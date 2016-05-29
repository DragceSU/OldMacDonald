namespace OldMacDonald.BL
{
    #region

    using System;
    using System.Text;

    using OldMacDonald.BL.Interfaces;
    using OldMacDonald.Domain;

    #endregion

    public class AnimalManager<T> : IAnimalManager<T>
        where T : AnimalBase
    {
        public string GetAnimals()
        {
            var initializeAnimalCounter = 0;
            var textToBeReturned = new StringBuilder();

            while (true)
            {
                AnimalTypeEnum type;
                if (!Enum.TryParse(initializeAnimalCounter.ToString(), false, out type))
                {
                    continue;
                }

                if (Enum.IsDefined(typeof(AnimalTypeEnum), type))
                {
                    textToBeReturned.Append(InitializeAnimal(type).GetGetAnimalNameAndSound());

                    initializeAnimalCounter++;
                }
                else
                {
                    break;
                }
            }

            return textToBeReturned.ToString();
        }

        private static T InitializeAnimal(AnimalTypeEnum type)
        {
            T animalObject = null;
            switch (type)
            {
                case AnimalTypeEnum.Cow:
                    animalObject = AnimalBase.AnimalFactory(type) as T;
                    break;
                case AnimalTypeEnum.Dog:
                    animalObject = AnimalBase.AnimalFactory(type) as T;
                    break;
                case AnimalTypeEnum.Cat:
                    animalObject = AnimalBase.AnimalFactory(type) as T;
                    break;
                case AnimalTypeEnum.Pig:
                    animalObject = AnimalBase.AnimalFactory(type) as T;
                    break;
                case AnimalTypeEnum.Duck:
                    animalObject = AnimalBase.AnimalFactory(type) as T;
                    break;
            }

            return animalObject;
        }

        public static string InitializeCustomAnimal(string animalName, string animalSound)
        {
            return AnimalBase.GetInternalAnimalNameAndSound(animalName, animalSound);
        }
    }
}