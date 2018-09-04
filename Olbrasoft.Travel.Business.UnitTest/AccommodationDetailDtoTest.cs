using NUnit.Framework;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Business.UnitTest
{
    [TestFixture]
    public class AccommodationDetailDtoTest
    {
        [Test]
        public void AccommodationDetailDto_Inherits_From_AccommodationDto()
        {
            //Arrange
            var type = typeof(AccommodationDto);

            //Act
            var accommodationDetailDto = new AccommodationDetailDto();

            //Assert
            Assert.IsInstanceOf(type,accommodationDetailDto);
        }


        [Test]
        public void Properties_Get_Set()
        {

            //Arrange
            const string someName = "Some Name";
            const string someDescription = "Some Description";
           
            //Act
            var accommodationDetailDto = new AccommodationDetailDto
            {
                Name = someName,
                Description = someDescription
            };

            //Assert
            Assert.Multiple(() =>
            {
                Assert.IsTrue(accommodationDetailDto.Name==someName);
                Assert.IsTrue(accommodationDetailDto.Description==someDescription);
            });

        }

    }
}