using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration.Unit.Tests
{
    [TestFixture]
    internal class LocalizedRegionConfigurationTest
    {
        [Test]
        public void Instance_Is_ConfigurationGeography_Of_LocalizedRegion()
        {
            //Arrange
            var type = typeof(ConfigurationGeography<LocalizedRegion>);

            //Act
            var configuration = new LocalizedRegionConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}