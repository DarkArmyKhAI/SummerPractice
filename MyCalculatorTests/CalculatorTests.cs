using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Tests {
    [TestClass()]
    public class CalculatorTests {

        Calculator c = new Calculator();

        [TestMethod()]
        public void PlusTest() {
            try {
                c.acc = 10;
                c.op = '+';
                Assert.AreEqual(15, c.Calculate(5));
            } catch {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void MinusTest() {
            try {
                c.acc = 10;
                c.op = '-';
                Assert.AreEqual(5, c.Calculate(5));
            } catch {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void MultiplyTest() {
            try {
                c.acc = 10;
                c.op = '*';
                Assert.AreEqual(50, c.Calculate(5));
            } catch {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void DivisionTest() {
            try {
                c.acc = 10;
                c.op = '/';
                Assert.AreEqual(2, c.Calculate(5));
            } catch {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void PowTest() {
            try {
                c.op = 'p';
                Assert.AreEqual(5, c.Calculate(25));
            } catch {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void SinTest() {
            try {
                c.op = 's';
                Assert.AreEqual(1, c.Calculate(Math.PI / 2));
            } catch {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void PowTwoTest() {
            try {
                c.op = 'q';
                Assert.AreEqual(25, c.Calculate(5));
            } catch {
                Assert.Fail();
            }
        }
    }
}