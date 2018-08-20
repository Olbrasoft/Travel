using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Olbrasoft.DataAccessLayer;
using Olbrasoft.Shared;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Shared.Pagination.Web.Mvc;
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
            var accommodationsFacade = AccommodationsFacade;

            //Act
            var type = typeof(AccommodationsFacade);

            //Assert
            Assert.IsInstanceOf(type, accommodationsFacade);

        }


        private static AccommodationsFacade AccommodationsFacade
        {
            get
            {
                var moqQuery = new Mock<IQuery<Accommodation>>();

                var accommodationsFacade = new AccommodationsFacade(moqQuery.Object);
                return accommodationsFacade;
            }
        }


        [Test]
        public void GetReturnInstanceOf()
        {
            //Arrange
            var accommodationsFacade = AccommodationsFacade;

            //Act
            var pageModel = AccommodationsFacade.Get(PageInfo);

            //Assert
            Assert.IsInstanceOf<IPageModel<AccommodationDataTransferObject>>(pageModel);
        }



        private static IPageInfo PageInfo
        {
            get { return new Mock<IPageInfo>().Object; }
        }


        //[Test]
        //public void AccommodationsFacade_GetTest()
        //{
        //    //Arrange
        //    var accommodationsFacade = AccommodationsFacade();
        //    var pageInfo = new PageInfo();

        //    //Act
        //    var accommodations =  accommodationsFacade.Get(pageInfo);

        //    //Assert
        //    Assert.IsInstanceOf<IEnumerable<AccommodationDataTransferObject>>(accommodations);

        //}




    }
}
