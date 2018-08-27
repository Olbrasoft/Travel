using Moq;
using NUnit.Framework;
using Olbrasoft.Design.Pattern.Behavior;

namespace Olbrasoft.Design.Pattern.UnitTest
{
    [TestFixture]
    internal class CommandQueryTest
    {
        [Test]
        public void IsInstanceOfQuery()
        {
            //Arrange
            var type = typeof(Query<object>);
            var cmd = new Mock<ICommandWithResult<object>>();

            //Act
            var cq = new CommandQuery<object>(cmd.Object);

            //Assert
            Assert.IsInstanceOf(type, cq);
        }

        [Test]
        public void ExecuteReturnsNotIsNull()
        {
            //Arrange
            var cmd = new Mock<ICommandWithResult<object>>();
            cmd.Setup(p => p.Result).Returns(new object());
            var cq = new CommandQuery<object>(cmd.Object);

            //Act
            var r = cq.Execute();

            //Assert
            Assert.IsNotNull(r);
        }


        [Test]
        public void The_Execute_method_was_called_the_command_with_the_result()
        {
            
            //Arrange
            var cmd = new Mock<ICommandWithResult<object>>();
            cmd.Setup(p => p.Execute());
            var cq = new CommandQuery<object>(cmd.Object);

            //Act
            cq.Execute();

            //Assert
            cmd.Verify(c => c.Execute(), Times.Once());

        }

    }
}