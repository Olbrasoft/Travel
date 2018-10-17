using NUnit.Framework;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model.Unit.Tests
{
    [TestFixture]
    internal class LogLevelTest
    {
        [Test]
        public void Instance_Is_CreationInfo_Of_Integer()
        {
            //Arrange
            var type = typeof(OwnerCreatorIdAndCreator);

            //Act
            var logLevel = new LogLevel();

            //Assert
            Assert.IsInstanceOf(type, logLevel);
        }

        [Test]
        public void Instance_Implement_Interface_IHaveName()
        {
            //Arrange
            var type = typeof(IHaveName);

            //Act
            var logLevel = new LogLevel();

            //Assert
            Assert.IsInstanceOf(type, logLevel);
        }

        [Test]
        public void Instance_Implement_Interface_IHaveDescription()
        {
            //Arrange
            var type = typeof(IHaveDescription);

            //Act
            var logLevel = new LogLevel();

            //Assert
            Assert.IsInstanceOf(type,logLevel);
        }

    }
}