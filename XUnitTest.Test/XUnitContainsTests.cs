using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTest.Test
{
    public class XUnitContainsTests
    {
        [Fact]
        public void String_ShouldContainSubstring()
        {
            Assert.Contains("Hello", "Hello World");
        }

        [Fact]
        public void String_ShouldNotContainSubstring()
        {
            Assert.DoesNotContain("Hello", "World");
        }

        [Fact]
        public void List_ShouldContainSpecifiedElement()
        {
            // Arrange
            List<string> list = new List<string>() { "Hello", "World", "XUnit" };

            // Assert
            Assert.Contains(list, x => x == "Hello");
        }
    }
}
