using Moq;
using NUnit.Framework;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Shared.Pagination.Web.Mvc;
using Olbrasoft.Travel.BusinessLogicLayer;
using Olbrasoft.Travel.DataTransferObject;
using Olbrasoft.Travel.Web.Mvc.Controllers;
using System.Web.Mvc;

namespace Olbrasoft.Travel.Web.Mvc.UnitTest
{
    [TestFixture()]
    public class HomeControllerTest
    {
        public HomeController HomeController { get; private set; }

        //[SetUp]
        //public void Setup()
        //{
        //    var pageInfo = new Mock<IPageInfo>();
        //    var accommodationsFacade = new Mock<IAccommodationsFacade>();

        //    var items = new AccommodationDataTransferObject[10];
        //    var paging = new Mock<IPaging>();
        //    var pageModel = new PageModel<AccommodationDataTransferObject>(items, paging.Object);

        //    accommodationsFacade.Setup(p => p.Get(It.IsAny<IPageInfo>())).Returns(pageModel);
        //    HomeController = new HomeController(accommodationsFacade.Object);
        //}

        [Test]
        public void CreateInstanceTypeOfHomeControllerTest()
        {
            //Arrange
            Controller controller = HomeController;

            //Act
            var type = typeof(HomeController);

            //Assert
            Assert.IsInstanceOf(type, controller);
        }

        [Test]
        public void IndexReturnsInstanceOfViewResultTest()
        {
            //Arrange
            var controller = HomeController;

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void Index_ViewResult_ViewData_Model_IsInstanceOfIEnumerableOfAccommodationDataTransferObjectTest()
        {
            //Arrange
            var controller = HomeController;
            var type = typeof(IPageModel<AccommodationDataTransferObject>);

            //Act
            var result = controller.Index() as ViewResult; ;
            // ReSharper disable once PossibleNullReferenceException
            var accommodations = result.Model;

            //Assert
            Assert.IsInstanceOf(type, accommodations);
        }
    }
}