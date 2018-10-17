using System.Data.Entity.ModelConfiguration;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests
{
    [TestFixture]
    internal class LogLevelConfigurationTest
    {
        [Test]
        public void Instance_Is_EntityTypeConfiguration_Of_LogLevel()
        {
            //Arrange
            var type = typeof(EntityTypeConfiguration<LogLevel>);

            //Act
            var configuration = new LogLevelConfiguration();

            //Assert
            Assert.IsInstanceOf(type,configuration);

        }
    }
}