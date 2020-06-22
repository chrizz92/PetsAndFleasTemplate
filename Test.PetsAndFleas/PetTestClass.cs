using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PetsAndFleas.Test
{
    /// <summary>
    ///This is a test class for PetTest and is intended
    ///to contain all PetTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PetTestClass
    {
  
        [TestMethod()]
        public void Pet_IsAbstract_ShouldReturnTrue()
        {
            Type type = typeof(Pet);
            Assert.AreEqual(type.IsClass && type.IsAbstract, true, "Pet must be declared abstract");
        }

        [TestMethod()]
        public void PetID_InsertPets_GetCorrectPetID()
        {
            int startID = Pet.LastPetID;
            Pet p1 = new Cat();
            Pet p2 = new Cat();
            Pet p3 = new Dog();

            Assert.AreEqual(startID+1, p1.PetID, "ID Pet 1 is wrong");
            Assert.AreEqual(startID+2, p2.PetID, "ID Pet 2 is wrong");
            Assert.AreEqual(startID+3, p3.PetID, "ID Pet 3 is wrong");
            p3 = new Cat();
            Assert.AreEqual(startID+4, p3.PetID, "ID Pet 4 is wrong");
        }

        [TestMethod()]
        public void RemainingBites_Initialisation_ShouldReturnCorrectNumber()
        {
            Pet p1 = new Cat();
            Pet p2 = new Cat();
            Pet p3 = new Dog();

            Assert.AreEqual(100, p1.RemainingBites, "Remaining Bites cat1 wrong start number");
            Assert.AreEqual(100, p2.RemainingBites, "Remaining Bites cat2 wrong start number");
            Assert.AreEqual(100, p3.RemainingBites, "Remaining Bites dog wrong start number");
        }

        [TestMethod()]
        public void RemainingBites_Calculation_ShouldReturnCorrectNumber()
        {
            Pet p1 = new Cat();
            int result = p1.GetBiten(40);

            Assert.AreEqual(60, p1.RemainingBites, "after 40 flea lunches - 60 bites should be left");
        }

        [TestMethod()]
        public void GetBiten_MoreThanRemainingBites_ShouldReturnAmountOfBites()
        {
            Pet p1 = new Cat();
            int result = p1.GetBiten(40);
            // 60 bites left

            result = p1.GetBiten(70);
            Assert.AreEqual(60, result, "only 60 bites left -> 60 bites are returned");
        }

        [TestMethod()]
        public void GetBiten_MoreThanRemainingBites_ShouldReturnRemainingBites0()
        {
            Pet p1 = new Cat();
            int result = p1.GetBiten(40);
            // 60 bites left

            result = p1.GetBiten(70);
            Assert.AreEqual(0, p1.RemainingBites, "no bites left");
        }

        [TestMethod()]
        public void GetBiten_MoreThanMaxBites_ShouldReturnAmountOfBites()
        {
            Pet p1 = new Cat();
            int result = p1.GetBiten(200);
            Assert.AreEqual(100, result, "max number of bites is 100 -> return 100 bites");
        }

        [TestMethod()]
        public void GetBiten_MoreThanMaxBites_ShouldReturnRemainingBites0()
        {
            Pet p1 = new Cat();
            int result = p1.GetBiten(200);
            Assert.AreEqual(0, p1.RemainingBites, "no bites left");
        }

        [TestMethod()]
        public void GetBiten_NegativeNumber_ShouldReturnCorrectRemainingBites()
        {
            Pet p1 = new Cat();
            int result = p1.GetBiten(-100);

            Assert.AreEqual(100, p1.RemainingBites, "100 lunches are still left");
        }

        [TestMethod()]
        public void GetBiten_NegativeNumber_ShouldReturn0()
        {
            Pet p1 = new Cat();
            int result = p1.GetBiten(-100);

            Assert.AreEqual(0, result, "negative number of bites is not possible -> return 0");
        }
    }
}
