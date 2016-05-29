using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald.NUnitTests.BL
{
    using Moq;

    using NUnit.Framework;

    using OldMacDonald.BL;
    using OldMacDonald.BL.Interfaces;
    using OldMacDonald.Domain;
    using OldMacDonald.Domain.Animals;

    [TestFixture]
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

        [SetUp]
        public void InitializeUnitTests()
        {
            _animalName = "cat";
            _animalSound = "meow";
            _originalVerseMOQ = new Mock<IAnimalManager<AnimalBase>>();
        }

        [TearDown]
        public void DestructAllObjects()
        {
            _animalName = null;
            _animalSound = null;
            _originalVerseMOQ = null;
        }

        [Test]
        public void GetAnimalsIsCorrectFixture()
        {
            _originalVerseMOQ.Setup(manager => manager.GetAnimals()).Returns(_originalVerse);
            string animal = _originalVerseMOQ.Object.GetAnimals().Replace("@newLine", Environment.NewLine)
                .Replace("@animal", _animalName)
                .Replace("@sound", _animalSound);

            string getAnimalFromBase = AnimalManager<AnimalBase>.InitializeCustomAnimal(_animalName, _animalSound).Replace("@newLine", Environment.NewLine)
                .Replace("@animal", _animalName)
                .Replace("@sound", _animalSound);

            Assert.That(animal, Is.EqualTo(getAnimalFromBase));
        }

        [Test]
        public void InitializeCustomAnimalFixture()
        {
            string managedVerse = _originalVerse.Replace("@newLine", Environment.NewLine)
                .Replace("@animal", _animalName)
                .Replace("@sound", _animalSound);

            string getAnimalFromBase = AnimalManager<AnimalBase>.InitializeCustomAnimal(_animalName, _animalSound).Replace("@newLine", Environment.NewLine)
                .Replace("@animal", _animalName)
                .Replace("@sound", _animalSound);

            Assert.That(managedVerse, Is.EqualTo(getAnimalFromBase));
        }

        [Test]
        public void GetAllAnimalsFixture()
        {
            animalManager = new AnimalManager<AnimalBase>();

            string getAllAnimals = animalManager.GetAnimals();

            Assert.That(getAllAnimals, Contains.Substring(new Cat().GetGetAnimalNameAndSound()));
            Assert.That(getAllAnimals, Contains.Substring((new Dog().GetGetAnimalNameAndSound())));
            Assert.That(getAllAnimals, Contains.Substring((new Cow().GetGetAnimalNameAndSound())));
            Assert.That(getAllAnimals, Contains.Substring((new Duck().GetGetAnimalNameAndSound())));
            Assert.That(getAllAnimals, Contains.Substring((new Pig().GetGetAnimalNameAndSound())));
        }

        [Test]
        public void DoesNotTigerlAnimalsFixture()
        {
            AnimalManager<AnimalBase> animalManager = new AnimalManager<AnimalBase>();

            _originalVerseMOQ.Setup(p => p.GetAnimals()).Returns(_originalVerse);

            string getallAnimals = _originalVerseMOQ.Object.GetAnimals();

            Assert.That(getallAnimals, !Contains.Substring("tiger"));
        }
    }
}
