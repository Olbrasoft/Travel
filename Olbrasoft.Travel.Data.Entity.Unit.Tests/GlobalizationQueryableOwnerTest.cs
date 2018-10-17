using Moq;
using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests
{
    [TestFixture]
    internal class GlobalizationQueryableOwnerTest
    {
        [Test]
        public void Instance_Implement_Interface_IHaveGlobalizationQueryable_Of_Language()
        {
            //Arrange
            var type = typeof(IHaveGlobalizationQueryable<Language>);
            var contextMock = new Mock<IGlobalizationContext>();

            //Act
            var queryableOwner= new GlobalizationQueryableOwner<Language>(contextMock.Object);

            //Assert
            Assert.IsInstanceOf(type,queryableOwner);
        }
    }
}