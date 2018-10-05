using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    internal class PhotoOfAccommodationConfigurationTest
    {
        [Test]
        public void Instance_Is_CreatorConfiguration_Of_PhotoOfAccommodation()
        {
            //Arrange
            var type = typeof(Configuration.Property.CreatorConfiguration<PhotoOfAccommodation>);

            //Act
            var configuration = new PhotoOfAccommodationConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}