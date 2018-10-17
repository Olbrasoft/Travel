using NUnit.Framework;
using Olbrasoft.Travel.Data.Entity.Model.Identity;

namespace Olbrasoft.Travel.Data.Entity.Unit.Tests
{
    [TestFixture]
    internal class IdentityDatabaseContextTest
    {
        [Test]
        public void Instance_Is_IdentityDbContext_Of_User_Comma_Role_Comma_Integer_Comma_UserLogin_Comma_UserRole_Comma_UserClaim()
        {
            //Arrange
            var type =
                typeof(Microsoft.AspNet.Identity.EntityFramework.IdentityDbContext<User, Role, int, UserLogin, Membership,
                    UserClaim>);

            //Act
            var context= new IdentityDatabaseContext();

            //Assert
            Assert.IsInstanceOf(type,context);
        }
    }
}