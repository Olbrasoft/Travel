using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Migrations;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Migrations
{
    [TestFixture]
    internal class PropertyMigrationsConfigurationTest
    {
        [Test]
        public void Instance_Is_DatabaseMigrationsConfiguration_Of_PropertyDatabaseContext()
        {
            //Arrange
            var type = typeof(DatabaseMigrationsConfiguration<PropertyDatabaseContext>);

            //Act
            var configuration = new PropertyMigrationsConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }

        [Test]
        public void MigrationsDirectory_Is_Migrations_Back_Slash_Property()
        {
            //Arrange

            var configuration = new PropertyMigrationsConfiguration();

            //Act
            var migrationsDirectory = configuration.MigrationsDirectory;

            //Assert
            Assert.IsTrue(migrationsDirectory == "Migrations\\Property");
        }

        [Test]
        public void MigrationsNamespace_Ends_With_Dot_Property()
        {
            //Arrange
            var configuration = new PropertyMigrationsConfiguration();

            //Act
            var migrationsNamespace = configuration.MigrationsNamespace;

            //Assert
            Assert.IsTrue(migrationsNamespace.EndsWith(".Property"));
        }
    }
}