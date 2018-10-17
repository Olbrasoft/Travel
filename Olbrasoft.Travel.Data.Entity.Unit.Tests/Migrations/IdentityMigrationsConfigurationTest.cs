using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Migrations;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Migrations
{
    [TestFixture]
    internal class IdentityMigrationsConfigurationTest
    {
        [Test]
        public void Instance_Is_DatabaseMigrationsConfiguration_Of_IdentityDatabaseContext()
        {
            //Arrange
            var type = typeof(DatabaseMigrationsConfiguration<IdentityDatabaseContext>);

            //Act
            var configuration = new IdentityMigrationsConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}