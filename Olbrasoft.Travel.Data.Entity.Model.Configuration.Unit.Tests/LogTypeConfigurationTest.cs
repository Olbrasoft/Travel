using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests
{
    [TestFixture]
    internal class LogTypeConfigurationTest
    {
        [Test]
        public void Instance_Is_CreatorConfiguration_of_LogType()
        {
            //Arrange
            var type = typeof(CreatorConfiguration<LogType>);

            //Act
            var logTypeConfiguration= new LogTypeConfiguration();

            //Assert
            Assert.IsInstanceOf(type,logTypeConfiguration);
        }
    }
}