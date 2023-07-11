using static ConversionTests.Main;

namespace ConversionTests
{
    //[TestClass]
    //public class Class1
    //{
    //    [TestMethod]
    //    public void TestsMethod1()
    //    {
    //        var user = new User();

    //        Assert.ThrowsException<ArgumentException>(() => ThrowArg());
    //    }

    //    private void ThrowArg() => throw new ArgumentException();

    //    //xUnit [fact]...
    //    [TestMethod]
    //    public void TestMethod2()
    //    {
    //        var x = 1;
    //        Assert.AreEqual(1, x);
    //    }
    //}

    //[TestClass]
    //public class Class2
    //{
    //    [TestMethod]
    //    public void TestMethod2()
    //    {
    //        var count = 0;

    //        Assert.AreEqual(0, count);
    //    }

    //    [TestMethod]
    //    public void TestMethod1()
    //    {
    //        var count = 0;

    //        Assert.AreEqual(0, count);
    //    }
    //}

    [TestClass]
    public class Main_MSTest_AdvancedTest
    {
        [TestMethod]
        public void ReverseString_ValidString_ReturnsReversedString()
        {

            // Arrange
            string input = "Hello, World!";
            string expectedOutput = "!dlroW ,olleH";
            StringManipulator stringManipulator = new StringManipulator();

            // Act
            string actualOutput = stringManipulator.ReverseString(input);

            // Assert

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
