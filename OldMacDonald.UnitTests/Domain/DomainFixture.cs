using NUnit.Framework;
using OldMacDonald.BL;
using OldMacDonald.Domain;
using OldMacDonald.Domain.Animals;

namespace OldMacDonald.NUnitTests.Domain
{
    [TestFixture]
    public class Domain
    {
        private static Cat _cat;
        private static Dog _dog;
        private static Pig _pig;
        private static Cow _cow;
        private static Duck _duck;

        private AnimalManager<AnimalBase> animalManager;

        [SetUp]
        public void InitializeTests()
        {
            _dog = new Dog();
            _cat = new Cat();
            _cow = new Cow();
            _duck = new Duck();
            _pig = new Pig();
        }

        [Test]
        public void TestCatObjectConstuction()
        {
            _cat = new Cat();

            Assert.That(AnimalType.Cat, Is.EqualTo(_cat.Type));
            Assert.That("cat", Is.EqualTo(_cat.AnimalName));
            Assert.That("meow", Is.EqualTo(_cat.AnimalSound));
        }

        [Test]
        public void TestDogObjectConstuction()
        {
            _dog = new Dog();

            Assert.That(AnimalType.Dog, Is.EqualTo(_dog.Type));
            Assert.That("dog", Is.EqualTo(_dog.AnimalName));
            Assert.That("woof", Is.EqualTo(_dog.AnimalSound));
        }

        [Test]
        public void TestCowObjectConstuction()
        {
            _cow = new Cow();
            animalManager = new AnimalManager<AnimalBase>();

            Assert.That(AnimalType.Cow, Is.EqualTo(_cow.Type));
            Assert.That("cow", Is.EqualTo(_cow.AnimalName));
            Assert.That("moo", Is.EqualTo(_cow.AnimalSound));
            Assert.That(animalManager.GetAnimals(), Contains.Substring(_cow.GetGetAnimalNameAndSound()));
        }

        [Test]
        public void TestDuckObjectConstuction()
        {
            _duck = new Duck();

            Assert.That(AnimalType.Duck, Is.EqualTo(_duck.Type));
            Assert.That("duck", Is.EqualTo(_duck.AnimalName));
            Assert.That("quack", Is.EqualTo(_duck.AnimalSound));
        }

        [Test]
        public void TestPigObjectConstuction()
        {
            _pig = new Pig();

            Assert.That(AnimalType.Pig, Is.EqualTo(_pig.Type));
            Assert.That("pig", Is.EqualTo(_pig.AnimalName));
            Assert.That("oink", Is.EqualTo(_pig.AnimalSound));
        }

        [Test]
        public void CheckIfAllAnimalsAreDifferentFromEachOther(
            [Values(AnimalType.Cat, AnimalType.Cow, AnimalType.Dog, AnimalType.Duck, AnimalType.Pig)]AnimalType firstAnimal,
            [Values(AnimalType.Cat, AnimalType.Cow, AnimalType.Dog, AnimalType.Duck, AnimalType.Pig)]AnimalType secondAnimal)
        {
            if (firstAnimal == secondAnimal)
                Assert.That(firstAnimal, Is.EqualTo(secondAnimal));
            else
            {
                Assert.That(firstAnimal, Is.Not.EqualTo(secondAnimal));
                Assert.That(AnimalBase.AnimalFactory(firstAnimal).AnimalName,
                    Is.Not.EqualTo(AnimalBase.AnimalFactory(secondAnimal).AnimalName));
                Assert.That(AnimalBase.AnimalFactory(firstAnimal).AnimalSound,
                    Is.Not.EqualTo(AnimalBase.AnimalFactory(secondAnimal).AnimalSound));
                Assert.That(AnimalBase.AnimalFactory(firstAnimal).GetGetAnimalNameAndSound(),
                    Is.Not.EqualTo(AnimalBase.AnimalFactory(secondAnimal).GetGetAnimalNameAndSound()));
            }
        }
    }
}
