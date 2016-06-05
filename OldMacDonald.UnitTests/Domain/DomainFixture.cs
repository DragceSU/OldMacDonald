namespace OldMacDonald.NUnitTests.Domain
{
    #region

    using NUnit.Framework;

    using OldMacDonald.BL;
    using OldMacDonald.Domain;
    using OldMacDonald.Domain.Animals;

    #endregion

    [TestFixture]
    public class Domain
    {
        private Cat _cat;

        private Cow _cow;

        private Dog _dog;

        private Duck _duck;

        private Pig _pig;

        private AnimalManager<AnimalBase> animalManager;

        [SetUp]
        public void InitializeTests()
        {
            this._dog = new Dog();
            this._cat = new Cat();
            this._cow = new Cow();
            this._duck = new Duck();
            this._pig = new Pig();
        }

        [Test]
        [MaxTime(500)]
        public void CheckIfAllAnimalsAreDifferentFromEachOther(
            [Values(AnimalTypeEnum.Cat, AnimalTypeEnum.Cow, AnimalTypeEnum.Dog, AnimalTypeEnum.Duck, AnimalTypeEnum.Pig)
            ] AnimalTypeEnum firstAnimalTypeEnumAnimal, 
            [Values(AnimalTypeEnum.Cat, AnimalTypeEnum.Cow, AnimalTypeEnum.Dog, AnimalTypeEnum.Duck, AnimalTypeEnum.Pig)
            ] AnimalTypeEnum secondAnimalTypeEnumAnimal)
        {
            if (firstAnimalTypeEnumAnimal == secondAnimalTypeEnumAnimal)
            {
                Assert.That(firstAnimalTypeEnumAnimal, Is.EqualTo(secondAnimalTypeEnumAnimal));
            }
            else
            {
                Assert.That(firstAnimalTypeEnumAnimal, Is.Not.EqualTo(secondAnimalTypeEnumAnimal));
                Assert.That(
                    AnimalBase.AnimalFactory(firstAnimalTypeEnumAnimal).AnimalName, 
                    Is.Not.EqualTo(AnimalBase.AnimalFactory(secondAnimalTypeEnumAnimal).AnimalName));
                Assert.That(
                    AnimalBase.AnimalFactory(firstAnimalTypeEnumAnimal).AnimalSound, 
                    Is.Not.EqualTo(AnimalBase.AnimalFactory(secondAnimalTypeEnumAnimal).AnimalSound));
                Assert.That(
                    AnimalBase.AnimalFactory(firstAnimalTypeEnumAnimal).GetGetAnimalNameAndSound(), 
                    Is.Not.EqualTo(AnimalBase.AnimalFactory(secondAnimalTypeEnumAnimal).GetGetAnimalNameAndSound()));
            }
        }

        [Test]
        [MaxTime(500)]
        public void TestCatObjectConstuction()
        {
            this._cat = new Cat();

            Assert.That(AnimalTypeEnum.Cat, Is.EqualTo(this._cat.Type));
            Assert.That("cat", Is.EqualTo(this._cat.AnimalName));
            Assert.That("meow", Is.EqualTo(this._cat.AnimalSound));
        }

        [Test]
        [MaxTime(500)]
        public void TestCowObjectConstuction()
        {
            this._cow = new Cow();
            this.animalManager = new AnimalManager<AnimalBase>();

            Assert.That(AnimalTypeEnum.Cow, Is.EqualTo(this._cow.Type));
            Assert.That("cow", Is.EqualTo(this._cow.AnimalName));
            Assert.That("moo", Is.EqualTo(this._cow.AnimalSound));
            Assert.That(this.animalManager.GetAnimals(), Contains.Substring(this._cow.GetGetAnimalNameAndSound()));
        }

        [Test]
        [MaxTime(500)]
        public void TestDogObjectConstuction()
        {
            this._dog = new Dog();

            Assert.That(AnimalTypeEnum.Dog, Is.EqualTo(this._dog.Type));
            Assert.That("dog", Is.EqualTo(this._dog.AnimalName));
            Assert.That("woof", Is.EqualTo(this._dog.AnimalSound));
        }

        [Test]
        [MaxTime(500)]
        public void TestDuckObjectConstuction()
        {
            this._duck = new Duck();

            Assert.That(AnimalTypeEnum.Duck, Is.EqualTo(this._duck.Type));
            Assert.That("duck", Is.EqualTo(this._duck.AnimalName));
            Assert.That("quack", Is.EqualTo(this._duck.AnimalSound));
        }

        [Test]
        [MaxTime(500)]
        public void TestPigObjectConstuction()
        {
            this._pig = new Pig();

            Assert.That(AnimalTypeEnum.Pig, Is.EqualTo(this._pig.Type));
            Assert.That("pig", Is.EqualTo(this._pig.AnimalName));
            Assert.That("oink", Is.EqualTo(this._pig.AnimalSound));
        }
    }
}