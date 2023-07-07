using Testing_CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing_CSharp.Tests
{
    [TestClass()]
    public class ComputationTests
    {
        [TestMethod()]
        public void GetDivisionTest1()
        {
            // Act
            float test1 = Computation.GetDivision(2, 1);

            // Assert
            Assert.AreEqual(2, test1);
        }

        [TestMethod()]
        public void GetDivisionTest2()
        {
            float test2 = Computation.GetDivision(-4, -2);
            Assert.AreEqual(2, test2);
        }

        [TestMethod()]
        public void GetDivisionTest3()
        {
            float test3 = Computation.GetDivision(1, 2);
            Assert.AreEqual(0.5f, test3);
        }

        [TestMethod()]
        public void GetDivisionTestError()
        {
            float test4 = Computation.GetDivision(-4, 2);
            Assert.AreEqual(-525, test4); // Error made on purpose.
        }
    }
}