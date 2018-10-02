using Moq;
using NUnit.Framework;
using System.Web.Mvc;

namespace Olbrasoft.Travel.Web.Mvc.Unit.Tests
{
    [TestFixture]
    internal class HtmlHelperExtensionsTest
    {
        [Test]
        public void AccommodationStarRating_Return_String_Empty()
        {
            //Arrange
            const decimal starRating = 0;
            var htmlHelper = HtmlHelper();
            //Act
            var accommodationStarRating = htmlHelper.AccommodationStarRating(starRating);

            //Assert
            Assert.IsTrue(accommodationStarRating == string.Empty);
        }

        private static HtmlHelper HtmlHelper()
        {
            var viewContextMock = new Mock<ViewContext>();
            var viewDataContainerMock = new Mock<IViewDataContainer>();
            var htmlHelper = new HtmlHelper(viewContextMock.Object, viewDataContainerMock.Object);
            return htmlHelper;
        }

        [Test]
        public void AccommodationPaymentTypes_Return_String_Empty()
        {
            //Arrange
            var htmlHelper = HtmlHelper();
            var creditCards = new Data.Transfer.Object.Attribute[0] ;

            //Act
            var payments = htmlHelper.AccommodationPaymentTypes(creditCards);

            //Assert
            Assert.IsTrue(payments == string.Empty);
        }
    }
}