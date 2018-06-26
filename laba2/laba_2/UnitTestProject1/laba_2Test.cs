using System;
using laba_2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace laba_2.Tests
{
    [TestClass]
    public class laba_2Test
    {
        
        equation exp = new equation();
        // коэффициент а равен нулю
        [TestMethod]
        public void null_A()
        {
            exp.a = 0;
            exp.b = 2;
            exp.c = 3;

            exp.calculate();
            if(exp.x1 != -1.5)
            {
                Assert.Fail();
            }
        }
        // коэффициент b равен нулю
        [TestMethod]
        public void null_B()
        {
            exp.a = 2;
            exp.b = 0;
            exp.c = -8;

            exp.calculate();
            if (exp.x1 != 2 && exp.x2 != -2)
            {
                Assert.Fail();
            }
        }
        // коэффициент c равен нулю
        [TestMethod]
        public void null_C()
        {
            exp.a = 2;
            exp.b = 3;
            exp.c = 0;

            exp.calculate();
            if (exp.x1 != -1.5)
            {
                Assert.Fail();
            }
        }
        //положительный дискриминант
        [TestMethod]
        public void positive_D()
        {
            exp.a = 1;
            exp.b = 3;
            exp.c = 2;

            exp.calculate();
            if (exp.D <= 0 && exp.x1 != -1 && exp.x2 != -2)
            {
                Assert.Fail();
            }
        }
        //отрицательный дискриминант
        [TestMethod]
        public void negative_D()
        {
            exp.a = 1;
            exp.b = 3;
            exp.c = 4;

            exp.calculate();
            if (exp.D >= 0)
            {
                Assert.Fail();
            }
        }
        //дискриминант равен нулю
        [TestMethod]
        public void equalNull_D()
        {
            exp.a = 2;
            exp.b = 4;
            exp.c = 2;

            exp.calculate();
            if (exp.D != 0 && exp.x1 != 1 && exp.x2 != 1)
            {
                Assert.Fail();
            }
        }
    }
}
