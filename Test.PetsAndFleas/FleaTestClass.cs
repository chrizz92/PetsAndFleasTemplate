using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PetsAndFleas.Test
{
    /// <summary>
    ///This is a test class for FleaTest and is intended
    ///to contain all FleaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FleaTestClass
    {
        [TestMethod()]
        public void BitePet_RemainingBites_ShouldReturnCorrectNumber()
        {
            int result;
            Pet p1 = new Cat();
            Flea f1 = new Flea();

            f1.JumpOnPet(p1);
            result = f1.BitePet(40);
            Assert.AreEqual(60, p1.RemainingBites, "60 lunches should be left");
        }

        [TestMethod()]
        public void BitePet_MoreThanMaxBites_ShouldReturnCorrectNumbers()
        {
            int result;
            Pet p1 = new Cat();
            Flea f1 = new Flea();

            f1.JumpOnPet(p1);
            result = f1.BitePet(40);
            result = f1.BitePet(70);
            Assert.AreEqual(60, result, "60 bites are left - return value should be 60");
            Assert.AreEqual(100, f1.AmountBites, "flea 1 has finished 100 bites");
            Assert.AreEqual(0, p1.RemainingBites, "no more bites on this pet");
        }

        [TestMethod()]
        public void BitePet_MoreThanMaxBitesJumpOnNextPet_ShouldReturnCorrectNumbers()
        {
            int result;
            Pet p1 = new Cat();
            Pet p2 = new Cat();
            Flea f1 = new Flea();

            f1.JumpOnPet(p1);
            result = f1.BitePet(40);
            result = f1.BitePet(70);
            f1.JumpOnPet(p2);
            result = f1.BitePet(150);
            Assert.AreEqual(100, result, "only 100 bites are possible - return 100 bites");
            Assert.AreEqual(200, f1.AmountBites, "all bites are used - check logic AmountBites");
        }

        [TestMethod()]
        public void BitePet_NegativeBite_ShouldReturnCorrectNumbers()
        {
            int result;
            Pet p3 = new Dog();
            Flea f2 = new Flea();

            f2.JumpOnPet(p3);
            result = f2.BitePet(-100);
            Assert.AreEqual(0, result, "negative bite is not possible - return 0");
            Assert.AreEqual(0, f2.AmountBites, "amount of bites stays to 0");
        }

        [TestMethod()]
        public void BitePet_JumpedOnNoPet_ShouldReturnCorrectNumbers()
        {
            int result;
            Flea f1 = new Flea();
            Flea f3 = new Flea();

            f1.JumpOnPet(null);
            result = f1.BitePet(100);
            Assert.AreEqual(0, result, "flea landed on no pet - return 0");
            result = f3.BitePet(100);
            Assert.AreEqual(0, result, "flea landed on no pet - return 0");
        }

        /// <summary>
        ///A test for JumpOnPet
        ///</summary>
        [TestMethod()]
        public void JumpOnPet_ChangePet_ShouldReturnCorrectPetID()
        {
            int startID = Pet.LastPetID;
            Pet p1 = new Cat();
            Pet p2 = new Dog();
            Flea f1 = new Flea();
            Flea f2 = new Flea();
            Flea f3 = new Flea();

            f1.JumpOnPet(p1);
            f2.JumpOnPet(p2);
            f3.JumpOnPet(p1);
            Assert.AreEqual(f1.ActualPet.PetID, startID + 1, "flea 1 should be on pet ID {0}", startID + 1);
            Assert.AreEqual(f2.ActualPet.PetID, startID + 2, "flea 2 should be on pet ID {0}", startID + 2);
            Assert.AreEqual(f3.ActualPet.PetID, startID + 1, "flea 3 should be on pet ID {0}", startID + 1);
            f3.JumpOnPet(p2);
            Assert.AreEqual(f3.ActualPet.PetID, startID + 2, "now flea 3 should be on pet ID {0}", startID + 2);
            f3.JumpOnPet(null);
            Assert.AreEqual(f3.ActualPet, null, "flea 3 should be on NO pet");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToString_Override_ShouldReturnCorrectString()
        {
            Flea flea = new Flea();
            Assert.AreEqual(flea.ToString(), "I am a flea.");
        }
    }
}