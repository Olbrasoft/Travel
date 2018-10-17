using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Globalization
{
    [TestFixture]
    internal class LocalizedAccommodationConfigurationTest
    {
        [Test]
        public void Instance_Is_LocalizedConfiguration_Of_LocalizedAccommodation()
        {
            //Arrange
            var type = typeof(LocalizedConfiguration<LocalizedAccommodation>);

            //Act
            var configuration = new LocalizedAccommodationConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}