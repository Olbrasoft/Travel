using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration.Unit.Tests
{
    [TestFixture]
    internal class CountryConfigurationTest
    {
        [Test]
        public void Instance_Is_ConfigurationGeography()
        {
            //Arrange
            var type = typeof(ConfigurationGeography<Country>);

            //Act
            var configuration = new CountryConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}