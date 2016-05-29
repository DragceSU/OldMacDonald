namespace OldMacDonald.NUnitTests.Domain
{
    using NUnit.Framework;

    using OldMacDonald.BL;
    using OldMacDonald.Domain;
    using OldMacDonald.Domain.Animals;

    [TestFixture]
    public class Domain
    {
        [SetUp]
        public void InitializeTests()
        {
            _dog = new Dog();
            _cat = new Cat();
            _cow = new Cow();
            _duck = new Duck();
            _pig = new Pig();
        }

        private static Cat _cat;

        private static Dog _dog;

        private static Pig _pig;

        private static Cow _cow;

        private static Duck _duck;

        private AnimalManager<AnimalBase> animalManager;

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
            _cat = new Cat();

            Assert.That(AnimalTypeEnum.Cat, Is.EqualTo(_cat.Type));
            Assert.That("cat", Is.EqualTo(_cat.AnimalName));
            Assert.That("meow", Is.EqualTo(_cat.AnimalSound));
        }

        [Test]
        [MaxTime(500)]
        public void TestCowObjectConstuction()
        {
            _cow = new Cow();
            this.animalManager = new AnimalManager<AnimalBase>();

            Assert.That(AnimalTypeEnum.Cow, Is.EqualTo(_cow.Type));
            Assert.That("cow", Is.EqualTo(_cow.AnimalName));
            Assert.That("moo", Is.EqualTo(_cow.AnimalSound));
            Assert.That(this.animalManager.GetAnimals(), Contains.Substring(_cow.GetGetAnimalNameAndSound()));
        }

        [Test]
        [MaxTime(500)]
        public void TestDogObjectConstuction()
        {
            _dog = new Dog();

            Assert.That(AnimalTypeEnum.Dog, Is.EqualTo(_dog.Type));
            Assert.That("dog", Is.EqualTo(_dog.AnimalName));
            Assert.That("woof", Is.EqualTo(_dog.AnimalSound));
        }

        [Test]
        [MaxTime(500)]
        public void TestDuckObjectConstuction()
        {
            _duck = new Duck();

            Assert.That(AnimalTypeEnum.Duck, Is.EqualTo(_duck.Type));
            Assert.That("duck", Is.EqualTo(_duck.AnimalName));
            Assert.That("quack", Is.EqualTo(_duck.AnimalSound));
        }

        [Test]
        [MaxTime(500)]
        public void TestPigObjectConstuction()
        {
            _pig = new Pig();

            Assert.That(AnimalTypeEnum.Pig, Is.EqualTo(_pig.Type));
            Assert.That("pig", Is.EqualTo(_pig.AnimalName));
            Assert.That("oink", Is.EqualTo(_pig.AnimalSound));
        }
    }
}