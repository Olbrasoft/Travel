using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests
{
    [TestFixture]
    internal class PropertyQueryableOwnerTest
    {
        [Test]
        public void Instance_Implement_Interface_IHavePropertyQueryable_Of_TypeOfAccommodation()
        {
            //Arrange
            var type = typeof(IHavePropertyQueryable<TypeOfAccommodation>);
            var contextMock = new Mock<IPropertyContext>();

            //Act
            var queryableOwner = new PropertyQueryableOwner<TypeOfAccommodation>(contextMock.Object);

            //Assert
            Assert.IsInstanceOf(type, queryableOwner);
        }
    }
}