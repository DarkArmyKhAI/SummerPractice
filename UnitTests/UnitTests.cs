using QuadraticEquation;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void CalcQuadraticEqTest1()
        {
            // исходные данные
            string a = "1", b = "3", c = "-4";
            List<string> expected = new List<string>();
            expected.Add("-4.00");
            expected.Add("1.00");
            expected.Add("25.00");
            // получение значения с помощью тестируемого метода
            CalculationEquation calculationEquation = new CalculationEquation();
            List<string> actual = new List<string>();
            actual = calculationEquation.CalcQuadraticEq(a, b, c);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }

        [Test]
        public void CalcQuadraticEqTest2()
        {
            // исходные данные
            string a = "1", b = "-4", c = "0";
            List<string> expected = new List<string>();
            expected.Add("0.00");
            expected.Add("4.00");
            expected.Add("16.00");
            // получение значения с помощью тестируемого метода
            CalculationEquation calculationEquation = new CalculationEquation();
            List<string> actual = new List<string>();
            actual = calculationEquation.CalcQuadraticEq(a, b, c);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }

        [Test]
        public void CalcQuadraticEqTest3()
        {
            // исходные данные
            string a = "9", b = "2", c = "7";
            List<string> expected = new List<string>();
            expected.Add("***");
            expected.Add("***");
            expected.Add("***");
            // получение значения с помощью тестируемого метода
            CalculationEquation calculationEquation = new CalculationEquation();
            List<string> actual = new List<string>();
            actual = calculationEquation.CalcQuadraticEq(a, b, c);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }

        [Test]
        public void CalcQuadraticEqTest4()
        {
            // исходные данные
            string a = "1", b = "6", c = "9";
            List<string> expected = new List<string>();
            expected.Add("-3.00");
            expected.Add("***");
            expected.Add("0.00");
            // получение значения с помощью тестируемого метода
            CalculationEquation calculationEquation = new CalculationEquation();
            List<string> actual = new List<string>();
            actual = calculationEquation.CalcQuadraticEq(a, b, c);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }

        [Test]
        public void CalcCubicEqTest1()
        {
            // исходные данные
            string a = "2", b = "11", c = "5", d = "17";
            List<string> expected = new List<string>();
            expected.Add("-5.33");
            expected.Add("-0.08 - 1.3*i");
            expected.Add("-0.08 + 1.3*i");
            // получение значения с помощью тестируемого метода
            CalculationEquation calculationEquation = new CalculationEquation();
            List<string> actual = new List<string>();
            actual = calculationEquation.CalcCubicEq(a, b, c, d);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }

        [Test]
        public void CalcCubicEqTest2()
        {
            // исходные данные
            string a = "2", b = "-11", c = "12", d = "9";
            List<string> expected = new List<string>();
            expected.Add("-0.50");
            expected.Add("3.00 + 0.0*i");
            expected.Add("3.00 - 0.0*i");
            // получение значения с помощью тестируемого метода
            CalculationEquation calculationEquation = new CalculationEquation();
            List<string> actual = new List<string>();
            actual = calculationEquation.CalcCubicEq(a, b, c, d);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }

        [Test]
        public void CalcCubicEqTest3()
        {
            // исходные данные
            string a = "1", b = "-6", c = "11", d = "-6";
            List<string> expected = new List<string>();
            expected.Add("1.00");
            expected.Add("3.00");
            expected.Add("2.00");
            // получение значения с помощью тестируемого метода
            CalculationEquation calculationEquation = new CalculationEquation();
            List<string> actual = new List<string>();
            actual = calculationEquation.CalcCubicEq(a, b, c, d);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }
    }
}
