using NUnit.Framework;

using Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography;
using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Geography
{
    [TestFixture]
    internal class AirportConfigurationTest
    {
        [Test]
        public void Instance_Is_GeographyConfiguration_Of_Airport()
        {
            //Arrange
            var type = typeof(GeographyConfiguration<Airport>);

            //Act
            var configuration = new AirportConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}