using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class PhoneNumberTests
    {
        [TestMethod]
        public void Parse_ShouldReturnPhoneNumber_WhenValidNumber()
        {
            // Arrange
            string phoneNumber = "0622992575";

            // Act
            var result = PhoneNumber.Parse(phoneNumber);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("(062)299-2575", result.ToString());
        }

        [TestMethod]
        public void Parse_ShouldThrowArgumentException_WhenPhoneNumberIsBlank()
        {
            // Arrange
            string phoneNumber = "";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(phoneNumber));
        }

        [TestMethod]
        public void Parse_ShouldThrowArgumentException_WhenPhoneNumberIsNull()
        {
            // Arrange
            string phoneNumber = null;
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(phoneNumber));
        }

        [TestMethod]
        public void Parse_ShouldThrowArgumentException_WhenPhoneNumberIsNot10DigitsLong()
        {
            // Arrange
            string phoneNumber = "666";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(phoneNumber));
        }

        [TestMethod]
        public void Parse_ShouldThrowArgumentException_WhenPhoneNumberIsMoreThan10DigitsLong()
        {
            // Arrange
            string phoneNumber = "27365943269536583";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => PhoneNumber.Parse(phoneNumber));
        }

        [TestMethod]
        public void ToString_ShouldReturnFormattedString_WhenPhoneNumberIsParsed()
        {
            // Arrange
            var phoneNumber = PhoneNumber.Parse("0622992575");

            // Act
            var result = phoneNumber.ToString();

            // Assert
            Assert.AreEqual("(062)299-2575", result);
        }
    }
}
