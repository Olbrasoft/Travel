using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    internal class AccommodationToAttributeConfigurationTest
    {
        [Test]
        public void Instance_Is_PropertyConfiguration_Of_AccommodationToAttribute()
        {
            //Arrange
            var type = typeof(PropertyConfiguration<AccommodationToAttribute>);

            //Act
            var configuration = new AccommodationToAttributeConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}