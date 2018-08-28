using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Olbrasoft.Shared;
using Olbrasoft.Shared.Pagination;
using X.PagedList;

namespace Olbrasoft.Data.Entity.UnitTest
{
    [TestFixture]
    class LcalizedPagedQueryTest
    {
        [Test]
        public void Is_instance_of_ILocalizedPagedQuery()
        {
            //Arrange
            var type = typeof(ILocalizedPagedQuery<object>);
            var queryableOfObjects = new Mock<IQueryable<object>>();
            var languageService = new Mock<ILanguageService>();

            //Act
            var localizedPagedQuery = new SomeLocalizedPagedQuery(queryableOfObjects.Object,languageService.Object);

            //Assert
            Assert.IsInstanceOf(type, localizedPagedQuery);

        }

        [Test]
        public void LanguageService_Is_not_Null()
        {
            //Arrange
            var queryableOfObjects = new Mock<IQueryable<object>>();
            var languageService = new Mock<ILanguageService>();
            var pageInfo = new Mock<IPageInfo>();
            var localizedPagedQuery =
                new SomeLocalizedPagedQuery(queryableOfObjects.Object, pageInfo.Object, languageService.Object);

            //Act
            var result = localizedPagedQuery.LanguageService;

            //Assert
            Assert.IsNotNull(result);

        }

        [Test]
        public void LanguageId_is_1033()
        {
            //Arrange
            var queryableOfObjects = new Mock<IQueryable<object>>();
            var languageService = new Mock<ILanguageService>();
            languageService.Setup(p => p.CurrentLanguageId).Returns(1033);

            var localizedPagedQuery =
                new SomeLocalizedPagedQuery(queryableOfObjects.Object, languageService.Object);

            //Act
            var languageId = localizedPagedQuery.LanguageId;

            //Assert
            Assert.IsTrue(languageId == 1033);

        }

        class SomeLocalizedPagedQuery:LocalizedPagedQuery<Object>
        {
            public new ILanguageService LanguageService => base.LanguageService;

            public new int LanguageId => base.LanguageId;


            public override IPagedList<object> Execute()
            {
                throw new NotImplementedException();
            }

            public SomeLocalizedPagedQuery(IQueryable<object> queryable, IPageInfo pageInfo, ILanguageService languageService) : base(queryable, pageInfo, languageService)
            {
            }

            public SomeLocalizedPagedQuery(IQueryable<object> queryable, ILanguageService languageService) : base(queryable, languageService)
            {
            }
        }
    }
}
