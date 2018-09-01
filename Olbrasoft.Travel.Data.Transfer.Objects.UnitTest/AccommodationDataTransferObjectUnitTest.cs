using NUnit.Framework;

namespace Olbrasoft.Travel.Data.Transfer.Objects.UnitTest
{
    [TestFixture]
    public class AccommodationDataTransferObjectUnitTest
    {
        [Test]
        public void CreateInstanceOfTypeAccommodationTransferObjectUnitTest()
        {
            //Arrange 
            var accommodationDto= new AccommodationDto();

            //Act
            var type = typeof(AccommodationDto);

            //Assert
            Assert.IsInstanceOf(type, accommodationDto);

        }

        [Test]
        public void AccommodationTransferObjectIdUnitTest()
        {
            //Arrange 
            var accommodationDataTransferObject = new AccommodationDto();

            //Act
            var id = accommodationDataTransferObject.Id;

            //Assert
            Assert.IsInstanceOf<int>(id);

        }


        [Test]
        public void AccommodationTransferObjectNameUnitTest()
        {
            //Arrange 
            const string testName = "testName";
            var accommodationDataTransferObject = new AccommodationDto {Name = testName};

            //Act
            var name = accommodationDataTransferObject.Name;

            //Assert
            Assert.IsTrue(name == testName);

        }
        
        [Test]
        public void AccommodationTransferObjectLocationUnitTest()
        {
            //Arrange 
            const string testLocation = "testLocation";
            var accommodationDataTransferObject = new AccommodationDto { Location = testLocation };

            //Act
            var location = accommodationDataTransferObject.Location;

            //Assert
            Assert.IsTrue(location == testLocation);

        }

        [Test]
        public void AccommodationTransferObjectAdressUnitTest()
        {
            //Arrange 
            const string testAdress = "testAdress";
            var accommodationDataTransferObject = new AccommodationDto { Address = testAdress };

            //Act
            var adress = accommodationDataTransferObject.Address;

            //Assert
            Assert.IsTrue(adress == testAdress);

        }

        
    }
}
