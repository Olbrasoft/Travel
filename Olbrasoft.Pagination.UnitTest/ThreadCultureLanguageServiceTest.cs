using System.Threading;
using NUnit.Framework;
using Olbrasoft.Shared;

namespace Olbrasoft.Pagination.UnitTest
{
    [TestFixture]
    public class ThreadCultureLanguageServiceTest
    {
        [Test]
        public void Is_Instance_Of_ILanguageService()
        {
            //Arrange
            var type = typeof(ILanguageService);

            //Act
            var threadCultureLanguageService = new ThreadCultureLanguageService();

            //Assert
            Assert.IsInstanceOf(type, threadCultureLanguageService);

        }

        [Test]
        public void CurrentLanguageId_Is_1033()
        {
            //Arrange
            var culture = new System.Globalization.CultureInfo("en-Us");
            Thread.CurrentThread.CurrentCulture = culture;
            var languageService = new ThreadCultureLanguageService();

            //Act
            var r = languageService.CurrentLanguageId;

            //Assert
            Assert.IsTrue(r==1033);

        }

    }

    public class ThreadCultureLanguageService :ILanguageService
    {
        public int CurrentLanguageId => Thread.CurrentThread.CurrentCulture.LCID;
    }
}
