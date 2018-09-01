using NUnit.Framework;

namespace Olbrasoft.Travel.Data.Transfer.Objects.UnitTest
{
    [TestFixture]
    public class AccommodationDtoTest
    {
        [Test]
        public void Is_instance_of_AccommodationDto()
        {
            //Arrange 
            var accommodationDto= new AccommodationDto();

            //Act
            var type = typeof(AccommodationDto);

            //Assert
            Assert.IsInstanceOf(type, accommodationDto);

        }

        [Test]
        public void Id_is_instance_of_integer()
        {
            //Arrange 
            var accommodationDto = new AccommodationDto();

            //Act
            var id = accommodationDto.Id;

            //Assert
            Assert.IsInstanceOf<int>(id);

        }


        [Test]
        public void Name_Is_testName()
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
        public void Location_is_testLocation()
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
        public void Address_is_testAddress()
        {
            //Arrange 
            const string testAddress = "testAddress";
            var accommodationDataTransferObject = new AccommodationDto { Address = testAddress };

            //Act
            var adress = accommodationDataTransferObject.Address;

            //Assert
            Assert.IsTrue(adress == testAddress);

        }

        
    }
}
