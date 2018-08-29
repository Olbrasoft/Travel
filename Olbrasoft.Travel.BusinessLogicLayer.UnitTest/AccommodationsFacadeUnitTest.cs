using Moq;
using NUnit.Framework;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Shared.Pagination.Web.Mvc;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.DataTransferObject;
using System.Collections.Generic;
using Olbrasoft.Data.Entity;
using Olbrasoft.Design.Pattern.Behavior;
using X.PagedList;

namespace Olbrasoft.Travel.BusinessLogicLayer.UnitTest
{
    [TestFixture]
    public class AccommodationsFacadeUnitTest
    {

        [Test]
        public void Is_Instance_Of_IAccommodationFacade()
        {
            //Arrange
            var type = typeof(IFacade);
            var pagedQuery = LocalizedPagedQuery;

            //Act
            var accommodationsFacade = new AccommodationsFacade(pagedQuery.Object);
            
            //Assert
            Assert.IsInstanceOf(type, accommodationsFacade);

        }

        private static Mock<ILocalizedPagedQuery<Accommodation>> LocalizedPagedQuery => new Mock<ILocalizedPagedQuery<Accommodation>>();

        [Test]
        public void GetPage_IsNotNull()
        {
            //Arrange
            var accommodationsFacade = AccommodationsFacade();

            var pageInfo = new Mock<IPageInfo>();

            //Act
            var accommodations = accommodationsFacade.AccommodationDataTransferObjects(pageInfo.Object);

            //Assert
            Assert.IsNotNull(accommodations);
        }

        
        [Test]
        public void Map_returns_an_bject_that_is_instance_of_IPagedList_of_AccommodationDataTransferObject()
        {
            //Arrange
            var accommodationsFacade = new SomeAccommodationsFacade(LocalizedPagedQuery.Object);
            var pagedList = new Mock<IPagedList<Accommodation>>().Object;

            //Act
            var accommodations = accommodationsFacade.Map(pagedList);

            //Assert
            Assert.IsInstanceOf<IPagedList<AccommodationDataTransferObject>>(accommodations);
        }


        private static AccommodationsFacade AccommodationsFacade()
        {
            return new AccommodationsFacade(LocalizedPagedQuery.Object);
        }


        private class SomeAccommodationsFacade:AccommodationsFacade
        {
        

            public new IPagedList<AccommodationDataTransferObject> Map(IPagedList<Accommodation> pagedList)
            {
                return base.Map(pagedList);
            }


            public SomeAccommodationsFacade(ILocalizedPagedQuery<Accommodation> accommodations) : base(accommodations)
            {
            }
        }


        //[Test]
        //public void CreateInstanceOfTypeAccommodationsFacade()
        //{
        //    //Arrange
        //    var accommodationsFacade = AccommodationsFacade;

        //    //Act
        //    var type = typeof(AccommodationsFacade);

        //    //Assert
        //    Assert.IsInstanceOf(type, accommodationsFacade);
        //}

        //private static AccommodationsFacade AccommodationsFacade
        //{
        //    get
        //    {
        //        var moqQuery = new Mock<IQuery<Accommodation>>();

        //        var accommodationsFacade = new AccommodationsFacade(moqQuery.Object);
        //        return accommodationsFacade;
        //    }
        //}

        //[Test]
        //public void GetReturnInstanceOf()
        //{
        //    //Arrange
        //    var accommodationsFacade = AccommodationsFacade;

        //    //Act
        //    var pageModel = accommodationsFacade.Get(PageInfo);

        //    //Assert
        //    Assert.IsInstanceOf<IPageModel<AccommodationDataTransferObject>>(pageModel);
        //}

        //[Test]
        //public void GetItemsInstanceOf()
        //{
        //    //Arrange
        //    var aF = AccommodationsFacade;
        //    var pageModel = aF.Get(PageInfo);

        //    //Act
        //    var items = pageModel.Items;

        //    //Assert
        //    Assert.IsInstanceOf<IEnumerable<AccommodationDataTransferObject>>(items);
        //}

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