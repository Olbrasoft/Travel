using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Olbrasoft.Data;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Entity.Query.Handler;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Query.Handler
{
    [TestFixture]
    internal class PhotosOfAccommodationsTest
    {
        [Test]
        public void Instance_Is_HandlerWithDependentSource_Of_GetPhotosOfAccommodations_IQueryable_PhotoOfAccommodation_IEnumerable_Of_AccommodationPhoto()
        {
            //Arrange
            var type =
                typeof(HandlerWithDependentSource<GetPhotosOfAccommodations,
                    Entities.PhotoOfAccommodation, IEnumerable<AccommodationPhoto>>);

            //Act
            var handler = CreateHandler();

            //Assert
            Assert.IsInstanceOf(type, handler);
        }

        [Test]
        public void Handle()
        {
            //Arrange
            var handler = CreateHandler();
            var dispatcher= new Mock<IProvider>();
            var query = new GetPhotosOfAccommodations(dispatcher.Object);

            //Act
            var result = handler.Handle(query);

            //Assert
            Assert.IsInstanceOf<IEnumerable<AccommodationPhoto>>(result);
        }


        [Test]
        public void HandleAsync()
        {
            //Arrange
            var handler = CreateHandler();
            var dispatcher = new Mock<IProvider>();
            var query = new GetPhotosOfAccommodations(dispatcher.Object);

            //Act
            var result = handler.HandleAsync(query);
            
            //Assert
            Assert.IsInstanceOf<Task<IEnumerable<AccommodationPhoto>>>(result);
        }

        private static PhotosOfAccommodations CreateHandler()
        {
            var photos = new Entities.PhotoOfAccommodation[1].AsQueryable();
            var ownPhotosOfAccommodationsMock = new Mock<IHaveQueryable<PhotoOfAccommodation>>();


            ownPhotosOfAccommodationsMock.Setup(p => p.Queryable).Returns(photos);
            var projectionMock = new Mock<IProjection>();

            return new PhotosOfAccommodations(ownPhotosOfAccommodationsMock.Object,projectionMock.Object);
        }
    }
}