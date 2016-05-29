namespace OldMacDonald.MSTests.BL
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Moq;

    using OldMacDonald.BL;
    using OldMacDonald.BL.Interfaces;
    using OldMacDonald.Domain;
    using OldMacDonald.Domain.Animals;

    [TestClass]
    public class AnimalManagerFixture
    {
        private readonly string _originalVerse = "Old MacDonald had a farm, E I E I O,@newLine"
                                                 + "And on his farm he had a @animal, E I E I O.@newLine"
                                                 + "With a @sound @sound here and a @sound @sound there,@newLine"
                                                 + "Here a @sound, there a @sound, ev'rywhere a @sound @sound.@newLine"
                                                 + "Old MacDonald had a farm, E I E I O.@newLine";

        private string _animalName;

        private string _animalSound;

        private Mock<IAnimalManager<AnimalBase>> _originalVerseMOQ;

        private AnimalManager<AnimalBase> animalManager;

        [TestInitialize]
        public void InitializeUnitTests()
        {
            this._animalName = "cat";
            this._animalSound = "meow";
            this._originalVerseMOQ = new Mock<IAnimalManager<AnimalBase>>();
        }

        [TestCleanup]
        public void DestructAllObjects()
        {
            this._animalName = null;
            this._animalSound = null;
            this._originalVerseMOQ = null;
        }

        [TestMethod]
        public void GetAnimalsIsCorrectFixture()
        {
            this._originalVerseMOQ.Setup(manager => manager.GetAnimals()).Returns(this._originalVerse);
            string animal =
                this._originalVerseMOQ.Object.GetAnimals()
                    .Replace("@newLine", Environment.NewLine)
                    .Replace("@animal", this._animalName)
                    .Replace("@sound", this._animalSound);

            string getAnimalFromBase =
                AnimalManager<AnimalBase>.InitializeCustomAnimal(this._animalName, this._animalSound)
                    .Replace("@newLine", Environment.NewLine)
                    .Replace("@animal", this._animalName)
                    .Replace("@sound", this._animalSound);

            Assert.AreEqual(animal, getAnimalFromBase);
        }

        [TestMethod]
        public void InitializeCustomAnimalFixture()
        {
            string managedVerse =
                this._originalVerse.Replace("@newLine", Environment.NewLine)
                    .Replace("@animal", this._animalName)
                    .Replace("@sound", this._animalSound);

            string getAnimalFromBase =
                AnimalManager<AnimalBase>.InitializeCustomAnimal(this._animalName, this._animalSound)
                    .Replace("@newLine", Environment.NewLine)
                    .Replace("@animal", this._animalName)
                    .Replace("@sound", this._animalSound);

            Assert.AreEqual(managedVerse, getAnimalFromBase);
        }

        [TestMethod]
        public void GetAllAnimalsFixture()
        {
            this.animalManager = new AnimalManager<AnimalBase>();

            string getAllAnimals = this.animalManager.GetAnimals();

            Assert.IsTrue(getAllAnimals.Contains(new Cat().GetGetAnimalNameAndSound()));
            Assert.IsTrue(getAllAnimals.Contains(new Dog().GetGetAnimalNameAndSound()));
            Assert.IsTrue(getAllAnimals.Contains(new Cow().GetGetAnimalNameAndSound()));
            Assert.IsTrue(getAllAnimals.Contains(new Duck().GetGetAnimalNameAndSound()));
            Assert.IsTrue(getAllAnimals.Contains(new Pig().GetGetAnimalNameAndSound()));
        }

        [TestMethod]
        public void DoesNotTigerlAnimalsFixture()
        {
            AnimalManager<AnimalBase> animalManager = new AnimalManager<AnimalBase>();

            string getallAnimals = animalManager.GetAnimals();

            Assert.IsFalse(getallAnimals.Contains("tiger"));
        }
    }
}