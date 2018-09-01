using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Entity;
using Olbrasoft.Shared;
using Olbrasoft.Travel.Data.Entities;
using System.Linq;
using Olbrasoft.Travel.Data.Entity.Queries;

namespace Olbrasoft.Travel.Data.Entity.UnitTest
{
    [TestFixture]
    public class AccommodationPagedQueryTest
    {
        [Test]
        public void Is_Instance_Of_IPagedQuery()
        {
            //Arrange
            var type = typeof(IPagedQuery<object>);
            var mockQueryableOfAccommodation = new Mock<IQueryable<Accommodation>>();
            var mockLanguageService = new Mock<ILanguageService>();

            //Act
            var query = new AccommodationPagedQuery(mockQueryableOfAccommodation.Object, mockLanguageService.Object);

            //Assert
            Assert.IsInstanceOf(type, query);
        }
    }
}