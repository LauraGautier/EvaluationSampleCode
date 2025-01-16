using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Setup()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(25, 10, 15)]
        [DataRow(500, 300, 200)]
        [DataRow(800, 400, 400)]
        [DataRow(1500, 1300, 200)]
        [DataRow(300, 400, 0)]
        public void Subtract_ShouldReturnCorrectResult_WhenValidParameters(int numberOne, int numberTwo, int expected)
        {
            // Act & Assert
            if (numberOne < 1200 && numberTwo <= numberOne)
            {
                var result = _mathOperations.Subtract(numberOne, numberTwo);
                Assert.AreEqual(expected, result);
            }
            else
            {
                Assert.ThrowsException<ArgumentException>(() => _mathOperations.Subtract(numberOne, numberTwo));
            }
        }

        [TestMethod]
        [DataRow(6, "Red")]
        [DataRow(10, "Red")]
        [DataRow(13, "Blue")]
        [DataRow(18, "Red")]
        public void GetColorFromOddsNumber_ShouldReturnCorrectColor(int number, string expected)
        {
            // Act
            var result = _mathOperations.GetColorFromOddsNumber(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetColorFromOddsNumber_ShouldThrowArgumentException_WhenNumberIsNegative()
        {
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.GetColorFromOddsNumber(-5));
        }
    }
}