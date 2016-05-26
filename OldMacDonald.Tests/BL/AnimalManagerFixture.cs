#region

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OldMacDonald.BL;
using OldMacDonald.BL.Interfaces;
using OldMacDonald.Domain;
using OldMacDonald.Domain.Animals;

#endregion

namespace OldMacDonald.Tests.BL
{
    [TestClass]
    public class AnimalManagerFixture
    {
        private readonly string _originalVerse = "Old MacDonald had a farm, E I E I O,@newLine" +
                                                 "And on his farm he had a @animal, E I E I O.@newLine" +
                                                 "With a @sound @sound here and a @sound @sound there,@newLine" +
                                                 "Here a @sound, there a @sound, ev'rywhere a @sound @sound.@newLine" +
                                                 "Old MacDonald had a farm, E I E I O.@newLine";

        private string _animalName;
        private string _animalSound;
        private Mock<IAnimalManager<AnimalBase>> _originalVerseMOQ;
        private AnimalManager<AnimalBase> animalManager;

        private void InitializeUnitTests()
        {
            _animalName = "cat";
            _animalSound = "meow";
            _originalVerseMOQ = new Mock<IAnimalManager<AnimalBase>>();
        }

        [TestMethod]
        public void GetAnimalsIsCorrectFixture()
        {
            InitializeUnitTests();
            _originalVerseMOQ.Setup(manager => manager.GetAnimals()).Returns(_originalVerse);
            string animal = _originalVerseMOQ.Object.GetAnimals().Replace("@newLine", Environment.NewLine)
                .Replace("@animal", _animalName)
                .Replace("@sound", _animalSound);

            string getAnimalFromBase = AnimalManager<AnimalBase>.InitializeCustomAnimal(_animalName, _animalSound).Replace("@newLine", Environment.NewLine)
                .Replace("@animal", _animalName)
                .Replace("@sound", _animalSound);

            Assert.AreEqual(animal, getAnimalFromBase);
        }

        [TestMethod]
        public void InitializeCustomAnimalFixture()
        {
            string managedVerse = _originalVerse.Replace("@newLine", Environment.NewLine)
                .Replace("@animal", _animalName)
                .Replace("@sound", _animalSound);

            string getAnimalFromBase = AnimalManager<AnimalBase>.InitializeCustomAnimal(_animalName, _animalSound).Replace("@newLine", Environment.NewLine)
                .Replace("@animal", _animalName)
                .Replace("@sound", _animalSound);

            Assert.AreEqual(managedVerse, getAnimalFromBase);
        }

        [TestMethod]
        public void GetAllAnimalsFixture()
        {
            animalManager = new AnimalManager<AnimalBase>();

            string getAllAnimals = animalManager.GetAnimals();

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