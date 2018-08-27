using Moq;
using NUnit.Framework;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Shared.Pagination.Web.Mvc;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.DataTransferObject;
using System.Collections.Generic;
using Olbrasoft.Design.Pattern.Behavior;

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
            var pageModel = accommodationsFacade.Get(PageInfo);

            //Assert
            Assert.IsInstanceOf<IPageModel<AccommodationDataTransferObject>>(pageModel);
        }

        [Test]
        public void GetItemsInstanceOf()
        {
            //Arrange
            var aF = AccommodationsFacade;
            var pageModel = aF.Get(PageInfo);

            //Act
            var items = pageModel.Items;

            //Assert
            Assert.IsInstanceOf<IEnumerable<AccommodationDataTransferObject>>(items);
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