using lab01_tp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void MultiplicationTest()
        {
            // исходные данные
            double a = 56.8d;
            double b = 12.5d;
            double expected = 710;

            // получение значения с помощью тестируемого метода
            Calculator c = new Calculator();
            c.Put_A(a);
            double actual = c.Multiplication(b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivisionTest()
        {
            // исходные данные
            double a = 60;
            double b = 12;
            double expected = 5;

            // получение значения с помощью тестируемого метода
            Calculator c = new Calculator();
            c.Put_A(a);
            double actual = c.Division(b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SumTest()
        {
            // исходные данные
            double a = 9.5;
            double b = 2;
            double expected = 11.5;

            // получение значения с помощью тестируемого метода
            Calculator c = new Calculator();
            c.Put_A(a);
            double actual = c.Sum(b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractionTest()
        {
            // исходные данные
            double a = 56;
            double b = 12;
            double expected = 44;

            // получение значения с помощью тестируемого метода
            Calculator c = new Calculator();
            c.Put_A(a);
            double actual = c.Subtraction(b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SquareTest()
        {
            // исходные данные
            double a = 10;
            double expected = 100;

            // получение значения с помощью тестируемого метода
            Calculator c = new Calculator();
            c.Put_A(a);
            double actual = c.Square();

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FactorialTest()
        {
            // исходные данные
            double a = 5;
            double expected = 120;

            // получение значения с помощью тестируемого метода
            Calculator c = new Calculator();
            c.Put_A(a);
            double actual = c.Factorial();

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PowTest()
        {
            // исходные данные
            double a = 16;
            double expected = 4;

            // получение значения с помощью тестируемого метода
            Calculator c = new Calculator();
            c.Put_A(a);
            double actual = c.Pow();

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SinusTest()
        {
            // исходные данные
            double a = 0;
            double expected = 0;

            // получение значения с помощью тестируемого метода
            Calculator c = new Calculator();
            c.Put_A(a);
            double actual = c.Square();

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CosinusTest()
        {
            // исходные данные
            double a = 0;
            double expected = 1;

            // получение значения с помощью тестируемого метода
            Calculator c = new Calculator();
            c.Put_A(a);
            double actual = c.Cosinus();

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void XDivisionTest()
        {
            // исходные данные
            double a = 20;
            double expected = 0.05;

            // получение значения с помощью тестируемого метода
            Calculator c = new Calculator();
            c.Put_A(a);
            double actual = c.XDivision();

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
    }
}
