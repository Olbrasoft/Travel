using Moq;
using NUnit.Framework;
using Olbrasoft.Data;
using Olbrasoft.Shared;
using Olbrasoft.Travel.Business.Facades;
using Olbrasoft.Travel.Business.Mapping;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Objects;

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
            var mockLanguageService = new Mock<ILanguageService>();
            var queryProcessorMock = new Mock<IQueryProcessor>();
            var mapperMock = new Mock<IMapper<LocalizedAccommodation, AccommodationDetailDto>>();

            //Act
            var accommodationsFacade = new LocalizedAccommodationsFacade(mockLanguageService.Object, queryProcessorMock.Object, mapperMock.Object);

            //Assert
            Assert.IsInstanceOf(type, accommodationsFacade);
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