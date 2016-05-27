﻿//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OldMacDonald.Domain;
//using OldMacDonald.Domain.Animals;

//namespace OldMacDonald.Tests.Core
//{
//    using OldMacDonald.BL;

//    [TestClass]
//    public class DomainFixture
//    {
//        private Cat _cat;
//        private Dog _dog;
//        private Pig _pig;
//        private Cow _cow;
//        private Duck _duck;

//        private AnimalManager<AnimalBase> animalManager;

//        [TestMethod]
//        public void AssertCatObjectConstuctionFixture()
//        {
//            _cat = new Cat();

//            Assert.AreEqual(AnimalType.Cat, _cat.Type);
//            Assert.AreEqual("cat", _cat.AnimalName);
//            Assert.AreEqual("meow", _cat.AnimalSound);
//        }

//        [TestMethod]
//        public void AssertDogObjectConstuctionFixture()
//        {
//            _dog = new Dog();

//            Assert.AreEqual(AnimalType.Dog, _dog.Type);
//            Assert.AreEqual("dog", _dog.AnimalName);
//            Assert.AreEqual("woof", _dog.AnimalSound);
//        }

//        [TestMethod]
//        public void AssertCowObjectConstuctionFixture()
//        {
//            _cow = new Cow();
//            animalManager = new AnimalManager<AnimalBase>();

//            Assert.AreEqual(AnimalType.Cow, _cow.Type);
//            Assert.AreEqual("cow", _cow.AnimalName);
//            Assert.AreEqual("moo", _cow.AnimalSound);
//            Assert.IsTrue(animalManager.GetAnimals().Contains(_cow.GetGetAnimalNameAndSound()));
//        }

//        [TestMethod]
//        public void AssertDuckObjectConstuctionFixture()
//        {
//            _duck = new Duck();

//            Assert.AreEqual(AnimalType.Duck, _duck.Type);
//            Assert.AreEqual("duck", _duck.AnimalName);
//            Assert.AreEqual("quack", _duck.AnimalSound);
//        }

//        [TestMethod]
//        public void AssertPigObjectConstuctionFixture()
//        {
//            _pig = new Pig();

//            Assert.AreEqual(AnimalType.Pig, _pig.Type);
//            Assert.AreEqual("pig", _pig.AnimalName);
//            Assert.AreEqual("oink", _pig.AnimalSound);
//        }

//        [TestMethod]
//        public void AllAnimalsAreDifferentFixture()
//        {
//            _dog = new Dog();
//            _cat = new Cat();
//            _cow = new Cow();
//            _duck = new Duck();
//            _pig = new Pig();

//            Assert.AreNotEqual(_dog.Type, _cat.Type);
//            Assert.AreNotEqual(_dog.AnimalName, _cat.AnimalName);
//            Assert.AreNotEqual(_dog.AnimalSound, _cat.AnimalSound);

//            Assert.AreNotEqual(_cow.Type, _cat.Type);
//            Assert.AreNotEqual(_cow.AnimalName, _cat.AnimalName);
//            Assert.AreNotEqual(_cow.AnimalSound, _cat.AnimalSound);

//            Assert.AreNotEqual(_duck.Type, _cow.Type);
//            Assert.AreNotEqual(_duck.AnimalName, _cow.AnimalName);
//            Assert.AreNotEqual(_duck.AnimalSound, _cow.AnimalSound);

//            Assert.AreNotEqual(_pig.Type, _duck.Type);
//            Assert.AreNotEqual(_pig.AnimalName, _duck.AnimalName);
//            Assert.AreNotEqual(_pig.AnimalSound, _duck.AnimalSound);
//        }
//    }
//}

