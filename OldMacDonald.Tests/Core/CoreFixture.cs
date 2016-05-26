using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OldMacDonald.Domain;
using OldMacDonald.Domain.Animals;

namespace OldMacDonald.Tests.Core
{
    [TestClass]
    public class CoreFixture
    {
        private Cat _cat;
        private Dog _dog;

        [TestMethod]
        public void AssertCatObjectConstuctionFixture()
        {
            _cat = new Cat();

            Assert.AreEqual(AnimalType.Cat, _cat.Type);
            Assert.AreEqual("cat", _cat.AnimalName);
            Assert.AreEqual("meow", _cat.AnimalSound);
        }

        [TestMethod]
        public void AssertDogObjectConstuctionFixture()
        {
            _dog = new Dog();

            Assert.AreEqual(AnimalType.Dog, _dog.Type);
            Assert.AreEqual("dog", _dog.AnimalName);
            Assert.AreEqual("woof", _dog.AnimalSound);
        }

        [TestMethod]
        public void DogAndCatAreDifferentFixture()
        {
            _dog = new Dog();
            _cat = new Cat();

            Assert.AreNotEqual(_dog.Type, _cat.Type);
            Assert.AreNotEqual(_dog.AnimalName, _cat.AnimalName);
            Assert.AreNotEqual(_dog.AnimalSound, _cat.AnimalSound);
        }
    }
}

