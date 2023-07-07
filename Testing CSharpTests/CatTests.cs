using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing_CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Testing_CSharp.Tests
{
    [TestClass()]
    public class CatTests
    {
        [TestMethod()]
        public void Cat_ReturnWellConstructedCat()
        {
            // Arrange
            string name = "minou";
            int age = 3;
            float weigth = 3;

            // Act
            Cat catTest = new Cat(name, age, weigth);

            // Assert
            Assert.AreEqual(name, catTest.Name);
            Assert.AreEqual(age, catTest.Age);
            Assert.AreEqual(weigth, catTest.Weigth);
        }

        [TestMethod()]
        public void RaiseWeigth_ReturnIncreasedWeigth()
        {
            // Arrange
            float weigth = 3f;
            float weigthDiff = 1f;
            float weigthIncreased = 4f;

            Cat catTest = new Cat("Grominet", 5, weigth);

            // Act
            catTest.RaiseWeigth(weigthDiff);

            // Assert
            Assert.AreEqual(weigthIncreased, catTest.Weigth);
        }

        [TestMethod()]
        public void UpdateAge_ReturnCorrectAge()
        {
            // Arrange
            int previousAge = 5;
            int currentAge = 6;

            Cat catTest = new Cat("Grominet", previousAge, 2.5f);

            // Act
            catTest.UpdateAge(currentAge);

            // Assert
            Assert.AreEqual(currentAge, catTest.Age);
        }

        [TestMethod()]
        public void ShowCatProfile_ReturnCorrectString()
        {
            // Arrange
            Cat catTest = new Cat("Kitty", 1, 1.5f);
            string profileExpected = "Kitty: 1 years old has a weigth of 1,5kg.";

            // Act
            string result = catTest.GetCatProfile();

            // Assert
            Assert.AreEqual(result, profileExpected);
        }
    }
}