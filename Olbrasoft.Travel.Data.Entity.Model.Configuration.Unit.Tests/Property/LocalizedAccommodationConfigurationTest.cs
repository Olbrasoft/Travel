using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    internal class LocalizedAccommodationConfigurationTest
    {
        [Test]
        public void Instance_Is_LocalizedConfiguration_Of_LocalizedAccommodation()
        {
            //Arrange
            var type = typeof(Configuration.Property.LocalizedConfiguration<LocalizedAccommodation>);

            //Act
            var configuration = new LocalizedAccommodationConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}