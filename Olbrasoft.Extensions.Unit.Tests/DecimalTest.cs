using NUnit.Framework;

namespace Olbrasoft.Extensions.Unit.Tests
{
    [TestFixture]
    internal class DecimalTest
    {
        [Test]
        public void IsInteger_Return_True()
        {
            //Arrange
            var d = new decimal(3.0);

            //Act
            var result = d.IsInteger();

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsInteger_Return_False()
        {
            //Arrange
            var d = new decimal(3.5);

            //Act
            var result = d.IsInteger();

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Zero_Is_Integer()
        {
            //Arrange
            var d = new decimal(0.00);

            //Act
            var result = d.IsInteger();

            //Assert
            Assert.IsTrue(result);
        }
    }
}