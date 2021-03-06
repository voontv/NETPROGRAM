﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETPROGRAM.String_Exercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETPROGRAMTest.String_ExerciseTest
{

    [TestClass]
    public class Exercise04Test
    {

        [TestMethod]
        public void TestSumIntInString()
        {
            var test = new Exercise04();

            Assert.AreEqual(test.SumIntInString("abc 123 def 33 mn 3.221"), 380);
            Assert.AreEqual(test.SumIntInString("Trong 5 nam chung ta loi nhuan duoc 200"), 205);
        }     

        [TestMethod]
        public void TestSumIntRegex()
        {
            var test = new Exercise04();

            Assert.AreEqual(test.SumIntRegex("abc 123 def 33 mn 3.221"), 380);
            Assert.AreEqual(test.SumIntRegex("Trong 5 nam chung ta loi nhuan duoc 200"), 205);
            Assert.AreEqual(test.SumIntRegex("aaaaa123gffgfgf454"), 577);
        }
    }
}
