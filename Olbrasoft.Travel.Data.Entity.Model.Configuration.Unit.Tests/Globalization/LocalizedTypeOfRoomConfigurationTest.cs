using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Globalization
{
    [TestFixture]
    internal class LocalizedTypeOfRoomConfigurationTest
    {
        [Test]
        public void Instance_Is_LocalizedConfiguration_Of_LocalizedTypeOfRoom()
        {
            //Arrange
            var type = typeof(LocalizedConfiguration<LocalizedTypeOfRoom>);

            //Act
            var configuration = new LocalizedTypeOfRoomConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}