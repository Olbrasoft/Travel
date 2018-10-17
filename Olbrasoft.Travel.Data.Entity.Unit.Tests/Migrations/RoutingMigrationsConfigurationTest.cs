using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Migrations;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Migrations
{
    [TestFixture]
    internal class RoutingMigrationsConfigurationTest
    {
        [Test]
        public void Instance_Is_DatabaseMigrationsConfiguration_Of_RoutingDatabaseContext()
        {
            //Arrange
            var type = typeof(DatabaseMigrationsConfiguration<RoutingDatabaseContext>);

            //Act
            var configuration= new RoutingMigrationsConfiguration();

            //Assert
            Assert.IsInstanceOf(type,configuration);
        }


        [Test]
        public void MigrationsDirectory_Is_Migrations_Back_Slash_Routing()
        {
            //Arrange
            var configuration = new RoutingMigrationsConfiguration();

            //Act
            var directory = configuration.MigrationsDirectory;

            //Assert
            Assert.IsTrue(directory=="Migrations\\Routing");

        }

        [Test]
        public void MigrationsNamespace_Ends_With_Dot_Routing()
        {
            //Arrange
            var configuration = new RoutingMigrationsConfiguration();

            //Act
            var migrationsNamespace = configuration.MigrationsNamespace;

            //Assert
            Assert.IsTrue(migrationsNamespace.EndsWith(".Routing"));
        }

    }
}