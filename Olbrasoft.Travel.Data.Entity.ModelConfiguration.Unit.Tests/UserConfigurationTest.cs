using NUnit.Framework;
using Olbrasoft.Travel.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration.Unit.Tests
{
    [TestFixture]
    internal class UserConfigurationTest
    {
        [Test]
        public void Instance_Is_EntityTypeConfiguration_Of_User()
        {
            //Arrange
            var type = typeof(EntityTypeConfiguration<User>);

            //Act
            var configuration = new UserConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}