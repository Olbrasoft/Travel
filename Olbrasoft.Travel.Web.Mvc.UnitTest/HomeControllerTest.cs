using System.Collections.Generic;
using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using Olbrasoft.Travel.BusinessLogicLayer;
using Olbrasoft.Travel.DataTransferObject;
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
            
            //Act
            var result = HomeController.Index() as ViewResult; ;
            var accommodations =  result.ViewData.Model;

            //Assert
            Assert.IsInstanceOf<IEnumerable<AccommodationDataTransferObject>>(accommodations);
        }



    }
}
