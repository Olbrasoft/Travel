using Moq;
using NUnit.Framework;
using Olbrasoft.Design.Pattern.Behavior;

namespace Olbrasoft.Design.Pattern.UnitTest
{
    [TestFixture]
    public class CommandWithResultTest
    {
        [Test]
        public void IsInstanceOfICommandWithResult()
        {
            //Arrange
            var type = typeof(ICommandWithResult<object>);

            //Act
            var command = new Mock<CommandWithResult<object>>();

            //Assert
            Assert.IsInstanceOf(type, command.Object);
        }

        [Test]
        public void ResultGet()
        {
            //Arrange
            var boolCommandPattern = new BoolCommandPattern();

            //Act
            boolCommandPattern.Execute();

            //Assert
            Assert.IsTrue(boolCommandPattern.Result);
        }
    }

    public class BoolCommandPattern : CommandWithResult<bool>
    {
        protected override bool Get()
        {
            return true;
        }
    }
}