using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcApp;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Calculator c;


        [TestInitialize]
        public void Init()
        {
            c = new Calculator();
        }

        [TestMethod]
        public void OperationAdd_Test()
        {
            Assert.AreEqual(9, Operations.Add(4, 5));
            Assert.AreEqual(9, c.Calculate(4, 5, Operations.Add));
           
        }

        [TestMethod]
        public void OperationSubtract_Test()
        {
            Assert.AreEqual(9, Operations.Subtract(15,6));
            Assert.AreEqual(9, c.Calculate(15,6, Operations.Subtract));

        }

        [TestMethod]
        public void OperationMultiply_Test()
        {
            Assert.AreEqual(20, Operations.Multiply(4, 5));
            Assert.AreEqual(20, c.Calculate(4, 5, Operations.Multiply));

        }

        [TestMethod]
        public void OperationDivide_Test()
        {
            Assert.AreEqual(9, Operations.Divide(81, 9));
            Assert.AreEqual(9, c.Calculate(81,9, Operations.Divide));

        }
    }
}
