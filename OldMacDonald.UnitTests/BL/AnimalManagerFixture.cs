namespace OldMacDonald.NUnitTests.BL
{
    #region

    using System;

    using Moq;

    using NUnit.Framework;

    using OldMacDonald.BL;
    using OldMacDonald.BL.Interfaces;
    using OldMacDonald.Domain;

    #endregion

    [TestFixture]
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

        [SetUp]
        public void InitializeUnitTests()
        {
            this._animalName = "cat";
            this._animalSound = "meow";
            this._originalVerseMOQ = new Mock<IAnimalManager<AnimalBase>>();
        }

        [TearDown]
        public void DestructAllObjects()
        {
            this._animalName = null;
            this._animalSound = null;
            this._originalVerseMOQ = null;
        }

        [Test]
        [MaxTime(500)]
        public void ShouldGetAnimalsFromInitializeCustomAnimalMethod()
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

            Assert.That(managedVerse, Is.EqualTo(getAnimalFromBase));
        }

        //[Test]
        //[MaxTime(500)]
        //public void ShouldGetAnimalsIsCorrectly()
        //{
        //    this._originalVerseMOQ.Setup(manager => manager.GetAnimals()).Returns(this._originalVerse);
        //    string animal =
        //        this._originalVerseMOQ.Object.GetAnimals()
        //            .Replace("@newLine", Environment.NewLine)
        //            .Replace("@animal", this._animalName)
        //            .Replace("@sound", this._animalSound);

        //    string getAnimalFromBase =
        //        AnimalManager<AnimalBase>.InitializeCustomAnimal(this._animalName, this._animalSound)
        //            .Replace("@newLine", Environment.NewLine)
        //            .Replace("@animal", this._animalName)
        //            .Replace("@sound", this._animalSound);

        //    Assert.That(animal, Is.EqualTo(getAnimalFromBase));
        //}

        //[Test]
        //[MaxTime(500)]
        //public void TigerShouldNotBelongToAnimals()
        //{
        //    AnimalManager<AnimalBase> animalManager = new AnimalManager<AnimalBase>();

        //    this._originalVerseMOQ.Setup(p => p.GetAnimals()).Returns(this._originalVerse);

        //    string getallAnimals = this._originalVerseMOQ.Object.GetAnimals();

        //    Assert.That(getallAnimals, !Contains.Substring("tiger"));
        //}
    }
}