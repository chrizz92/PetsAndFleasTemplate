using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace PetsAndFleas.Test
{
    /// <summary>
    ///This is a test class for DogTest and is intended
    ///to contain all DogTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DogTestClass
    {
        /// <summary>
        ///A test for HuntAnimal
        ///</summary>
        [TestMethod()]
        public void HuntAnimal_HuntFirstAnimal_ShouldReturnTrue()
        {
            Dog d1 = new Dog();
            bool actual;
             
            actual = d1.HuntAnimal();
            Assert.AreEqual(actual, true, "dog is hunting");
        }

        [TestMethod()]
        public void HuntAnimal_HuntFirstAnimal_ShouldReturn1()
        {
            Dog d1 = new Dog();
            bool actual;

            actual = d1.HuntAnimal();
            Assert.AreEqual(d1.HuntedAnimals, 1, "one animal is being hunted");
        }

        [TestMethod()]
        public void HuntAnimal_HuntFirstAnimalANDSecondWithoutBreak_ShouldReturnFalse()
        {
            Dog d1 = new Dog();
            bool actual;

            actual = d1.HuntAnimal();
            actual = d1.HuntAnimal();
            Assert.AreEqual(actual, false, "new hunt is not possible (break needed before)");
        }

        [TestMethod()]
        public void HuntAnimal_HuntFirstAnimalANDSecondWithoutBreak_ShouldReturn1()
        {
            Dog d1 = new Dog();
            bool actual;

            actual = d1.HuntAnimal();
            actual = d1.HuntAnimal();
            Assert.AreEqual(d1.HuntedAnimals, 1, "new hunted animal is not possible (break needed before) - counter stays to 1");
        }

        [TestMethod()]
        public void HuntAnimal_NewHunt_ShouldReturnTrue()
        {
            Dog d1 = new Dog();
            bool actual;

            actual = d1.HuntAnimal();
            //Attention! Breakpoints may lead to incorrect results
            Thread.Sleep(1001);
            actual = d1.HuntAnimal();
            Assert.AreEqual(actual, true, "new hunt is possible now (it had a break before)");
        }

        [TestMethod()]
        public void HuntAnimal_NewHunt_ShouldReturnCorrectNumber()
        {
            Dog d1 = new Dog();
            bool actual;

            actual = d1.HuntAnimal();
            //Attention! Breakpoints may lead to incorrect results
            Thread.Sleep(1001);
            actual = d1.HuntAnimal();
            Assert.AreEqual(d1.HuntedAnimals, 2, "dog hunted second animal (it had a break before)");
        }
        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToString_Override_ShouldReturnCorrectString()
        {
            Dog dog = new Dog();
            Assert.AreEqual(dog.ToString(), "I am a dog.");
        }
    }
}
