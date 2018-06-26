using System;
using laba_01_Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        Form1 x = new Form1();

        [TestMethod]
        //Тестирование суммы
        public void TestMethodSum()
        {
            x.a = 10;
            x.t = 6;
            x.c = '+';
            x.Calc();

            if(x.b != 16)
            {
                Assert.Fail();
            }

        }
        [TestMethod]
        //Тестирование разности
        public void TestMethodMinus()
        {
            x.a = 10;
            x.t = 6;
            x.c = '-';
            x.Calc();

            if (x.b != 4)
            {
                Assert.Fail();
            }

        }
        [TestMethod]
        //Тестирование умножения
        public void TestMethodMult()
        {
            x.a = 10;
            x.t = 6;
            x.c = '*';
            x.Calc();

            if (x.b != 60)
            {
                Assert.Fail();
            }

        }
        
        [TestMethod]
        //Тестирование деления
        public void TestMethodDiv()
        {
            x.a = 60;
            x.t = 6;
            x.c = '/';
            x.Calc();
            if (x.b != 10)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        //Тестирование квадратного корня
        public void TestMethodSqrt()
        {
            x.t = 4;
            x.c = '^';
            x.Calc();
            if (x.b != 2)
            {
                Assert.Fail();
            }
        }
        //Тестирование косинуса
        [TestMethod]
        public void TestMethodCosinus()
        {
            x.t = 0.5;
            x.c = 'c';
            x.Calc();
            if (x.b != 0.877)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        //Тестирование факториала
        public void TestMethodFactor()
        {
            x.a = 3;
            x.c = '!';
            x.Calc();
            if (x.b != 6)
            {
                Assert.Fail();
            }
        }
    }
}
