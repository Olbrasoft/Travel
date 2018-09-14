using Moq;
using NUnit.Framework;
using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;
using System.Linq;
using Olbrasoft.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Query.Unit.Tests
{
    [TestFixture]
    internal class LocalizedAccommodationsPagedQueryHandlerTest
    {
        [Test]
        public void Is_Instance_Of_IQueryHandler()
        {
            //Arrange
            var type = typeof(IQueryHandler<LocalizedAccommodationsPagedQuery, IPagedList<LocalizedAccommodation>>);

            var localizedAccommodationsQueryableMock = new Mock<IQueryable<LocalizedAccommodation>>();

            //Act
            var handler = new LocalizedAccommodationsPagedQueryHandler(localizedAccommodationsQueryableMock.Object);

            //Assert
            Assert.IsInstanceOf(type, handler);
        }

        [Test]
        public void Handle()
        {
            //Arrange
            var localizedAccommodationsQueryable = new[]
            {
                new LocalizedAccommodation(),
                new LocalizedAccommodation()
            }.AsQueryable();

            var handler = new LocalizedAccommodationsPagedQueryHandler(localizedAccommodationsQueryable);

            var queryMock = new Mock<ILocalizedAccommodationsPagedQuery>();
            queryMock.Setup(p => p.Sorting).Returns(queryable => queryable.OrderBy(p => p.Id));
            queryMock.Setup(p => p.Paging.PageSize).Returns(2);

            var query = queryMock.Object;

            ////Act
            //var result = handler.Handle(query);

            ////Assert
            //Assert.IsTrue(result.Count == 2);
        }
    }
}