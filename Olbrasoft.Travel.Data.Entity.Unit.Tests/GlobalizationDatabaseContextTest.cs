using NUnit.Framework;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests
{
    [TestFixture]
    internal class GlobalizationDatabaseContextTest
    {
        [Test]
        public void Instance_Is_DbContextWithInjectionConfigurationFactory()
        {
            //Arrange
            var type = typeof(DbContextWithInjectionConfigurationFactory);

            //Act
            var context = new GlobalizationDatabaseContext();

            //Assert
            Assert.IsInstanceOf(type, context);
        }

        [Test]
        public void Instance_Implement_Interface_IGlobalization()
        {
            //Arrange
            var type = typeof(IGlobalizationContext);

            //Act
            var context= new GlobalizationDatabaseContext();

            //Assert
            Assert.IsInstanceOf(type,context);
        }
    }
}