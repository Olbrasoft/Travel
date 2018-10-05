using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    internal class AccommodationConfigurationTest
    {
        [Test]
        public void Instance_Is_CreatorConfiguration_Of_Accommodation()
        {
            //Arrange
            var type = typeof(Configuration.Property.CreatorConfiguration<Accommodation>);

            //Act
            var configuration = new AccommodationConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}