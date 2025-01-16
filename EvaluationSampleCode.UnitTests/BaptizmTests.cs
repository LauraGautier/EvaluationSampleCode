using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class BaptizmTests
    {
        private Baptizm _baptizm;

        [TestMethod]
        public void CanBeBaptizedBy_Priest_ShouldReturnTrue()
        {
            // Arrange
            var priest = new ClergyMember { IsPriest = true };
            _baptizm = new Baptizm(priest);

            // Act
            var result = _baptizm.CanBeBaptizedBy(priest);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeBaptizedBy_Pope_ShouldReturnTrue()
        {
            // Arrange
            var pope = new ClergyMember { IsPope = true };
            _baptizm = new Baptizm(pope);

            // Act
            var result = _baptizm.CanBeBaptizedBy(pope);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeBaptizedBy_NonClergy_ShouldReturnFalse()
        {
            // Arrange
            var nonClergy = new ClergyMember { IsPriest = false, IsPope = false };
            _baptizm = new Baptizm(nonClergy);

            // Act
            var result = _baptizm.CanBeBaptizedBy(nonClergy);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_CorrectClergy_ShouldReturnTrue()
        {
            // Arrange
            var clergyMember = new ClergyMember();
            _baptizm = new Baptizm(clergyMember);

            // Act
            var result = _baptizm.CanBeTeachedBy(clergyMember);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeTeachedBy_WrongClergy_ShouldReturnFalse()
        {
            // Arrange
            var clergyMember = new ClergyMember();
            var wrongClergyMember = new ClergyMember();
            _baptizm = new Baptizm(clergyMember);

            // Act
            var result = _baptizm.CanBeTeachedBy(wrongClergyMember);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
