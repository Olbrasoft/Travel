using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    internal class LocalizedTypeOfRoomConfigurationTest
    {
        [Test]
        public void Instance_Is_LocalizedConfiguration_Of_LocalizedTypeOfRoom()
        {
            //Arrange
            var type = typeof(Configuration.Property.LocalizedConfiguration<LocalizedTypeOfRoom>);

            //Act
            var configuration = new LocalizedTypeOfRoomConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}