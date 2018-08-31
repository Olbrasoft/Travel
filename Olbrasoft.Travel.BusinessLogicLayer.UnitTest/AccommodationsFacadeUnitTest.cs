using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Entity;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.DataTransferObject;
using System.Linq;
using Olbrasoft.Shared.Linq;

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
            var pagedQuery = GetLocalizedPagedQuery();

            //Act
            var accommodationsFacade = new AccommodationsFacade(pagedQuery.Object);

            //Assert
            Assert.IsInstanceOf(type, accommodationsFacade);
        }

        [Test]
        public void GetPage_IsNotNull()
        {
            //Arrange
            var accommodationsFacade = CreateAccommodationsFacade();

            var pageInfo = new Mock<IPageInfo>();

            //Act
            var accommodations = accommodationsFacade.AccommodationDataTransferObjects(pageInfo.Object);

            //Assert
            Assert.IsNotNull(accommodations);
        }

        [Test]
        public void Map_returns_an_bject_that_is_instance_of_IPagedEnumerable_of_AccommodationDataTransferObject()
        {
            //Arrange
            var accommodationsFacade = GetSomeAccommodationsFacade();
            var pagedList = GetAccommodations();

            //Act
            var accommodations = accommodationsFacade.Map(pagedList);

            //Assert
            Assert.IsInstanceOf<IPagedEnumerable<AccommodationDataTransferObject>>(accommodations);
        }

        [Test]
        public void Map_First_Name_Is_Jirka()
        {
            //Arrange
            var accommodationsFacade = GetSomeAccommodationsFacade();

            var arrayOfAccommodations = new[]
            {
                new Accommodation()
            };

            arrayOfAccommodations.First().LocalizedAccommodations.Add(new LocalizedAccommodation { Name = "Jirka" });

            var pagedCollection = arrayOfAccommodations.AsPagedEnumerable();

            var accommodations = accommodationsFacade.Map(pagedCollection);

            //Act
            var result = accommodations.FirstOrDefault()?.Name;

            //Assert
            Assert.IsTrue(result == "Jirka");
        }

        private static Mock<ILocalizedPagedQuery<Accommodation>> GetLocalizedPagedQuery()
        {
            var result = new Mock<ILocalizedPagedQuery<Accommodation>>();


            //result.Setup(p => p.Execute()).Returns(pagedCollection);
            result.Setup(p => p.Execute(It.IsAny<IPageInfo>())).Returns(GetAccommodations);

            return result;
        }

        private static IPagedEnumerable<Accommodation> GetAccommodations()
        {
            var arrayOfAccommodations = new[]
            {
                new Accommodation()
            };
            arrayOfAccommodations.First().LocalizedAccommodations.Add(new LocalizedAccommodation { Name = "" });

            return arrayOfAccommodations.AsPagedEnumerable();
        }
        

        private SomeAccommodationsFacade GetSomeAccommodationsFacade()
        {
            return new SomeAccommodationsFacade(GetLocalizedPagedQuery().Object);
        }

        private AccommodationsFacade CreateAccommodationsFacade()
        {
            return new AccommodationsFacade(GetLocalizedPagedQuery().Object);
        }

        private class SomeAccommodationsFacade : AccommodationsFacade
        {
            public new IPagedEnumerable<AccommodationDataTransferObject> Map(IPagedEnumerable<Accommodation> pagedList)
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
        //    var accommodationsFacade = CreateAccommodationsFacade;

        //    //Act
        //    var type = typeof(CreateAccommodationsFacade);

        //    //Assert
        //    Assert.IsInstanceOf(type, accommodationsFacade);
        //}

        //private static CreateAccommodationsFacade CreateAccommodationsFacade
        //{
        //    get
        //    {
        //        var moqQuery = new Mock<IQuery<Accommodation>>();

        //        var accommodationsFacade = new CreateAccommodationsFacade(moqQuery.Object);
        //        return accommodationsFacade;
        //    }
        //}

        //[Test]
        //public void GetReturnInstanceOf()
        //{
        //    //Arrange
        //    var accommodationsFacade = CreateAccommodationsFacade;

        //    //Act
        //    var pageModel = accommodationsFacade.Get(PageInfo);

        //    //Assert
        //    Assert.IsInstanceOf<IPageModel<AccommodationDataTransferObject>>(pageModel);
        //}

        //[Test]
        //public void GetItemsInstanceOf()
        //{
        //    //Arrange
        //    var aF = CreateAccommodationsFacade;
        //    var pageModel = aF.Get(PageInfo);

        //    //Act
        //    var items = pageModel.Items;

        //    //Assert
        //    Assert.IsInstanceOf<IEnumerable<AccommodationDataTransferObject>>(items);
        //}

        //[Test]
        //public void AccommodationsFacade_GetTest()
        //{
        //    //Arrange
        //    var accommodationsFacade = CreateAccommodationsFacade();
        //    var pageInfo = new PageInfo();

        //    //Act
        //    var accommodations =  accommodationsFacade.Get(pageInfo);

        //    //Assert
        //    Assert.IsInstanceOf<IEnumerable<AccommodationDataTransferObject>>(accommodations);

        //}
    }
}