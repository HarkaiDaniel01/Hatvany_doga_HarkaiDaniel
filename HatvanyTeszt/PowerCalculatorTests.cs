using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Hatvany;

namespace HatvanyTeszt
{
    [TestClass]
    public class PowerCalculatorTests
    {
        [TestMethod]
        public void TestPositiveExponent()
        {
            var validator = new PowerCalculator();
            int alap = 2;
            int kitevo = 3;

            double eredmeny = validator.CalculatePower(alap, kitevo);

            Assert.AreEqual(eredmeny, 8);
        }

        [TestMethod]
        public void TestZeroExponent()
        {
            var validator = new PowerCalculator();
            int alap = 5;
            int kitevo = 0;

            double eredmeny = validator.CalculatePower(alap, kitevo);

            Assert.AreEqual(eredmeny, 1);
        }

        [TestMethod]
        public void TestNegativeExponent()
        {
            var validator = new PowerCalculator();
            int alap = 2;
            int kitevo = -2;

            double eredmeny = validator.CalculatePower(alap, kitevo);

            Assert.AreEqual(eredmeny, 0.25);
        }

        [TestMethod]
        public void TestZeroBasePositiveExponent()

        {
            var validator = new PowerCalculator();
            int alap = 0;
            int kitevo = 5;

            double eredmeny = validator.CalculatePower(alap, kitevo);

            Assert.AreEqual(eredmeny, 0);
        }

        [TestMethod]
        public void TestZeroBaseZeroExponent()

        {
            var validator = new PowerCalculator();
            int alap = 0;
            int kitevo = 0;

            double eredmeny = validator.CalculatePower(alap, kitevo);

            Assert.AreEqual(eredmeny, 1);
        }

        [TestMethod]
        public void TestOneBaseAnyExponent()

        {
            var validator = new PowerCalculator();
            int alap = 1;
            int kitevo = 100;

            double eredmeny = validator.CalculatePower(alap, kitevo);

            Assert.AreEqual(eredmeny, 1);
        }

        [TestMethod]
        public void TestNegativeBaseEvenExponent()

        {
            var validator = new PowerCalculator();
            int alap = -3;
            int kitevo = 4;

            double eredmeny = validator.CalculatePower(alap, kitevo);

            Assert.AreEqual(eredmeny, 81);
        }

        [TestMethod]
        public void TestNegativeBaseOddExponent()

        {
            var validator = new PowerCalculator();
            int alap = -2;
            int kitevo = 3;

            double eredmeny = validator.CalculatePower(alap, kitevo);

            Assert.AreEqual(eredmeny, -8);
        }

        [TestMethod]
        public void TestNegativeBaseNegativeExponent()

        {
            var validator = new PowerCalculator();
            int alap = -2;
            int kitevo = -2;

            double eredmeny = validator.CalculatePower(alap, kitevo);

            Assert.AreEqual(eredmeny, 0.25);
        }
    }
}
