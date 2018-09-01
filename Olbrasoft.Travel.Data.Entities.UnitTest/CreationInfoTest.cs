using NUnit.Framework;

namespace Olbrasoft.Travel.Data.Entities.UnitTest
{
    [TestFixture]
    public class CreationInfoTest
    {
        [Test]
        public void IsInstanceOfICreationInfo()
        {
            
            var type = typeof(ICreationInfo);

            var result = new CreationInfo();

            Assert.IsInstanceOf(type, result);
        }

        [Test]
        public void IdIs10()
        {
            //Arrange
            var c = new CreationInfo(){Id=10};

            //Act
            var r = c.Id;

            //Assert
            Assert.IsTrue(r == 10);
        }


    }
}
