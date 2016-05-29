namespace OldMacDonald.Tests.MSTests
{
    #region

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OldMacDonald.BL;
    using OldMacDonald.Domain;
    using OldMacDonald.Domain.Animals;

    #endregion

    [TestClass]
    public class DomainFixture
    {
        private Cat _cat;

        private Cow _cow;

        private Dog _dog;

        private Duck _duck;

        private Pig _pig;

        private AnimalManager<AnimalBase> animalManager;

        [TestMethod]
        public void AssertCatObjectConstuctionFixture()
        {
            this._cat = new Cat();

            Assert.AreEqual(AnimalTypeEnum.Cat, this._cat.Type);
            Assert.AreEqual("cat", this._cat.AnimalName);
            Assert.AreEqual("meow", this._cat.AnimalSound);
        }

        [TestMethod]
        public void AssertDogObjectConstuctionFixture()
        {
            this._dog = new Dog();

            Assert.AreEqual(AnimalTypeEnum.Dog, this._dog.Type);
            Assert.AreEqual("dog", this._dog.AnimalName);
            Assert.AreEqual("woof", this._dog.AnimalSound);
        }

        [TestMethod]
        public void AssertCowObjectConstuctionFixture()
        {
            this._cow = new Cow();
            this.animalManager = new AnimalManager<AnimalBase>();

            Assert.AreEqual(AnimalTypeEnum.Cow, this._cow.Type);
            Assert.AreEqual("cow", this._cow.AnimalName);
            Assert.AreEqual("moo", this._cow.AnimalSound);
            Assert.IsTrue(this.animalManager.GetAnimals().Contains(this._cow.GetGetAnimalNameAndSound()));
        }

        [TestMethod]
        public void AssertDuckObjectConstuctionFixture()
        {
            this._duck = new Duck();

            Assert.AreEqual(AnimalTypeEnum.Duck, this._duck.Type);
            Assert.AreEqual("duck", this._duck.AnimalName);
            Assert.AreEqual("quack", this._duck.AnimalSound);
        }

        [TestMethod]
        public void AssertPigObjectConstuctionFixture()
        {
            this._pig = new Pig();

            Assert.AreEqual(AnimalTypeEnum.Pig, this._pig.Type);
            Assert.AreEqual("pig", this._pig.AnimalName);
            Assert.AreEqual("oink", this._pig.AnimalSound);
        }

        [TestMethod]
        public void AllAnimalsAreDifferentFixture()
        {
            this._dog = new Dog();
            this._cat = new Cat();
            this._cow = new Cow();
            this._duck = new Duck();
            this._pig = new Pig();

            Assert.AreNotEqual(this._dog.Type, this._cat.Type);
            Assert.AreNotEqual(this._dog.AnimalName, this._cat.AnimalName);
            Assert.AreNotEqual(this._dog.AnimalSound, this._cat.AnimalSound);

            Assert.AreNotEqual(this._cow.Type, this._cat.Type);
            Assert.AreNotEqual(this._cow.AnimalName, this._cat.AnimalName);
            Assert.AreNotEqual(this._cow.AnimalSound, this._cat.AnimalSound);

            Assert.AreNotEqual(this._duck.Type, this._cow.Type);
            Assert.AreNotEqual(this._duck.AnimalName, this._cow.AnimalName);
            Assert.AreNotEqual(this._duck.AnimalSound, this._cow.AnimalSound);

            Assert.AreNotEqual(this._pig.Type, this._duck.Type);
            Assert.AreNotEqual(this._pig.AnimalName, this._duck.AnimalName);
            Assert.AreNotEqual(this._pig.AnimalSound, this._duck.AnimalSound);
        }
    }
}