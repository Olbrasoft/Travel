using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration.Unit.Tests
{
    [TestFixture]
    internal class RegionToTypeConfigurationTest
    {
        [Test]
        public void Instance_Is_EntityTypeConfiguration_Of_RegionToType()
        {
            //Arrange
            var type = typeof(EntityTypeConfiguration<RegionToType>);

            //Act
            var configuration = new RegionToTypeConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}