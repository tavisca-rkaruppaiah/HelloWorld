using System;
using Xunit;
using HelloWorld;

namespace XUnitTestForHelloWorld
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string expected = "Hello";
            Assert.Equal(expected, Program.PrintHello());
        }
    }
}
