using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Olbrasoft.Data.Entity;
using Olbrasoft.Shared;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.Queries.UnitTest
{
    [TestClass]
    public class LocalizedAccommodationDetailQueryTest
    {
        [TestMethod]
        public void Is_Instance_Of_LocalizedQuery()
        {
            //Arrange
            var type = typeof(LocalizeQuery<LocalizedAccommodation>);

            //Act
            var localizedAccommodationDetailQuery = LocalizedAccommodationDetailQuery();

            Assert.IsInstanceOfType( localizedAccommodationDetailQuery,type);
        }

        private static LocalizedAccommodationDetailQuery LocalizedAccommodationDetailQuery()
        {
            var mockLanguageService = new Mock<ILanguageService>();
            return new LocalizedAccommodationDetailQuery(mockLanguageService.Object);
        }
    }

    public class LocalizedAccommodationDetailQuery : LocalizeQuery<LocalizedAccommodation>
    {
        public LocalizedAccommodationDetailQuery(ILanguageService languageService) : base(languageService)
        {
        }

        public override LocalizedAccommodation Execute()
        {
            throw new NotImplementedException();
        }
    }
}