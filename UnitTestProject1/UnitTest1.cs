using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 1;
            double b = 100;
            double c1 = 1;
            double expected = 2;
            MathModel c = new MathModel();
            double d = c.MathM(a,b,c1);
            Assert.AreEqual(expected, d);

        }
        [TestMethod]
        public void TestMethod2()
        {
            
            string expected = "Некорректно введена процентная ставка в файле";
            Messed c = new Messed();
            string d = c.Sms();
            Assert.AreEqual(expected, d);

        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = 100;
            double b = 100;
            double c1 = 1;
            double expected = 200;
            MathModel c = new MathModel();
            double d = c.MathM(a, b, c1);
            Assert.AreEqual(expected, d);

        }
    }
}
