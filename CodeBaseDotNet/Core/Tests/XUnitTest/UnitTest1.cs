using System;
using Xunit;
using Common.Core;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void GetMessageTest()
        {
          Assert.Equal("Hello World!", Sample.GetMessage());
        }

        [Theory]
        [InlineData("Mohan")]
        [InlineData("Sanjeevi")]
        [InlineData("Prasanna")]
        [InlineData(null)]
        public void GetMessageNameTest(string name)
        {
          Assert.Equal("Hello " + name + "!", Sample.GetMessage(name));
        }

        [Theory]
        [InlineData(16, 10, 26)]
        [InlineData(8, 5, 13)]
        public void AddTest(int number1, int number2, int expected)
        {
          Assert.Equal(expected, Sample.Add(number1, number2));
        }
    }
}
