using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using Olbrasoft.Travel.BusinessLogicLayer;
using Olbrasoft.Travel.Web.Mvc.Controllers;

namespace Olbrasoft.Travel.Web.Mvc.UnitTest
{
    [TestFixture()]
    public class HomeControllerTest
    {
        public HomeController HomeController { get; private set; } 

        [SetUp]
        public void Setup()
        {
            var accommodationsFacade = new Mock<IAccommodationsFacade>();
            HomeController = new HomeController(accommodationsFacade.Object);
        }


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
        public void HomeControllerIndexTest()
        {
            //Arrange
            var controller = HomeController;

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsInstanceOf<ViewResult>(result);

        }
    }
}
