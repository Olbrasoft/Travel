using NUnit.Framework;

using Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography;
using Olbrasoft.Travel.Data.Entity.Model.Geography;


namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Geography
{
    [TestFixture]
    internal class LocalizedRegionConfigurationTest
    {
        [Test]
        public void Instance_Is_GeographyConfiguration_Of_LocalizedRegion()
        {
            //Arrange
            var type = typeof(GeographyConfiguration<LocalizedRegion>);

            //Act
            var configuration = new LocalizedRegionConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}