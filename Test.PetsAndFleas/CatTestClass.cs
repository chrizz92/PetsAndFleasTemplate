using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PetsAndFleas.Test
{
    /// <summary>
    ///This is a test class for CatTest and is intended
    ///to contain all CatTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CatTestClass
    {
        /// <summary>
        ///A test for ClimbOnTree
        ///</summary>
        ///
        [TestMethod()]
        public void ClimbOnTree_StartFromGroundLevel_ShouldReturnTrue()
        {
            Cat c1 = new Cat();
            bool result;
            result=c1.ClimbOnTree();
            Assert.AreEqual(result, true, "cat should be on a tree");
        }

        [TestMethod()]
        public void ClimbOnTree_StartFromGroundLevel_ShouldReturn1()
        {
            Cat c1 = new Cat();
            bool result;
            result = c1.ClimbOnTree();
            Assert.AreEqual(c1.TreesClimbed, 1, "cat climbed on exactly one tree");
        }

        [TestMethod()]
        public void ClimbOnTree_AllreadyOnTree_ShouldReturnFalse()
        {
            Cat c1 = new Cat();
            bool result;
            result = c1.ClimbOnTree();
            result = c1.ClimbOnTree();
            Assert.AreEqual(result, false, "cat is still on a tree - she shall climb down before she can go up again");
        }

        [TestMethod()]
        public void ClimbOnTree_AllreadyOnTree_ShouldReturn1()
        {
            Cat c1 = new Cat();
            bool result;
            result = c1.ClimbOnTree();
            result = c1.ClimbOnTree();
            Assert.AreEqual(c1.TreesClimbed, 1, "cat is still on a tree - she shall climb down before she can go up on another tree");
        }

        [TestMethod()]
        public void ClimbOnTree_NextTree_ShouldReturnTrue()
        {
            Cat c1 = new Cat();
            bool result;
            result = c1.ClimbOnTree();

            result = c1.ClimbDown();

            result = c1.ClimbOnTree();

            Assert.AreEqual(result, true, "cat went up the tree again");
        }

        [TestMethod()]
        public void ClimbOnTree_NextTree_ShouldReturn2()
        {
            Cat c1 = new Cat();
            bool result;
            result = c1.ClimbOnTree();

            result = c1.ClimbDown();

            result = c1.ClimbOnTree();

            Assert.AreEqual(c1.TreesClimbed, 2, "cat climbed its second tree");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToString_Override_ShouldReturnCorrectString()
        {
            Cat cat = new Cat();
            Assert.AreEqual(cat.ToString(), "I am a cat.");
        }
    }
}
