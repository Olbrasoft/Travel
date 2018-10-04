using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration.Unit.Tests
{
    [TestFixture]
    internal class AirportConfigurationTest
    {
        [Test]
        public void Instance_Is_ConfigurationGeography_Of_Airport()
        {
            //Arrange
            var type = typeof(ConfigurationGeography<Airport>);

            //Act
            var configuration = new AirportConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}