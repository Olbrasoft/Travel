using NUnit.Framework;
using Olbrasoft.Data.Entity;


namespace Olbrasoft.Travel.Data.Entity.Model.Unit.Tests
{
    [TestFixture]
    internal class UserTest
    {
        [Test]
        public void Instance_Is_Of_User_Of_Integer()
        {
            //Arrange
            var type = typeof(User<int>);

            //Act
            var user = new User();

            //Assert
            Assert.IsInstanceOf(type, user);
        }
    }
}