using NUnit.Framework;
using Olbrasoft.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Identity;


namespace Olbrasoft.Travel.Data.Entity.Model.Unit.Tests
{
    [TestFixture]
    internal class UserTest
    {
        [Test]
        public void Instance_Is_Of_User_Of_Integer()
        {
            //Arrange
            var type = typeof(Microsoft.AspNet.Identity.EntityFramework.IdentityUser<int,UserLogin,Membership,UserClaim>);

            //Act
            var user = new User();

            //Assert
            Assert.IsInstanceOf(type, user);
        }
    }
}