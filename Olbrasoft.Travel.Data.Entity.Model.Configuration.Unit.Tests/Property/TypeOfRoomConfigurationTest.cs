using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Unit.Tests.Property
{
    [TestFixture]
    internal class TypeOfRoomConfigurationTest
    {
        [Test]
        public void Instance_Is_CreatorConfiguration_Of_TypeOfRoom()
        {
            //Arrange
            var type = typeof(Configuration.Property.CreatorConfiguration<TypeOfRoom>);

            //Act
            var configuration = new TypeOfRoomConfiguration();

            //Assert
            Assert.IsInstanceOf(type, configuration);
        }
    }
}