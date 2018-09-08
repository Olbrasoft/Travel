using AutoMapper;
using Moq;
using NUnit.Framework;
using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Pagination.Linq;
using Olbrasoft.Pagination.UnitTest;
using Olbrasoft.Shared;
using Olbrasoft.Travel.Business.Facades;
using Olbrasoft.Travel.Business.Mapping;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Objects;
using System.Linq;
using Olbrasoft.Data;

namespace Olbrasoft.Travel.Business.UnitTest
{
    [TestFixture]
    public class LocalizedAccommodationsFacadeUnitTest
    {
        [Test]
        public void Is_Instance_Of_IAccommodationFacade()
        {
            //Arrange
            var type = typeof(IFacade);
            var pagedQuery = GetLocalizedPagedQuery();
            var mockPagedListMapper = new Mock<IPagedListMapper<LocalizedAccommodation, AccommodationDto>>();
            var mockLanguageService = new Mock<ILanguageService>();
            var queryProcessorMock = new Mock<IQueryProcessor>();


            //Act
            var accommodationsFacade = new LocalizedAccommodationsFacade(pagedQuery.Object, mockLanguageService.Object, mockPagedListMapper.Object, queryProcessorMock.Object);

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

        private static Mock<Design.Pattern.Behavior.IQuery<IQueryArgument, IPagedList<LocalizedAccommodation>>> GetLocalizedPagedQuery()
        {
            var result = new Mock<Design.Pattern.Behavior.IQuery< IQueryArgument, IPagedList<LocalizedAccommodation>>>();
            
            result.Setup(p => p.Execute(It.IsAny<IQueryArgument>())).Returns(GetAccommodations());

            return result;
        }

        private static IPagedList<LocalizedAccommodation> GetAccommodations()
        {
            var arrayOfAccommodations = new[]
            {
                new LocalizedAccommodation(),
            };

            var accommodation= new Accommodation(){Address = ""};

            arrayOfAccommodations.First().Accommodation = accommodation;

            return arrayOfAccommodations.AsPagedList();
        }

        private static PagedListAutoMapper<LocalizedAccommodation, AccommodationDto> PagedListAutoMapper()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<LocalizedAccommodationProfile>());
            var mapper = config.CreateMapper();

            var pagedListMapper = new PagedListAutoMapper<LocalizedAccommodation, AccommodationDto>(mapper);
            return pagedListMapper;
        }

        private LocalizedAccommodationsFacade CreateAccommodationsFacade()
        {
            var pagedListMapper = PagedListAutoMapper();
            var languageService = new ThreadCultureLanguageService();
            var queryProcessorMock = new Mock<IQueryProcessor>();

            return new LocalizedAccommodationsFacade(GetLocalizedPagedQuery().Object, languageService, pagedListMapper, queryProcessorMock.Object);
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