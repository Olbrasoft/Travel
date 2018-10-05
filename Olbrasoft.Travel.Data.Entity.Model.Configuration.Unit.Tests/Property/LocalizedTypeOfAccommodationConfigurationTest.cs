using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    internal class LocalizedTypeOfAccommodationConfigurationTest
    {
        [Test]
        public void Instance_Is_LocalizedConfiguration_Of_LocalizedTypeOfAccommodation()
        {
            //Arrange
            var type = typeof(Configuration.Property.LocalizedConfiguration<LocalizedTypeOfAccommodation>);

            //Act
            var configuration = new LocalizedTypeOfAccommodationConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}