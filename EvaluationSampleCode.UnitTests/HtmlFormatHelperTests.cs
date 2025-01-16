using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;
using System.Collections.Generic;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper _helper;

        [TestInitialize]
        public void Setup()
        {
            _helper = new HtmlFormatHelper();
        }

        [TestMethod]
        public void GetStrongFormat_ShouldReturnStrongTagWithContent()
        {
            // Arrange
            string content = "Hello World";

            // Act
            var result = _helper.GetStrongFormat(content);

            // Assert
            Assert.AreEqual("<strong>Hello World</strong>", result);
        }

        [TestMethod]
        public void GetItalicFormat_ShouldReturnItalicTagWithContent()
        {
            // Arrange
            string content = "Hello World";

            // Act
            var result = _helper.GetItalicFormat(content);

            // Assert
            Assert.AreEqual("<i>Hello World</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_ShouldReturnCorrectHtmlList()
        {
            // Arrange
            var contents = new List<string> { "Item1", "Item2", "Item3" };

            // Act
            var result = _helper.GetFormattedListElements(contents);

            // Assert
            Assert.AreEqual("<ul><li>Item1</li><li>Item2</li><li>Item3</li></ul>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_ShouldReturnEmptyListForEmptyInput()
        {
            // Arrange
            var contents = new List<string>();

            // Act
            var result = _helper.GetFormattedListElements(contents);

            // Assert
            Assert.AreEqual("<ul></ul>", result);
        }
    }
}