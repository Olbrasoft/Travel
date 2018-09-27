using Moq;
using NUnit.Framework;
using Olbrasoft.Collections.Generic;
using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Unit.Tests;
using System.Linq;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.Query.Unit.Tests
{
    [TestFixture]
    internal class LocalizedAccommodationsPagedQueryHandlerTest : IHaveQueryable<LocalizedAccommodation>
    {
        [Test]
        public void Is_Instance_Of_IQueryHandler()
        {
            //Arrange
            var type = typeof(IHandle<LocalizedAccommodationsPagedQuery, IPagedList<LocalizedAccommodation>>);

            var localizedAccommodationsQueryableMock = new Mock<IHaveQueryable<LocalizedAccommodation>>();
            var projectionMock = new Mock<IProjection>();

            //Act
            var handler =
                new LocalizedAccommodationsPagedHandlerWithDependentSource(localizedAccommodationsQueryableMock.Object,
                    projectionMock.Object);

            //Assert
            Assert.IsInstanceOf(type, handler);
        }

        [Test]
        public void Handle()
        {
            //Arrange




            var projectionMock = new Mock<IProjection>();
            var result =
                new LocalizedAccommodationsPagedHandlerWithDependentSource(this,
                    projectionMock.Object);

            var queryMock = new Mock<ILocalizedAccommodationsPagedQuery>();
            queryMock.Setup(p => p.Sorting).Returns(queryable => queryable.OrderBy(p => p.Id));
            queryMock.Setup(p => p.Paging.PageSize).Returns(2);

            var query = queryMock.Object;

            Assert.IsInstanceOf<ILocalizedAccommodationsPagedQuery>(query);

            ////Act
            //var result = handler.Handle(query);

            ////Assert
            //Assert.IsTrue(result.Count == 2);
        }

        public IQueryable<LocalizedAccommodation> Queryable => new[]
        {
            new LocalizedAccommodation(),
            new LocalizedAccommodation()
        }.AsQueryable();
    }
}

