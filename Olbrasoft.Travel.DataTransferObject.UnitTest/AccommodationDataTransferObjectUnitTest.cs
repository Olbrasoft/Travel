using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Olbrasoft.Travel.DataTransferObject.UnitTest
{
    [TestClass]
    public class AccommodationDataTransferObjectUnitTest
    {
        [TestMethod]
        public void CreateInstanceOfTypeAccommodationTransferObjectUnitTest()
        {
            //Arrange 
            var accommodationDataTransferObject= new AccommodationDataTransferObject();

            //Act
            var type = typeof(AccommodationDataTransferObject);

            //Assert
            Assert.IsInstanceOfType(accommodationDataTransferObject, type);

        }

        [TestMethod]
        public void AccommodationTransferObjectIdUnitTest()
        {
            //Arrange 
            var accommodationDataTransferObject = new AccommodationDataTransferObject();

            //Act
            var id = accommodationDataTransferObject.Id;

            //Assert
            Assert.IsInstanceOfType(id, typeof(int));

        }


        [TestMethod]
        public void AccommodationTransferObjectNameUnitTest()
        {
            //Arrange 
            const string testName = "testName";
            var accommodationDataTransferObject = new AccommodationDataTransferObject {Name = testName};

            //Act
            var name = accommodationDataTransferObject.Name;

            //Assert
            Assert.IsTrue(name == testName);

        }
        
        [TestMethod]
        public void AccommodationTransferObjectLocationUnitTest()
        {
            //Arrange 
            const string testLocation = "testLocation";
            var accommodationDataTransferObject = new AccommodationDataTransferObject { Location = testLocation };

            //Act
            var location = accommodationDataTransferObject.Location;

            //Assert
            Assert.IsTrue(location == testLocation);

        }

        [TestMethod]
        public void AccommodationTransferObjectAdressUnitTest()
        {
            //Arrange 
            const string testAdress = "testAdress";
            var accommodationDataTransferObject = new AccommodationDataTransferObject { Address = testAdress };

            //Act
            var adress = accommodationDataTransferObject.Address;

            //Assert
            Assert.IsTrue(adress == testAdress);

        }





    }
}
