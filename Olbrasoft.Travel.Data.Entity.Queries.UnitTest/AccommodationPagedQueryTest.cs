using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Olbrasoft.Data.Entity;
using Olbrasoft.Shared;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.Queries.UnitTest
{
    [TestClass]
    public class AccommodationPagedQueryTest
    {
        [TestMethod]
        public void Is_Instance_Of_IPagedQuery()
        {
            //Arrange
            var type = typeof(IPagedQuery<object>);
            var mockQueryableOfAccommodation = new Mock<IQueryable<Accommodation>>();
            var mockLanguageService = new Mock<ILanguageService>();

            //Act
            var query = new AccommodationPagedQuery(mockQueryableOfAccommodation.Object, mockLanguageService.Object);

            //Assert
            Assert.IsInstanceOfType( query,type);
        }
    }
}