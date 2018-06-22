using System;
using Sqr_Equations;
using NUnit.Framework;

namespace SqrTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void SqrSolveDescPos()
        {

            // arrange  
            double x1, x2;
            SqrSolver s = new SqrSolver(1, 12, 2);
            double actual, expected = -12;

            // act  
            s.Solve(out x1, out x2);
            actual = x1 + x2;

            // assert 
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SqrSolveDescNeg()
        {
            // arrange  
            double x1, x2;
            SqrSolver s = new SqrSolver(4, 12, 12);
            bool actual, expected = true;

            // act  
            actual = s.Solve(out x1, out x2);

            // assert 
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SqrSolveDescZero()
        {
            // arrange  
            double x1, x2;
            SqrSolver s = new SqrSolver(8, 8, 2);
            double actual, expected = 0;

            // act  
            s.Solve(out x1, out x2);
            actual = x1 - x2;

            // assert 
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SqrSolveZeroCoeffs()
        {
            // arrange  
            double x1, x2;
            SqrSolver s = new SqrSolver(0, 0, 0);
            double actual, expected = 0;

            // act  
            s.Solve(out x1, out x2);
        }

        [Test]
        public void SqrSolveComplexTest()
        {
            // arrange  
            double x1, x2;
            SqrSolver s = new SqrSolver(4, 2, 5);
            int actual, expected = -21;

            // act  
            s.Solve(out x1, out x2);
            actual = (int)x1 - (int)x2;

            // assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
