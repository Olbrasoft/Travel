using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Model.Unit.Tests
{
    [TestFixture]
    internal class LogTypeTest
    {
        [Test]
        public void Instance_Is_CreationInfo_Of_Integer()
        {
            //Arrange
            var type = typeof(CreationInfo<int>);

            //Act
            var typeOfLog = new LogType();

            //Assert
            Assert.IsInstanceOf(type, typeOfLog);
        }

        [Test]
        public void Instance_Implement_Interface_IHaveName()
        {
            //Arrange
            var type = typeof(IHaveName);

            //Act
            var typeOfLog = new LogType();

            //Assert
            Assert.IsInstanceOf(type, typeOfLog);
        }
    }
}