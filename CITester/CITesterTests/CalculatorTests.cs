using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CITester;

namespace CITesterTests
{
    [TestClass]
    public class CalculatorTests
    {    
        [TestMethod]
        public void Calculator_ShouldAddTwoNumbers()
        {
            //Arrange
            var calculator = new Calculator();
            double actual,expected = 3.3;

            //Act
            actual = calculator.Add(2.3, 1.0);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculator_ShouldAddTwoNumbersWithDifferentSign()
        {
            //Arrange
            var calculator = new Calculator();
            double actual, expected = 1.3;

            //Act
            actual = calculator.Add(2.3, -1.0);

            //Assert
            Assert.AreEqual(expected, Math.Round(actual,1));
        }

        [TestMethod]
        public void Calculator_ShouldSubtrackTwoNumbers()
        {
            //Arrange
            var calculator = new Calculator();
            double actual, expected = 2.3;

            //Act
            actual = calculator.Subtrack(3.3, 1.0);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculator_ShouldSubtrackTwoNumbersWithDifferentSign()
        {
            //Arrange
            var calculator = new Calculator();
            double actual, expected = 3.3;

            //Act
            actual = calculator.Subtrack(2.3, -1.0);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculator_ShouldMultiplyTwoNumbers()
        {
            //Arrange
            var calculator = new Calculator();
            double actual, expected = 2.3;

            //Act
            actual = calculator.Multiply(2.3, 1.0);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculator_ShouldMultiplyTwoNumbersWithDifferentSign()
        {
            //Arrange
            var calculator = new Calculator();
            double actual, expected = -2.3;

            //Act
            actual = calculator.Multiply(2.3, -1.0);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculator_ShouldDivideTwoNumbers()
        {
            //Arrange
            var calculator = new Calculator();
            double actual, expected = 2.0;

            //Act
            actual = calculator.Divide(6.2, 3.1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculator_ShouldDivideTwoNumbersWithDifferentSign()
        {
            //Arrange
            var calculator = new Calculator();
            double actual, expected = -2.0;

            //Act
            actual = calculator.Divide(6.2, -3.1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Calculator_ShouldThrowDivideByZeroException()
        {
            //Arrange
            var calculator = new Calculator();
            double actual;

            //Act
            actual = calculator.Divide(6.2, 0);            
        }
    }
}
