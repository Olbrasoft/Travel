using Moq;
using NUnit.Framework;
using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Entity.Query.Handler;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests.Query.Handler
{
    [TestFixture]
    internal class AccommodationDetailByIdTest
    {
        [Test]
        public void Instance_Implement_Interface_IHandler()
        {
            //Arrange
            var localizedAccommodationsMock = new Mock<IHaveQueryable<LocalizedAccommodation>>();

            //Act
            var handler = new AccommodationDetailById(localizedAccommodationsMock.Object);

            //Assert
            Assert.IsInstanceOf<IHandle<GetAccommodationDetailById, AccommodationDetail>>(handler);
        }

        //[Test]
        //public void MyTestMethod()
        //{
        //    //Arrange
        //    var localizedAccommodationsMock = new Mock<IHaveLocalizedAccommodations>();
        //    localizedAccommodationsMock.Setup(p => p.LocalizedAccommodations)
        //        .Returns(new LocalizedAccommodation[1].AsQueryable());

        //    var handler = new AccommodationDetailById(localizedAccommodationsMock.Object);

        //    var processorMock = new Mock<IQueryProcessor>();

        //    var getAccommodationDetailById= new GetAccommodationDetailById(processorMock.Object);

        //    //var accommodationDetailByIdMock =new Mock<GetAccommodationDetailById>();
        //    //accommodationDetailByIdMock.Setup(p => p.Id).Returns(0);
        //    //accommodationDetailByIdMock.Setup(p => p.LanguageId).Returns(1033);

        //    //Act
        //    var result = handler.Handle(getAccommodationDetailById);

        //    //Assert

        //}
    }
}