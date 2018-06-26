using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Tests {
    [TestClass()]
    public class FmasTests {

        Fmas test = new Fmas(5, 0, 10);

        [TestMethod()]
        public void CheckIndexTest() {
            if(!test.CheckIndex(1, 1))
                Assert.Fail();
        }

        [TestMethod()]
        public void Func1Test() {
            int[,] tmp = test.Func1();
            if(!(tmp[0, 0] >= tmp[2, 0]))
                Assert.Fail();
        }

        [TestMethod()]
        public void Func2Test() {
            try {
                test.Func2(3);
            } catch {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void Func3Test() {
            try {
                test.Func3(3, 4);
            } catch {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void SerializeTest() {
            try {
                test.Serialize("test.xml");
            } catch {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void DeserializeTest() {
            try {
                test.Deserialize("test.xml");
            } catch {
                Assert.Fail();
            }
        }
    }
}