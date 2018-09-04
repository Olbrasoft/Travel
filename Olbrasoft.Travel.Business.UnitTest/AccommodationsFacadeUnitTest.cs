using System.Linq;
using AutoMapper;
using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Entity;
using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Pagination.Linq;
using Olbrasoft.Travel.Business.Facades;
using Olbrasoft.Travel.Business.Mapping;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Business.UnitTest
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
            var mockPagedListMapper = new Mock<IPagedListMapper<Accommodation,AccommodationDto>>();

            //Act
            var accommodationsFacade = new AccommodationsFacade(pagedQuery.Object, mockPagedListMapper.Object);

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
            var accommodations = accommodationsFacade.Get(pageInfo.Object);

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
            Assert.IsInstanceOf<IPagedList<AccommodationDto>>(accommodations);
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

            var pagedCollection = arrayOfAccommodations.AsPagedList();

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

        private static IPagedList<Accommodation> GetAccommodations()
        {
            var arrayOfAccommodations = new[]
            {
                new Accommodation()
            };
            arrayOfAccommodations.First().LocalizedAccommodations.Add(new LocalizedAccommodation { Name = "" });

            return arrayOfAccommodations.AsPagedList();
        }

        private SomeAccommodationsFacade GetSomeAccommodationsFacade()
        {
            var pagedListMapper = PagedListAutoMapper();
            return new SomeAccommodationsFacade(GetLocalizedPagedQuery().Object, pagedListMapper);
        }

        private static PagedListAutoMapper<Accommodation, AccommodationDto> PagedListAutoMapper()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<AccommodationProfile>());
            var mapper = config.CreateMapper();

            var pagedListMapper = new PagedListAutoMapper<Accommodation, AccommodationDto>(mapper);
            return pagedListMapper;
        }

        private AccommodationsFacade CreateAccommodationsFacade()
        {
            var pagedListMapper = PagedListAutoMapper();
            return new AccommodationsFacade(GetLocalizedPagedQuery().Object,pagedListMapper);
        }

        private class SomeAccommodationsFacade : AccommodationsFacade
        {
            public new IPagedList<AccommodationDto> Map(IPagedList<Accommodation> pagedList)
            {
                return base.Map(pagedList);
            }

            public SomeAccommodationsFacade(ILocalizedPagedQuery<Accommodation> localizedPagedQueryOfAccommodation, IPagedListMapper<Accommodation, AccommodationDto> mapper ) : base(localizedPagedQueryOfAccommodation,mapper)
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