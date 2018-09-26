using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Entity.Query.Handler;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Query.Handler
{
    [TestFixture]
    internal class PhotosByAccommodationIdTest
    {
        [Test]
        public void MyTestMethod()
        {
            //Arrange
            var type =
                typeof(AsyncHandlerWithDependentSource<GetPhotosByAccommodationId, IQueryable<PhotoOfAccommodation>,
                    IEnumerable<AccommodationPhoto>>);

            //Act
            var handler = Handler();

            //Assert
            Assert.IsInstanceOf(type, handler);
        }

        [Test]
        public void HandleAsync()
        {
            //Arrange
            var handler = Handler();
            var dispatcher = new Mock<IDispatcher>();
            var query = new GetPhotosByAccommodationId(dispatcher.Object);

            //Act
            var result = handler.HandleAsync(query);

            //Assert
            Assert.IsInstanceOf<Task<IEnumerable<AccommodationPhoto>>>(result);
        }

        private static PhotosByAccommodationId Handler()
        {
            var photos = new Entities.PhotoOfAccommodation[1].AsQueryable();
            var ownPhotosOfAccommodationsMock = new Mock<IHaveQueryable<PhotoOfAccommodation>>();
            ownPhotosOfAccommodationsMock.Setup(p => p.Queryable).Returns(photos);
            return new PhotosByAccommodationId(ownPhotosOfAccommodationsMock.Object);
        }
    }
}