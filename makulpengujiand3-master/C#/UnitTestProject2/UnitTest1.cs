using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPlus()
        {
            MainWindow cal = new MainWindow();
            double a = 4;
            double b = 5;
            double result = cal.plus(a, b);
            double expect = 9;

            Assert.AreEqual(expect, result, "Salah");
        }

        [TestMethod]
        public void TestMethodMinus()
        {
            MainWindow cal = new MainWindow();
            double a = 7;
            double b = 4;
            double result = cal.minus(a,b);
            double expect = 3;

            Assert.AreEqual(expect, result, "Salah");
        }

        [TestMethod]
        public void TestMethodMulti()
        {
            MainWindow cal = new MainWindow();
            double a = 4;
            double b = 5;
            double result = cal.multiplication(a, b);
            double expect = 20;

            Assert.AreEqual(expect, result, "Salah");
        }

        [TestMethod]
        public void TestMethodDiv()
        {
            MainWindow cal = new MainWindow();
            double a = 20;
            double b = 5;
            double result = cal.div(a, b);
            double expect = 4;

            Assert.AreEqual(expect, result, "Salah");
        }
    }
}
