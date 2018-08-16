using Moq;
using NUnit.Framework;
using Olbrasoft.DataAccessLayer;
using Olbrasoft.Travel.Data.Entity;


namespace Olbrasoft.Travel.BusinessLogicLayer.UnitTest
{
    [TestFixture]
    public class AccommodationsFacadeUnitTest
    {
        [Test]
        public void CreateInstanceOfTypeAccommodationsFacade()
        {
            //Arrange
            var moqQuery = new Mock<IQuery<Accommodation>>();
            var accommodationsFacade = new AccommodationsFacade(moqQuery.Object);

            //Act
            var type = typeof(AccommodationsFacade);

            //Assert
            Assert.IsInstanceOf(type, accommodationsFacade);

        }
    }
}
