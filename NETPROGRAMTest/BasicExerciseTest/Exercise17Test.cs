﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETPROGRAM.BasicExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.BasicExerciseTest
{
    [TestClass]
    public class Exercise17Test
    {

        [TestMethod]
        public void TestIsPrime()
        {
            var test = new Exercise17();

            Assert.AreEqual(test.IsPrime(53), true);
            Assert.AreEqual(test.IsPrime(13), true);
            Assert.AreEqual(test.IsPrime(17), true);
            Assert.AreEqual(test.IsPrime(7), true);
            Assert.AreEqual(test.IsPrime(1), false);
            Assert.AreEqual(test.IsPrime(0), false);
        }

        [TestMethod]
        public void TestIsSymmetric()
        {
            var test = new Exercise17();

            Assert.IsTrue(test.IsSymmetric(9));
            Assert.IsTrue(test.IsSymmetric(1234321));
            Assert.IsTrue(test.IsSymmetric(121));
            Assert.IsFalse(test.IsSymmetric(1231));
            Assert.IsFalse(test.IsSymmetric(234435453));
            Assert.IsFalse(test.IsSymmetric(87874));
        }

        [TestMethod]
        public void TestFindNumbers()
        {
            var test = new Exercise17();

            Assert.AreEqual(test.FindNumbers(100), 101);
            Assert.AreEqual(test.FindNumbers(145), 151);
            Assert.AreEqual(test.FindNumbers(2324), 10201);
            Assert.AreEqual(test.FindNumbers(455454), 1003001);
        }
    }
}
