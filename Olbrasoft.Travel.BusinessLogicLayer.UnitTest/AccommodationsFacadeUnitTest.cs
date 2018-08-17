using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Olbrasoft.DataAccessLayer;
using Olbrasoft.Shared;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.DataTransferObject;


namespace Olbrasoft.Travel.BusinessLogicLayer.UnitTest
{
    [TestFixture]
    public class AccommodationsFacadeUnitTest
    {
        [Test]
        public void CreateInstanceOfTypeAccommodationsFacade()
        {

            //Arrange
            var accommodationsFacade = AccommodationsFacade();

            //Act
            var type = typeof(AccommodationsFacade);

            //Assert
            Assert.IsInstanceOf(type, accommodationsFacade);

        }

        private static AccommodationsFacade AccommodationsFacade()
        {
            var moqQuery = new Mock<IQuery<Accommodation>>();

            var accommodationsFacade = new AccommodationsFacade(moqQuery.Object);
            return accommodationsFacade;
        }

        [Test]
        public void AccommodationsFacade_GetTest()
        {
            //Arrange
            var accommodationsFacade = AccommodationsFacade();
            var pageInfo = new PageInfo();

            //Act
            var accommodations =  accommodationsFacade.Get(pageInfo);

            //Assert
            Assert.IsInstanceOf<IEnumerable<AccommodationDataTransferObject>>(accommodations);

        }




    }
}
