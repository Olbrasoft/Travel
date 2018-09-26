using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Query;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Business.Facades;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Business.Unit.Tests
{
    [TestFixture]
    internal class AccommodationsFacadeTest
    {
        [Test]
        public void Instance_Implement_Interfaces()
        {
            //Arrange
            var type = typeof(IAccommodations);

            //Act
            var facade = CreateAccommodationsFacade();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.IsInstanceOf(type, facade);
            });
        }

        [Test]
        public void Get_Return_AccommodationDetail()
        {
            //Arrange
            IAccommodations facade = CreateAccommodationsFacade();
            const int languageId = 1033;
            const int id = 1;

            //Act
            var accommodationDetail = facade.Get(id, languageId);

            //Assert
            Assert.IsInstanceOf<AccommodationDetail>(accommodationDetail);
        }

        [Test]
        public void GetAsync_With_CancellationToken_Return_TaskOfAccommodationDetail()
        {
            //Arrange
            IAccommodations facade = CreateAccommodationsFacade();
            const int languageId = 1033;
            const int id = 1;

            //Act
            var accommodationDetailTask = facade.GetAsync(id, languageId, CancellationToken.None);

            //Assert
            Assert.IsInstanceOf<Task<AccommodationDetail>>(accommodationDetailTask);
        }

        [Test]
        public void GetAsync_Return_TaskOfAccommodationDetail()
        {
            //Arrange
            IAccommodations facade = CreateAccommodationsFacade();
            const int languageId = 1033;
            const int id = 1;

            //Act
            var accommodationDetailTask = facade.GetAsync(id, languageId);

            //Assert
            Assert.IsInstanceOf<Task<AccommodationDetail>>(accommodationDetailTask);
        }

        [Test]
        public void Get_Return_PagedList_Of_AccommodationItem()
        {
            //Arrange
            IAccommodations facade = CreateAccommodationsFacade();
            const int languageId = 1033;
            var pagingMock = new Mock<IPageInfo>();

            //Act
            var accommodationItems = facade.Get(pagingMock.Object, languageId, null);

            //Assert
            Assert.IsInstanceOf<IResultWithTotalCount<AccommodationItem>>(accommodationItems);
        }

        [Test]
        public void GetAsync_With_CancellationToken_Return_TaskOfPagedListOfAccommodationItem()
        {
            //Arrange
            IAccommodations facade = CreateAccommodationsFacade();
            const int languageId = 1033;
            var pagingMock = new Mock<IPageInfo>();

            //Act
            var cancellationToken = new CancellationToken();
            var accommodationItemsTask = facade.GetAsync(pagingMock.Object, languageId, null, cancellationToken);

            //Assert
            Assert.IsInstanceOf<Task<IResultWithTotalCount<AccommodationItem>>>(accommodationItemsTask);
        }

        [Test]
        public void GetAsync_Return_TaskOfPagedListOfAccommodationItem()
        {
            //Arrange
            IAccommodations facade = CreateAccommodationsFacade();
            const int languageId = 1033;
            var pagingMock = new Mock<IPageInfo>();

            //Act
            var accommodationItemsTask = facade.GetAsync(pagingMock.Object, languageId, null);

            //Assert
            Assert.IsInstanceOf<Task<IResultWithTotalCount<AccommodationItem>>>(accommodationItemsTask);
        }

        private static AccommodationsFacade CreateAccommodationsFacade()
        {
            var queryDispatcher = new Mock<IDispatcher>();

            queryDispatcher.Setup(p => p.Dispatch(It.IsAny<GetAccommodationDetailById>()))
                .Returns(new AccommodationDetail());

            var items = new[]
            {
               new AccommodationItem
               {
                   Id = 1
               }
            };

            var result = new ResultWithTotalCount<AccommodationItem>()
            {
                Result = items
            };

            queryDispatcher.Setup(p => p.Dispatch(It.IsAny<GetPagedAccommodationItems>())).Returns(result);

            var queryFactoryMock = new Mock<IFactory>();

            queryFactoryMock.Setup(p => p.Create<GetAccommodationDetailById>())
                .Returns(new GetAccommodationDetailById(queryDispatcher.Object));

            queryFactoryMock.Setup(p => p.Create<GetPagedAccommodationItems>())
                .Returns(new GetPagedAccommodationItems(queryDispatcher.Object));

            queryFactoryMock.Setup(p => p.Create<GetPhotosOfAccommodations>())
                .Returns(new GetPhotosOfAccommodations(queryDispatcher.Object));

            var mockMerger = new AccommodationItemPhotoMerge();

            return new AccommodationsFacade(queryFactoryMock.Object, mockMerger);
        }
    }
}