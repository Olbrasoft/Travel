using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration.Unit.Tests
{
    [TestFixture]
    internal class RegionConfigurationTest
    {
        [Test]
        public void Instance_Is_EntityTypeConfiguration_Of_Region()
        {
            //Arrange
            var type = typeof(EntityTypeConfiguration<Region>);

            //Act
            var configuration = new RegionConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}